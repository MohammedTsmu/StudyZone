using System;
using System.Collections.Generic;
using System.IO;
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

        public MainForm()
        {
            InitializeComponent();
            LoadSessions();
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
                    // Start Break
                    int breakDuration = ((int)nudBreakMinutes.Value * 60) + (int)nudBreakSeconds.Value;
                    BreakForm breakForm = new BreakForm();
                    breakForm.StartBreak(breakDuration);
                    breakForm.ShowDialog();
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
        }

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerPomodoro.Stop();
            totalSeconds = 0;
            UpdateTimerLabel();
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
    }
}
