using System;
using System.Collections.Generic;
using System.IO;
using System.Text;
using System.Windows.Forms;
using Microsoft.VisualBasic;
using Newtonsoft.Json;

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


        public MainForm()
        {
            InitializeComponent();
            LoadSessions();
            LoadSessionLogsFromFile();
            LoadTasksFromFile();
        }

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
                }
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            totalSeconds = ((int)nudStudyMinutes.Value * 60) + (int)nudStudySeconds.Value;
            isStudyTime = true;
            UpdateTimerLabel();
            timerPomodoro.Start();

            // Initialize current session log
            currentSessionLog = new SessionLog();
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

                lstTasks.Items.Clear();
                foreach (var task in tasksForSession)
                {
                    lstTasks.Items.Add(task); // Add the TaskItem object directly
                }
            }
        }


        //private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
        private void lstTasks_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (lstTasks.SelectedItem is TaskItem selectedTask)
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
            else
            {
                txtTaskDetails.Text = string.Empty;
            }
        }

    }
}