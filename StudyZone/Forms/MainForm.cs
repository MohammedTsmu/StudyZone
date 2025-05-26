using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Text;
using System.Windows.Forms;
using System.Xml.Schema;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Newtonsoft.Json;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using IWshRuntimeLibrary;
using static System.Collections.Specialized.BitVector32;
using System.Reflection;



namespace StudyZone
{
    public partial class MainForm : Form
    {
        List<StudySession> sessions = new List<StudySession>();
        private SessionLog currentSessionLog;
        private List<SessionLog> sessionLogs = new List<SessionLog>();
        private List<TaskItem> tasks = new List<TaskItem>();
        private Timer notificationTimer;
        private HashSet<TaskItem> notifiedTasks = new HashSet<TaskItem>();
        private List<StudyReminder> reminders = new List<StudyReminder>();
        private Timer reminderTimer;
        private HashSet<string> triggeredReminders = new HashSet<string>();
        private ContextMenuStrip trayMenu;
        public event Action<TimeSpan> TimerTick;
        private bool isPaused = false;

        //int totalSeconds = 0;
        //bool isStudyTime = true;
        private int totalSeconds = 0;
        private bool isStudyTime = true;

        //Fields to Track Pause Duration and Reminders
        private Timer pauseDurationTimer;
        private int pauseDurationInSeconds = 0;
        private int pauseReminderThreshold = 300; // Time in seconds after which to start reminders (e.g., 300 seconds = 5 minutes)
        private int pauseReminderInterval = 120; // Reminder interval in seconds (e.g., 120 seconds = 2 minutes)
        //pauseDurationTimer: A timer to track how long the session has been paused.
        //pauseDurationInSeconds: Counter to keep track of the paused duration.
        //pauseReminderThreshold: The duration after which reminders should start (e.g., 5 minutes).
        //pauseReminderInterval: How often to remind the user after the threshold is reached(e.g., every 2 minutes).

        //Note: To use FlashWindow, you need to import the function from user32.dll:
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool FlashWindow(IntPtr hwnd, bool bInvert);


        public MainForm()
        {

            InitializeComponent();
            LoadSessions();
            LoadSessionLogsFromFile();
            LoadTasksFromFile();
            LoadRemindersFromFile();
            LoadSettings();
            InitializeTrayMenu();
            CheckForDueTasks();

            // Initialize notification timer
            notificationTimer = new Timer();
            notificationTimer.Interval = 600000; // Set interval to 10 minutes (600,000 milliseconds)
            //notificationTimer.Interval = 10000; // Small Testing interval to test the application it is for developer only will be removed once everything checked.
            notificationTimer.Tick += NotificationTimer_Tick;

            // Initialize pause duration timer
            pauseDurationTimer = new Timer();
            pauseDurationTimer.Interval = 1000; // Tick every second
            pauseDurationTimer.Tick += PauseDurationTimer_Tick;

            UpdateButtonStates();
            // Start the reminder timer
            StartReminderTimer();
        }

        
        private void timerPomodoro_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                UpdateTimerLabel();

                // Raise the TimerTick event
                TimerTick?.Invoke(TimeSpan.FromSeconds(totalSeconds));
            }
            else
            {
                timerPomodoro.Stop();
                if (isStudyTime)
                {
                    // Update study duration
                    int studyTimeInSeconds = ((int)spinStudyMinutes.Value * 60) + (int)spinStudySeconds.Value;
                    currentSessionLog.StudyDuration += TimeSpan.FromSeconds(studyTimeInSeconds);

                    // Start Break
                    int breakDuration = ((int)spinBreakMinutes.Value * 60) + (int)spinBreakSeconds.Value;

                    // Increment the number of breaks
                    currentSessionLog.NumberOfBreaks++;

                    // Stop the notification timer during the break
                    notificationTimer.Stop();

                    BreakForm breakForm = new BreakForm();
                    breakForm.StartBreak(breakDuration);
                    breakForm.ShowDialog();

                    // Update break duration
                    currentSessionLog.BreakDuration += TimeSpan.FromSeconds(breakDuration);

                    // After the break
                    totalSeconds = ((int)spinStudyMinutes.Value * 60) + (int)spinStudySeconds.Value;
                    isStudyTime = true;
                    UpdateTimerLabel();
                    timerPomodoro.Start();

                    // Restart the notification timer
                    notificationTimer.Start();
                }
            }
        }

        public TimeSpan GetRemainingTime()
        {
            return TimeSpan.FromSeconds(totalSeconds);
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            StartSession();
        }

        private void btnPause_Click(object sender, EventArgs e)
        {
            PauseSession();
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            StopSession();
        }

        public void StartSession()
        {
            if (isPaused)
            {
                // Resume the paused session
                timerPomodoro.Start();
                isPaused = false;
            }
            else if (!timerPomodoro.Enabled)
            {
                // Start a new session only if the timer is not running and not paused
                totalSeconds = ((int)spinStudyMinutes.Value * 60) + (int)spinStudySeconds.Value;
                isStudyTime = true;
                UpdateTimerLabel();
                timerPomodoro.Start();

                //// Initialize current session log
                //currentSessionLog = new SessionLog();
                if (cmbSessions.SelectedItem is StudySession selected)
                {
                    currentSessionLog = new SessionLog
                    {
                        SessionName = selected.SessionName
                    };
                }
                else
                {
                    currentSessionLog = new SessionLog
                    {
                        SessionName = $"Session {DateTime.Now:MMM dd, HH:mm}"
                    };
                }


                // Clear the notified tasks list
                notifiedTasks.Clear();

                // Start notification timer
                notificationTimer.Start();

                // Disable session selection and other componenets while the timer is running
                cmbSessions.Enabled = false;
                btnSaveSession.Enabled = false;
                btnDeleteSession.Enabled = false;
                spinStudyMinutes.Enabled = false;
                spinStudySeconds.Enabled = false;
                spinBreakMinutes.Enabled = false;
                spinBreakSeconds.Enabled = false;
            }

            UpdateButtonStates();
        }

        public void PauseSession()
        {
            if (timerPomodoro.Enabled)
            {
                // Pause the session
                timerPomodoro.Stop();
                isPaused = true;

                // Start tracking pause duration
                pauseDurationInSeconds = 0;
                pauseDurationTimer.Start();
            }
            else if (isPaused)
            {
                // Resume the session
                timerPomodoro.Start();
                isPaused = false;

                // Stop tracking pause duration
                pauseDurationTimer.Stop();
                pauseDurationInSeconds = 0;
            }

            // Keep session selection and other components disabled while paused
            cmbSessions.Enabled = false;
            btnSaveSession.Enabled = false;
            btnDeleteSession.Enabled = false;
            spinStudyMinutes.Enabled = false;
            spinStudySeconds.Enabled = false;
            spinBreakMinutes.Enabled = false;
            spinBreakSeconds.Enabled = false;

            UpdateButtonStates();
        }

        public void StopSession()
        {
            if (timerPomodoro.Enabled || isPaused)
            {
                timerPomodoro.Stop();
                totalSeconds = 0;

                // Reset pause state and timer
                isPaused = false;
                pauseDurationTimer.Stop();
                pauseDurationInSeconds = 0;
                UpdateTimerLabel();

                if (currentSessionLog != null)
                {
                    SaveSessionLog(currentSessionLog);
                    currentSessionLog = null;
                }

                // Stop notification timer
                notificationTimer.Stop();

                // Re-enable session selection
                cmbSessions.Enabled = true;
                btnSaveSession.Enabled = true;
                btnDeleteSession.Enabled = true;
                spinStudyMinutes.Enabled = true;
                spinStudySeconds.Enabled = true;
                spinBreakMinutes.Enabled = true;
                spinBreakSeconds.Enabled = true;
            }

            UpdateButtonStates();
        }




        private void SaveSessionLog(SessionLog log)
        {
            sessionLogs.Add(log);
            SaveSessionLogsToFile();
        }

        private void SaveSessionLogsToFile()
        {
            try
            {
                string filePath = Path.Combine(Application.LocalUserAppDataPath, "sessionLogs.json");
                Directory.CreateDirectory(Application.LocalUserAppDataPath);

                // Serialize the sessionLogs list to JSON
                string json = JsonConvert.SerializeObject(sessionLogs, Formatting.Indented);

                // Write the JSON string to the file
                System.IO.File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving session logs: " + ex.Message);
            }
        }

        private void LoadSessionLogsFromFile()
        {
            string filePath = Path.Combine(Application.LocalUserAppDataPath, "sessionLogs.json");
            if (System.IO.File.Exists(filePath))
            {
                try
                {
                    string json = System.IO.File.ReadAllText(filePath);
                    sessionLogs = JsonConvert.DeserializeObject<List<SessionLog>>(json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading session logs: " + ex.Message);
                    sessionLogs = new List<SessionLog>();
                }
            }
        }

        
        private void UpdateTimerLabel()
        {
            int hours = totalSeconds / 3600;
            int minutes = (totalSeconds % 3600) / 60;
            int seconds = totalSeconds % 60;

            if (hours > 0)
            {
                lblTimer.Text = $"{hours:D2}:{minutes:D2}:{seconds:D2}";
            }
            else
            {
                lblTimer.Text = $"{minutes:D2}:{seconds:D2}";
            }

            if (isPaused)
            {
                lblTimer.ForeColor = Color.Gray; // Or any color you prefer
            }
            else
            {
                lblTimer.ForeColor = Color.Black;
            }
        }



        public void UpdateButtonStates()
        {
            if (IsSessionRunning())
            {
                btnStart.Enabled = false;
                btnPause.Enabled = true;
                btnStop.Enabled = true;
                btnPause.Text = "Pause";
                btnPause.Image = StudyZone.Properties.Resources.Pause_PNG_40;
            }
            else if (IsSessionPaused())
            {
                btnStart.Enabled = false;
                btnPause.Enabled = true;
                btnStop.Enabled = true;
                btnPause.Text = "Resume";
                btnPause.Image = StudyZone.Properties.Resources.Resume_Button_PNG_40;
            }
            else
            {
                btnStart.Enabled = true;
                btnPause.Enabled = false;
                btnStop.Enabled = false;
                //btnPause.Text = "Pause";
            }
        }

        private void btnSaveSession_Click(object sender, EventArgs e)
        {
            // Prompt the user for a session name
            string sessionName = Interaction.InputBox("Enter Session Name:", "Save Session", "Session " + (sessions.Count + 1));
            if (!string.IsNullOrEmpty(sessionName))
            {
                // Create a new session
                StudySession newSession = new StudySession
                {
                    SessionName = sessionName,
                    StudyMinutes = (int)spinStudyMinutes.Value,
                    StudySeconds = (int)spinStudySeconds.Value,
                    BreakMinutes = (int)spinBreakMinutes.Value,
                    BreakSeconds = (int)spinBreakSeconds.Value
                };
                sessions.Add(newSession);
                cmbSessions.Properties.Items.Add(newSession);
            }
        }

        private void cmbSessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (timerPomodoro.Enabled || isPaused)
            {
                // Do not allow changing sessions while the timer is active or paused
                MessageBox.Show("Cannot change session while a study session is running or paused. Please stop the session first.",
                                "Action Restricted",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Warning);
                return;
            }

            if (cmbSessions.SelectedItem is StudySession selectedSession)
            {
                spinStudyMinutes.Value = selectedSession.StudyMinutes;
                spinStudySeconds.Value = selectedSession.StudySeconds;
                spinBreakMinutes.Value = selectedSession.BreakMinutes;
                spinBreakSeconds.Value = selectedSession.BreakSeconds;

                // Update the total seconds based on the new session
                totalSeconds = (selectedSession.StudyMinutes * 60) + selectedSession.StudySeconds;

                // Update the timer label immediately
                UpdateTimerLabel();

                DisplayTasksForSelectedSession();
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            SaveSessions();
            base.OnFormClosing(e);
        }

        private void SaveSessions()
        {
            try
            {
                string filePath = Path.Combine(Application.LocalUserAppDataPath, "sessions.json");
                Directory.CreateDirectory(Application.LocalUserAppDataPath);

                // Serialize the sessions list to JSON
                string json = JsonConvert.SerializeObject(sessions, Formatting.Indented);

                // Write the JSON string to the file
                System.IO.File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving sessions: " + ex.Message);
            }
        }

        private void btnDeleteSession_Click(object sender, EventArgs e)
        {
            if (cmbSessions.SelectedItem is StudySession selectedSession)
            {

                if (selectedSession.IsDefault)
                {
                    MessageBox.Show("Default sessions cannot be deleted.", "Delete Session", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    return;
                }

                // Confirm deletion
                var result = MessageBox.Show($"Are you sure you want to delete the session '{selectedSession.SessionName}'?",
                                             "Delete Session",
                                             MessageBoxButtons.YesNo,
                                             MessageBoxIcon.Warning);

                if (result == DialogResult.Yes)
                {
                    // Remove the session from the list
                    sessions.Remove(selectedSession);

                    // Remove the session from the ComboBox
                    cmbSessions.Properties.Items.Remove(selectedSession);

                    // Save the updated sessions list
                    SaveSessions();

                    // Clear the session details from the input controls
                    spinStudyMinutes.Value = spinStudyMinutes.Properties.MinValue;
                    spinStudySeconds.Value = spinStudySeconds.Properties.MinValue;
                    spinBreakMinutes.Value = spinBreakMinutes.Properties.MinValue;
                    spinBreakSeconds.Value = spinBreakSeconds.Properties.MinValue;


                    MessageBox.Show("Session deleted successfully.", "Delete Session", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            else
            {
                MessageBox.Show("Please select a session to delete.", "Delete Session", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void LoadSessions()
        {
            string filePath = Path.Combine(Application.LocalUserAppDataPath, "sessions.json");
            sessions = new List<StudySession>();

            if (System.IO.File.Exists(filePath))
            {
                try
                {
                    // Read the JSON string from the file
                    string json = System.IO.File.ReadAllText(filePath);

                    // Deserialize the JSON string back to the sessions list
                    sessions = JsonConvert.DeserializeObject<List<StudySession>>(json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading sessions: " + ex.Message);
                    sessions = new List<StudySession>();
                }
            }

            if (sessions.Count == 0)
            {
                // Add default sessions if no sessions are loaded
                AddDefaultSessions();
            }

            // Populate the ComboBox
            cmbSessions.Properties.Items.Clear();
            cmbSessions.Properties.Items.AddRange(sessions.ToArray());
        }

        private void AddDefaultSessions()
        {
            // Pomodoro 25/5 Session
            sessions.Add(new StudySession
            {
                SessionName = "Pomodoro 25/5",
                StudyMinutes = 25,
                StudySeconds = 0,
                BreakMinutes = 5,
                BreakSeconds = 0,
                IsDefault = true
            });

            // Gamma Focus 30/5 Session
            sessions.Add(new StudySession
            {
                SessionName = "Gamma Focus 30/5",
                StudyMinutes = 30,
                StudySeconds = 0,
                BreakMinutes = 5,
                BreakSeconds = 0,
                IsDefault = true
            });

            // Neuro Boost 45/10 Session
            sessions.Add(new StudySession
            {
                SessionName = "Neuro Boost 45/10",
                StudyMinutes = 45,
                StudySeconds = 0,
                BreakMinutes = 10,
                BreakSeconds = 0,
                IsDefault = true
            });

            // Deep Focus 60/10 Session
            sessions.Add(new StudySession
            {
                SessionName = "Deep Focus 60/10",
                StudyMinutes = 60,
                StudySeconds = 20,
                BreakMinutes = 10,
                BreakSeconds = 0,
                IsDefault = true
            });

            // Flow Cycle 75/15 Session
            sessions.Add(new StudySession
            {
                SessionName = "Flow Cycle 75/15",
                StudyMinutes = 75,
                StudySeconds = 0,
                BreakMinutes = 15,
                BreakSeconds = 0,
                IsDefault = true
            });

            // Ultra Focus 52/17 (Science-backed by a study in 2014 that suggests 52 minutes is the optimal time)
            sessions.Add(new StudySession
            {
                SessionName = "Ultra Focus 52/17",
                StudyMinutes = 52,
                StudySeconds = 0,
                BreakMinutes = 17,
                BreakSeconds = 0,
                IsDefault = true
            });

            // Dynamic Focus 90/30 (Recommended for intense learning sessions, backed by cognitive studies)
            sessions.Add(new StudySession
            {
                SessionName = "Dynamic Focus 90/30",
                StudyMinutes = 90,
                StudySeconds = 0,
                BreakMinutes = 30,
                BreakSeconds = 0,
                IsDefault = true
            });
        }

        private void btnViewLogs_Click(object sender, EventArgs e)
        {
            SessionLogsForm logsForm = new SessionLogsForm(sessionLogs, SaveSessionLogsToFile);
            logsForm.ShowDialog();
        }

        private void LoadTasksFromFile()
        {
            string filePath = Path.Combine(Application.LocalUserAppDataPath, "tasks.json");
            if (System.IO.File.Exists(filePath))
            {
                try
                {
                    string json = System.IO.File.ReadAllText(filePath);
                    tasks = JsonConvert.DeserializeObject<List<TaskItem>>(json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading tasks: " + ex.Message);
                    tasks = new List<TaskItem>();
                }
            }
        }

        private void SaveTasksToFile()
        {
            try
            {
                string filePath = Path.Combine(Application.LocalUserAppDataPath, "tasks.json");
                Directory.CreateDirectory(Application.LocalUserAppDataPath);

                string json = JsonConvert.SerializeObject(tasks, Formatting.Indented);
                System.IO.File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving tasks: " + ex.Message);
            }
        }

        private void btnTaskManager_Click(object sender, EventArgs e)
        {
            TaskManagerForm taskManagerForm = new TaskManagerForm(tasks, SaveTasksToFile, sessions);
            taskManagerForm.ShowDialog();
        }

        private void DisplayTasksForSelectedSession()
        {
            txtTaskDetails.Text = string.Empty; // Clear task details

            if (cmbSessions.SelectedItem is StudySession selectedSession)
            {
                var tasksForSession = tasks.FindAll(t => t.SessionAssignment == selectedSession.SessionName && !t.IsCompleted);

                //listViewTasks.Items.Clear();
                //foreach (var task in tasksForSession)
                //{
                //    ListViewItem item = new ListViewItem(task.Title);
                //    item.SubItems.Add(task.DueDate.HasValue ? task.DueDate.Value.ToShortDateString() : "N/A");
                //    item.SubItems.Add(GetTaskStatus(task));

                //    // Apply formatting based on due date
                //    ApplyTaskFormatting(item, task);

                //    item.Tag = task; // Store the TaskItem in the Tag property
                //    listViewTasks.Items.Add(item);
                //}
                gridTasks.DataSource = null;
                gridTasks.DataSource = tasksForSession;

                //اعدادات الاعمدة
                var view = gridTasks.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
                if (view != null)
                {
                    view.Columns["Title"].Caption = "Title";
                    view.Columns["DueDate"].Caption = "Due Date";
                    view.Columns["SessionAssignment"].Caption = "Session";
                    view.Columns["IsCompleted"].Caption = "Completed";

                    view.Columns["DueDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                    view.Columns["DueDate"].DisplayFormat.FormatString = "d";

                    view.OptionsView.ShowGroupPanel = false;
                    view.OptionsBehavior.Editable = false;

                    //// اخفاء الاعمدة التي لا نحتاجها
                    //view.Columns["Description"].Visible = false;

                }

            }
        }

        private string GetTaskStatus(TaskItem task)
        {
            if (task.IsCompleted)
                return "Completed";
            else
                return "Pending";
        }

        private void ApplyTaskFormatting(ListViewItem item, TaskItem task)
        {
            if (task.DueDate.HasValue)
            {
                DateTime today = DateTime.Today;
                TimeSpan timeRemaining = task.DueDate.Value.Date - today;

                if (task.IsCompleted)
                {
                    // No special formatting for completed tasks
                }
                else if (timeRemaining.TotalDays < 0)
                {
                    // Overdue tasks - display in red
                    item.ForeColor = Color.Red;
                }
                else if (timeRemaining.TotalDays <= 3)
                {
                    // Tasks due within 3 days - display in orange
                    item.ForeColor = Color.Orange;
                }
            }
        }

        //private void listViewTasks_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    if (listViewTasks.SelectedItems.Count > 0)
        //    {
        //        ListViewItem selectedItem = listViewTasks.SelectedItems[0];
        //        if (selectedItem.Tag is TaskItem selectedTask)
        //        {
        //            // Display task details
        //            StringBuilder taskDetails = new StringBuilder();
        //            taskDetails.AppendLine($"Title: {selectedTask.Title}");
        //            taskDetails.AppendLine($"Description: {selectedTask.Description}");
        //            if (selectedTask.DueDate.HasValue)
        //            {
        //                taskDetails.AppendLine($"Due Date: {selectedTask.DueDate.Value.ToShortDateString()}");
        //            }
        //            else
        //            {
        //                taskDetails.AppendLine("Due Date: N/A");
        //            }
        //            taskDetails.AppendLine($"Assigned Session: {selectedTask.SessionAssignment}");
        //            txtTaskDetails.Text = taskDetails.ToString();
        //        }
        //    }
        //    else
        //    {
        //        txtTaskDetails.Text = string.Empty;
        //    }
        //}
        private void gridViewTasks_FocusedRowChanged(object sender, DevExpress.XtraGrid.Views.Base.FocusedRowChangedEventArgs e)
        {
            var view = sender as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view != null && view.FocusedRowHandle >= 0)
            {
                var selectedTask = view.GetRow(view.FocusedRowHandle) as TaskItem;
                if (selectedTask != null)
                {
                    StringBuilder taskDetails = new StringBuilder();
                    taskDetails.AppendLine($"Title: {selectedTask.Title}");
                    taskDetails.AppendLine($"Description: {selectedTask.Description}");
                    if (selectedTask.DueDate.HasValue)
                        taskDetails.AppendLine($"Due Date: {selectedTask.DueDate.Value.ToShortDateString()}");
                    else
                        taskDetails.AppendLine("Due Date: N/A");
                    taskDetails.AppendLine($"Assigned Session: {selectedTask.SessionAssignment}");

                    txtTaskDetails.Text = taskDetails.ToString();
                }
            }
            else
            {
                txtTaskDetails.Text = string.Empty;
            }
        }

        private void CheckForDueTasks()
        {
            DateTime today = DateTime.Today;
            List<TaskItem> dueTasks = new List<TaskItem>();

            foreach (var task in tasks)
            {
                if (task.IsCompleted)
                    continue;

                if (task.DueDate.HasValue)
                {
                    TimeSpan timeRemaining = task.DueDate.Value.Date - today;
                    if (timeRemaining.TotalDays < 0 || timeRemaining.TotalDays <= 1)
                    {
                        dueTasks.Add(task);
                    }
                }
            }

            if (dueTasks.Count > 0)
            {
                StringBuilder message = new StringBuilder();
                message.AppendLine("You have tasks that are due soon or overdue:");
                foreach (var task in dueTasks)
                {
                    message.AppendLine($"- {task.Title} (Due: {task.DueDate.Value.ToShortDateString()})");
                }
                MessageBox.Show(message.ToString(), "Task Reminders", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void NotificationTimer_Tick(object sender, EventArgs e)
        {
            CheckForDueTasksDuringSession();
        }

        private void CheckForDueTasksDuringSession()
        {
            DateTime today = DateTime.Today;
            List<TaskItem> dueTasks = new List<TaskItem>();

            foreach (var task in tasks)
            {
                if (task.IsCompleted)
                    continue;

                if (notifiedTasks.Contains(task))
                    continue; // Skip tasks that have already been notified

                if (task.DueDate.HasValue)
                {
                    TimeSpan timeRemaining = task.DueDate.Value.Date - today;
                    if (timeRemaining.TotalDays < 0 || timeRemaining.TotalDays <= 1)
                    {
                        dueTasks.Add(task);
                        notifiedTasks.Add(task); // Mark task as notified
                    }
                }
            }

            if (dueTasks.Count > 0)
            {
                // Build the notification message
                StringBuilder message = new StringBuilder();

                message.AppendLine("Tasks due soon or overdue:");

                int maxTasksToShow = 5;
                int tasksShown = 0;

                foreach (var task in dueTasks)
                {
                    if (tasksShown >= maxTasksToShow)
                    {
                        message.AppendLine($"And {dueTasks.Count - maxTasksToShow} more...");
                        break;
                    }

                    message.AppendLine($"- {task.Title} (Due: {task.DueDate.Value.ToShortDateString()})");
                    tasksShown++;
                }

                // Display a notification
                ShowNotification(message.ToString());
            }


        }

        private void ShowNotification(string message)
        {
            // Display a balloon tip notification
            notifyIcon.Visible = true; // Ensure the icon is visible
            notifyIcon.BalloonTipTitle = "StudyZone Reminder";
            notifyIcon.BalloonTipText = message;
            notifyIcon.ShowBalloonTip(10000); // Display for 5 seconds
        }


        //Double check if you use it or remove it please
        //Double check if you use it or remove it please
        //Double check if you use it or remove it please
        private void TaskCompleted(TaskItem completedTask)
        {
            // Remove the task from notifiedTasks if it exists
            if (notifiedTasks.Contains(completedTask))
            {
                notifiedTasks.Remove(completedTask);
            }

            // Save tasks to file
            SaveTasksToFile();
        }

        private void LoadRemindersFromFile()
        {
            string filePath = Path.Combine(Application.LocalUserAppDataPath, "reminders.json");
            if (System.IO.File.Exists(filePath))
            {
                try
                {
                    string json = System.IO.File.ReadAllText(filePath);
                    reminders = JsonConvert.DeserializeObject<List<StudyReminder>>(json);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading reminders: " + ex.Message);
                    reminders = new List<StudyReminder>();
                }
            }
        }

        private void SaveRemindersToFile()
        {
            try
            {
                string filePath = Path.Combine(Application.LocalUserAppDataPath, "reminders.json");
                Directory.CreateDirectory(Application.LocalUserAppDataPath);

                string json = JsonConvert.SerializeObject(reminders, Formatting.Indented);
                System.IO.File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving reminders: " + ex.Message);
            }
        }

        private void btnReminders_Click(object sender, EventArgs e)
        {
            ReminderManagerForm reminderManagerForm = new ReminderManagerForm(reminders, SaveRemindersToFile);
            reminderManagerForm.ShowDialog();

            // Restart the reminder timer in case reminders were modified
            StartReminderTimer();
        }

        private void StartReminderTimer()
        {
            if (reminderTimer != null)
            {
                reminderTimer.Stop();
                reminderTimer.Dispose();
            }

            reminderTimer = new Timer();
            reminderTimer.Interval = 60000; // Check every minute
            reminderTimer.Tick += ReminderTimer_Tick;
            reminderTimer.Start();
        }

        private void ReminderTimer_Tick(object sender, EventArgs e)
        {
            CheckForReminders();
        }

        private void CheckForReminders()
        {
            DateTime now = DateTime.Now;

            foreach (var reminder in reminders)
            {
                if (!reminder.IsEnabled)
                    continue;

                // Get the time of day for the reminder
                TimeSpan reminderTimeOfDay = reminder.ReminderTime.TimeOfDay;

                // Check if it's time to show the reminder (within a 1-minute window)
                if (Math.Abs((now.TimeOfDay - reminderTimeOfDay).TotalMinutes) < 1)
                {
                    if (reminder.IsRecurring)
                    {
                        // For recurring reminders, check if we have already triggered it today
                        if (reminder.LastTriggeredDate != now.Date)
                        {
                            // Show the reminder notification
                            ShowNotification($"Reminder: {reminder.ReminderName}");
                            reminder.LastTriggeredDate = now.Date;
                            // Save reminders if you want to persist LastTriggeredDate
                            SaveRemindersToFile();
                        }
                    }
                    else
                    {
                        // For non-recurring reminders, check if the date matches and hasn't been triggered yet
                        if (reminder.ReminderTime.Date == now.Date && reminder.LastTriggeredDate != now)
                        {
                            // Show the reminder notification
                            ShowNotification($"Reminder: {reminder.ReminderName}");
                            reminder.LastTriggeredDate = now;
                            SaveRemindersToFile();
                        }
                    }
                }
            }
        }

        private void MainForm_Resize(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Minimized)
            {
                // Hide the form
                this.Hide();

                // Show the notify icon (system tray icon)
                notifyIcon.Visible = true;

                // Optionally, show a balloon tip when minimized
                notifyIcon.BalloonTipTitle = "StudyZone";
                notifyIcon.BalloonTipText = "StudyZone is minimized to the system tray.";
                notifyIcon.ShowBalloonTip(3000); // Display for 3 seconds
            }
        }


        private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        {
            // Show the form
            this.Show();
            this.WindowState = FormWindowState.Normal;

            // Hide the notify icon
            notifyIcon.Visible = false;
        }

        private void InitializeTrayMenu()
        {
            trayMenu = new ContextMenuStrip();
            trayMenu.Items.Add("Restore", null, Restore_Click);
            trayMenu.Items.Add("Exit", null, Exit_Click);

            notifyIcon.ContextMenuStrip = trayMenu;
        }

        private void Restore_Click(object sender, EventArgs e)
        {
            // Show the form
            this.Show();
            this.WindowState = FormWindowState.Normal;

            // Hide the notify icon
            notifyIcon.Visible = false;
        }
        
        private void Exit_Click(object sender, EventArgs e)
        {
            // Trigger the form closing event
            // Close the application
            this.Close();
        }

        private void MainForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            // Check if a study session is active
            if (timerPomodoro.Enabled)
            {
                // Inform the user that the application cannot be closed during an active session
                MessageBox.Show("You cannot exit the application while a study session is running. Please stop the session before exiting.", "Cannot Exit", MessageBoxButtons.OK, MessageBoxIcon.Information);

                // Cancel the close action
                e.Cancel = true;
            }
            else
            {
                // Perform any cleanup if necessary
                notifyIcon.Visible = false;
            }
        }

        private void LoadSettings()
        {
            // Load the 'Start with Windows' setting
            string filePath = Path.Combine(Application.LocalUserAppDataPath, "settings.json");
            if (System.IO.File.Exists(filePath))
            {
                try
                {
                    string json = System.IO.File.ReadAllText(filePath);
                    var settings = JsonConvert.DeserializeObject<AppSettings>(json);
                    chkStartWithWindows.Checked = settings.StartWithWindows;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading settings: " + ex.Message);
                }
            }
        }

        private void chkStartWithWindows_CheckedChanged(object sender, EventArgs e)
        {
            bool startWithWindows = chkStartWithWindows.Checked;
            SaveSettings(startWithWindows);

            if (startWithWindows)
            {
                EnableStartup();
            }
            else
            {
                DisableStartup();
            }
        }

        private void SaveSettings(bool startWithWindows)
        {
            try
            {
                string filePath = Path.Combine(Application.LocalUserAppDataPath, "settings.json");
                var settings = new AppSettings
                {
                    StartWithWindows = startWithWindows
                };
                string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
                System.IO.File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving settings: " + ex.Message);
            }
        }

        private void EnableStartup()
        {
            try
            {
                string startupFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                string shortcutPath = Path.Combine(startupFolderPath, "StudyZone.lnk");

                // Create a shortcut to the application
                CreateShortcut(shortcutPath, Application.ExecutablePath, "StudyZone");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while enabling startup: " + ex.Message);
            }
        }

        private void DisableStartup()
        {
            try
            {
                string startupFolderPath = Environment.GetFolderPath(Environment.SpecialFolder.Startup);
                string shortcutPath = Path.Combine(startupFolderPath, "StudyZone.lnk");

                if (System.IO.File.Exists(shortcutPath))
                {
                    System.IO.File.Delete(shortcutPath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while disabling startup: " + ex.Message);
            }
        }

        private void CreateShortcut(string shortcutPath, string targetPath, string shortcutDescription)
        {
            WshShell shell = new WshShell();
            IWshShortcut shortcut = (IWshShortcut)shell.CreateShortcut(shortcutPath);
            shortcut.TargetPath = targetPath;
            shortcut.WorkingDirectory = Application.StartupPath;
            shortcut.Description = shortcutDescription;
            shortcut.Save();
        }

        private void btnMiniTimer_Click(object sender, EventArgs e)
        {
            // Hide the main form
            this.Hide();

            // Disable the button
            btnMiniTimer.Enabled = false;

            // Show the mini timer form
            MiniTimerForm miniTimerForm = new MiniTimerForm(this);
            miniTimerForm.Show();

            // Handle the mini form's FormClosed event to show the main form again
            miniTimerForm.FormClosed += MiniTimerForm_FormClosed;
        }

        private void MiniTimerForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            // Show the main form
            this.Show();

            // Re-enable the button
            btnMiniTimer.Enabled = true;
        }

        public bool IsSessionRunning()
        {
            return timerPomodoro.Enabled && !isPaused;
        }

        public bool IsSessionPaused()
        {
            return isPaused;
        }

        private void PauseDurationTimer_Tick(object sender, EventArgs e)
        {
            pauseDurationInSeconds++;

            if (pauseDurationInSeconds == pauseReminderThreshold)
            {
                // Time to start reminders
                ShowPauseReminder();
            }
            else if (pauseDurationInSeconds > pauseReminderThreshold &&
                     (pauseDurationInSeconds - pauseReminderThreshold) % pauseReminderInterval == 0)
            {
                // Time for subsequent reminders
                ShowPauseReminder();
            }
        }

        private void ShowPauseReminder()
        {
            // Display a balloon tip notification
            notifyIcon.Visible = true; // Ensure the icon is visible
            notifyIcon.BalloonTipTitle = "StudyZone - Session Paused";
            notifyIcon.BalloonTipText = "Your study session has been paused. Don't forget to resume!";
            notifyIcon.ShowBalloonTip(10000); // Display for 10 seconds

            // Optionally, you can play a sound or bring the application to the front
            // For example, you can flash the taskbar icon:
            FlashWindow(this.Handle, true);
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            About about = new About();
            about.Show();
        }


    }
}