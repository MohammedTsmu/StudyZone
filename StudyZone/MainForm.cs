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

namespace StudyZone
{
    public partial class MainForm : Form
    {
        int totalSeconds = 0;
        bool isStudyTime = true;
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





        public MainForm()
        {

            InitializeComponent();
            LoadSessions();
            LoadSessionLogsFromFile();
            LoadTasksFromFile();
            LoadRemindersFromFile();
            InitializeTrayMenu();
            CheckForDueTasks();

            // Initialize notification timer
            notificationTimer = new Timer();
            //notificationTimer.Interval = 600000; // Set interval to 10 minutes (600,000 milliseconds)
            notificationTimer.Interval = 10000; // Small Testing interval to test the application it is for developer only will be removed once everything checked.
            notificationTimer.Tick += NotificationTimer_Tick;


            // Start the reminder timer
            StartReminderTimer();


            //reminderTimer.Tick += ReminderTimer_Tick;

            // Test the notification
            //ShowNotification("Test notification from MainForm constructor.");
        }

        //private void timerPomodoro_Tick(object sender, EventArgs e)
        //{
        //    if (totalSeconds > 0)
        //    {
        //        totalSeconds--;
        //        UpdateTimerLabel();
        //    }
        //    else
        //    {
        //        timerPomodoro.Stop();
        //        if (isStudyTime)
        //        {
        //            // Update study duration
        //            int studyTimeInSeconds = ((int)nudStudyMinutes.Value * 60) + (int)nudStudySeconds.Value;
        //            currentSessionLog.StudyDuration += TimeSpan.FromSeconds(studyTimeInSeconds);

        //            // Start Break
        //            int breakDuration = ((int)nudBreakMinutes.Value * 60) + (int)nudBreakSeconds.Value;

        //            // Increment the number of breaks
        //            currentSessionLog.NumberOfBreaks++;

        //            BreakForm breakForm = new BreakForm();
        //            breakForm.StartBreak(breakDuration);
        //            breakForm.ShowDialog();

        //            // Update break duration
        //            currentSessionLog.BreakDuration += TimeSpan.FromSeconds(breakDuration);

        //            // After the break
        //            totalSeconds = ((int)nudStudyMinutes.Value * 60) + (int)nudStudySeconds.Value;
        //            isStudyTime = true;
        //            UpdateTimerLabel();
        //            timerPomodoro.Start();
        //        }
        //    }
        //}
        private void timerPomodoro_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                UpdateTimerLabel();
            }
            else
            {
                timerPomodoro.Stop();
                if (isStudyTime)
                {
                    // Update study duration
                    int studyTimeInSeconds = ((int)nudStudyMinutes.Value * 60) + (int)nudStudySeconds.Value;
                    currentSessionLog.StudyDuration += TimeSpan.FromSeconds(studyTimeInSeconds);

                    // Start Break
                    int breakDuration = ((int)nudBreakMinutes.Value * 60) + (int)nudBreakSeconds.Value;

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
                    totalSeconds = ((int)nudStudyMinutes.Value * 60) + (int)nudStudySeconds.Value;
                    isStudyTime = true;
                    UpdateTimerLabel();
                    timerPomodoro.Start();

                    // Restart the notification timer
                    notificationTimer.Start();
                }
            }
        }



        //private void btnStart_Click(object sender, EventArgs e)
        //{
        //    totalSeconds = ((int)nudStudyMinutes.Value * 60) + (int)nudStudySeconds.Value;
        //    isStudyTime = true;
        //    UpdateTimerLabel();
        //    timerPomodoro.Start();

        //    // Initialize current session log
        //    currentSessionLog = new SessionLog();

        //    // Start notification timer
        //    notificationTimer.Start();
        //}
        private void btnStart_Click(object sender, EventArgs e)
        {
            totalSeconds = ((int)nudStudyMinutes.Value * 60) + (int)nudStudySeconds.Value;
            isStudyTime = true;
            UpdateTimerLabel();
            timerPomodoro.Start();

            // Initialize current session log
            currentSessionLog = new SessionLog();

            // Clear the notified tasks list
            notifiedTasks.Clear();

            // Start notification timer
            notificationTimer.Start();
        }


        private void btnStop_Click(object sender, EventArgs e)
        {
            timerPomodoro.Stop();
            totalSeconds = 0;
            UpdateTimerLabel();

            if (currentSessionLog != null)
            {
                SaveSessionLog(currentSessionLog);
                currentSessionLog = null;
            }

            // Stop notification timer
            notificationTimer.Stop();
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
                File.WriteAllText(filePath, json);
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occurred while saving session logs: " + ex.Message);
            }
        }

        private void LoadSessionLogsFromFile()
        {
            string filePath = Path.Combine(Application.LocalUserAppDataPath, "sessionLogs.json");
            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
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
            int minutes = totalSeconds / 60;
            int seconds = totalSeconds % 60;
            lblTimer.Text = $"{minutes:D2}:{seconds:D2}";
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
                    StudyMinutes = (int)nudStudyMinutes.Value,
                    StudySeconds = (int)nudStudySeconds.Value,
                    BreakMinutes = (int)nudBreakMinutes.Value,
                    BreakSeconds = (int)nudBreakSeconds.Value
                };
                sessions.Add(newSession);
                cmbSessions.Items.Add(newSession);
            }
        }

        private void cmbSessions_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSessions.SelectedItem is StudySession selectedSession)
            {
                nudStudyMinutes.Value = selectedSession.StudyMinutes;
                nudStudySeconds.Value = selectedSession.StudySeconds;
                nudBreakMinutes.Value = selectedSession.BreakMinutes;
                nudBreakSeconds.Value = selectedSession.BreakSeconds;

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
                File.WriteAllText(filePath, json);
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
                    cmbSessions.Items.Remove(selectedSession);

                    // Save the updated sessions list
                    SaveSessions();

                    // Clear the session details from the input controls
                    nudStudyMinutes.Value = nudStudyMinutes.Minimum;
                    nudStudySeconds.Value = nudStudySeconds.Minimum;
                    nudBreakMinutes.Value = nudBreakMinutes.Minimum;
                    nudBreakSeconds.Value = nudBreakSeconds.Minimum;


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

            if (File.Exists(filePath))
            {
                try
                {
                    // Read the JSON string from the file
                    string json = File.ReadAllText(filePath);

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
            cmbSessions.Items.Clear();
            cmbSessions.Items.AddRange(sessions.ToArray());
        }

        private void AddDefaultSessions()
        {
            sessions.Add(new StudySession
            {
                SessionName = "Pomodoro 25/5",
                StudyMinutes = 25,
                StudySeconds = 0,
                BreakMinutes = 5,
                BreakSeconds = 0,
                IsDefault = true
            });

            sessions.Add(new StudySession
            {
                SessionName = "Deep Focus 60/10",
                StudyMinutes = 60,
                StudySeconds = 20,
                BreakMinutes = 10,
                BreakSeconds = 0,
                IsDefault = true
            });

            sessions.Add(new StudySession
            {
                SessionName = "Super Focus 90/20",
                StudyMinutes = 90,
                StudySeconds = 0,
                BreakMinutes = 20,
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
            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
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
                File.WriteAllText(filePath, json);
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

                listViewTasks.Items.Clear();
                foreach (var task in tasksForSession)
                {
                    ListViewItem item = new ListViewItem(task.Title);
                    item.SubItems.Add(task.DueDate.HasValue ? task.DueDate.Value.ToShortDateString() : "N/A");
                    item.SubItems.Add(GetTaskStatus(task));

                    // Apply formatting based on due date
                    ApplyTaskFormatting(item, task);

                    item.Tag = task; // Store the TaskItem in the Tag property
                    listViewTasks.Items.Add(item);
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


        private void listViewTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listViewTasks.SelectedItems.Count > 0)
            {
                ListViewItem selectedItem = listViewTasks.SelectedItems[0];
                if (selectedItem.Tag is TaskItem selectedTask)
                {
                    // Display task details
                    StringBuilder taskDetails = new StringBuilder();
                    taskDetails.AppendLine($"Title: {selectedTask.Title}");
                    taskDetails.AppendLine($"Description: {selectedTask.Description}");
                    if (selectedTask.DueDate.HasValue)
                    {
                        taskDetails.AppendLine($"Due Date: {selectedTask.DueDate.Value.ToShortDateString()}");
                    }
                    else
                    {
                        taskDetails.AppendLine("Due Date: N/A");
                    }
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

        //private void CheckForDueTasksDuringSession()
        //{
        //    DateTime today = DateTime.Today;
        //    List<TaskItem> dueTasks = new List<TaskItem>();

        //    foreach (var task in tasks)
        //    {
        //        if (task.IsCompleted)
        //            continue;

        //        if (task.DueDate.HasValue)
        //        {
        //            TimeSpan timeRemaining = task.DueDate.Value.Date - today;
        //            if (timeRemaining.TotalDays < 0 || timeRemaining.TotalDays <= 1)
        //            {
        //                dueTasks.Add(task);
        //            }
        //        }
        //    }

        //    if (dueTasks.Count > 0)
        //    {
        //        // Build the notification message
        //        StringBuilder message = new StringBuilder();
        //        message.AppendLine("Reminder: You have tasks that are due soon or overdue:");
        //        foreach (var task in dueTasks)
        //        {
        //            message.AppendLine($"- {task.Title} (Due: {task.DueDate.Value.ToShortDateString()})");
        //        }

        //        // Display a notification
        //        ShowNotification(message.ToString());
        //    }
        //}
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

            //Notifications with tasks names.
            //if (dueTasks.Count > 0)
            //{
            //    // Build the notification message
            //    StringBuilder message = new StringBuilder();
            //    message.AppendLine("Reminder: You have tasks that are due soon or overdue:");
            //    foreach (var task in dueTasks)
            //    {
            //        message.AppendLine($"- {task.Title} (Due: {task.DueDate.Value.ToShortDateString()})");
            //    }

            //    // Display a notification
            //    ShowNotification(message.ToString());
            //}

            //////XmlSchemaSimpleContent notifications without tasks names.
            //if (dueTasks.Count > 0)
            //{
            //    // Build the notification message
            //    StringBuilder message = new StringBuilder();

            //    if (dueTasks.Count == 1)
            //    {
            //        var task = dueTasks[0];
            //        message.AppendLine($"Reminder: Task '{task.Title}' is due {(task.DueDate.Value.Date < DateTime.Today ? "today" : "soon")} (Due: {task.DueDate.Value.ToShortDateString()}).");
            //    }
            //    else
            //    {
            //        message.AppendLine($"You have {dueTasks.Count} tasks due soon or overdue.");
            //    }

            //    // Optionally, add more details if desired
            //    //You can comment foreach{} part it if you want to keep the notifications simple
            //    foreach (var task in dueTasks)
            //    {
            //        message.AppendLine($"- {task.Title} (Due: {task.DueDate.Value.ToShortDateString()})");
            //    }

            //    // Display a notification
            //    ShowNotification(message.ToString());
            //}


            //Limit the Number of Tasks Displayed
            //If you decide to include task details, you might want to limit the number of tasks displayed to avoid overwhelming the user.
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

        //private void ShowNotification(string message)
        //{
        //    notifyIcon.Visible = true; // Ensure the icon is visible
        //    notifyIcon.BalloonTipTitle = "StudyZone Reminder";
        //    notifyIcon.BalloonTipText = message;
        //    notifyIcon.ShowBalloonTip(5000); // Display for 5 seconds
        //}



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
            if (File.Exists(filePath))
            {
                try
                {
                    string json = File.ReadAllText(filePath);
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
                File.WriteAllText(filePath, json);
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



        //private void ReminderTimer_Tick(object sender, EventArgs e)
        //{
        //    CheckForReminders();
        //}
        private void ReminderTimer_Tick(object sender, EventArgs e)
        {
            // Debugging message
            //Console.WriteLine("ReminderTimer_Tick called at " + DateTime.Now);
            //MessageBox.Show("ReminderTimer_Tick called at \"" + DateTime.Now);
            CheckForReminders();
        }


        //private void CheckForReminders()
        //{
        //    DateTime now = DateTime.Now;
        //    foreach (var reminder in reminders)
        //    {
        //        if (!reminder.IsEnabled)
        //            continue;

        //        DateTime reminderTime = DateTime.Today.Add(reminder.ReminderTime.TimeOfDay);

        //        // If the reminder is recurring and the time has passed today, skip to the next day
        //        if (reminder.IsRecurring && reminderTime < now)
        //            reminderTime = reminderTime.AddDays(1);

        //        // Check if it's time to show the reminder (allowing for some leeway in case of delays)
        //        if ((now >= reminderTime) && (now - reminderTime).TotalMinutes < 1)
        //        {
        //            // Show the reminder notification
        //            ShowNotification($"Reminder: {reminder.ReminderName}");
        //        }
        //    }
        //}



        //private void CheckForReminders()
        //{
        //    DateTime now = DateTime.Now;
        //    foreach (var reminder in reminders)
        //    {
        //        if (!reminder.IsEnabled)
        //            continue;

        //        DateTime reminderTime = DateTime.Today.Add(reminder.ReminderTime.TimeOfDay);

        //        // Check if the reminder time is today and has not yet occurred
        //        if (reminderTime.Date == now.Date && reminderTime.TimeOfDay <= now.TimeOfDay && (now - reminderTime).TotalMinutes < 1)
        //        {
        //            // Show the reminder notification
        //            ShowNotification($"Reminder: {reminder.ReminderName}");
        //        }
        //        else if (reminder.IsRecurring && reminderTime.Date < now.Date)
        //        {
        //            // For recurring reminders, schedule for the next day
        //            reminderTime = reminderTime.AddDays(1);
        //        }
        //    }
        //}




        //private void CheckForReminders()
        //{
        //    DateTime now = DateTime.Now;
        //    foreach (var reminder in reminders)
        //    {
        //        if (!reminder.IsEnabled)
        //            continue;

        //        DateTime reminderTime = DateTime.Today.Add(reminder.ReminderTime.TimeOfDay);

        //        // For recurring reminders, adjust the reminder time to today or the next day
        //        if (reminder.IsRecurring)
        //        {
        //            if (reminderTime < now)
        //            {
        //                reminderTime = reminderTime.AddDays(1);
        //            }
        //        }

        //        // Check if it's time to show the reminder (within a 1-minute window)
        //        if (Math.Abs((now - reminderTime).TotalMinutes) < 1)
        //        {
        //            // Show the reminder notification
        //            ShowNotification($"Reminder: {reminder.ReminderName}");
        //        }
        //    }
        //}


        //private void CheckForReminders()
        //{
        //    DateTime now = DateTime.Now;

        //    foreach (var reminder in reminders)
        //    {
        //        if (!reminder.IsEnabled)
        //            continue;

        //        // Get the time of day for the reminder
        //        TimeSpan reminderTimeOfDay = reminder.ReminderTime.TimeOfDay;

        //        // Check if it's time to show the reminder (within a 1-minute window)
        //        if (Math.Abs((now.TimeOfDay - reminderTimeOfDay).TotalMinutes) < 1)
        //        {
        //            // For recurring reminders, ensure we haven't already triggered it today
        //            if (reminder.IsRecurring)
        //            {
        //                if (reminder.LastTriggeredDate != now.Date)
        //                {
        //                    // Show the reminder notification
        //                    ShowNotification($"Reminder: {reminder.ReminderName}");
        //                    reminder.LastTriggeredDate = now.Date;
        //                }
        //            }
        //            else
        //            {
        //                // For non-recurring reminders, check the date matches and hasn't been triggered yet
        //                if (reminder.ReminderTime.Date == now.Date && reminder.LastTriggeredDate != now)
        //                {
        //                    // Show the reminder notification
        //                    ShowNotification($"Reminder: {reminder.ReminderName}");
        //                    reminder.LastTriggeredDate = now;
        //                }
        //            }
        //        }
        //    }
        //}



        //private void CheckForReminders()
        //{
        //    DateTime now = DateTime.Now;

        //    foreach (var reminder in reminders)
        //    {
        //        if (!reminder.IsEnabled)
        //            continue;

        //        // Get the time of day for the reminder
        //        TimeSpan reminderTimeOfDay = reminder.ReminderTime.TimeOfDay;

        //        // Generate a unique key for the reminder and date
        //        string reminderKey = $"{reminder.ReminderName}_{now.Date}";

        //        // Check if it's time to show the reminder (within a 1-minute window)
        //        if (Math.Abs((now.TimeOfDay - reminderTimeOfDay).TotalMinutes) < 1)
        //        {
        //            if (!triggeredReminders.Contains(reminderKey))
        //            {
        //                // Show the reminder notification
        //                ShowNotification($"Reminder: {reminder.ReminderName}");

        //                // Add to triggered reminders
        //                triggeredReminders.Add(reminderKey);
        //            }
        //        }
        //    }
        //}

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

        //private void notifyIcon_MouseDoubleClick(object sender, MouseEventArgs e)
        //{

        //}

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
            // Close the application
            this.Close();
        }


    }
}