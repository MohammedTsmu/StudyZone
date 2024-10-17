using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.VisualBasic;


namespace StudyZone
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();

            // Add default sessions
            sessions.Add(new StudySession
            {
                SessionName = "Pomodoro 25/5",
                StudyMinutes = 25,
                StudySeconds = 0,
                BreakMinutes = 5,
                BreakSeconds = 0
            });

            sessions.Add(new StudySession
            {
                SessionName = "60 Study / 10 Break",
                StudyMinutes = 60,
                StudySeconds = 20,
                BreakMinutes = 10,
                BreakSeconds = 0
            });

            sessions.Add(new StudySession
            {
                SessionName = "90 Study / 20 Break",
                StudyMinutes = 90,
                StudySeconds = 0,
                BreakMinutes = 20,
                BreakSeconds = 0
            });

            // Populate the ComboBox
            cmbSessions.Items.AddRange(sessions.ToArray());
        }

        
        int totalSeconds = 0;
        bool isStudyTime = true;
        List<StudySession> sessions = new List<StudySession>();


        //private void timerPomodoro_Tick(object sender, EventArgs e)
        //{
        //    if (totalSeconds > 0)
        //    {
        //        totalSeconds--;
        //        int minutes = totalSeconds / 60;
        //        int seconds = totalSeconds % 60;
        //        lblTimer.Text = $"{minutes:D2}:{seconds:D2}";
        //    }
        //    else
        //    {
        //        timerPomodoro.Stop();
        //        //if (isStudyTime)
        //        //{
        //        //    MessageBox.Show("Time for a break!");
        //        //    totalSeconds = (int)nudBreakMinutes.Value * 60;
        //        //    isStudyTime = false;
        //        //    timerPomodoro.Start();
        //        //}
        //        if (isStudyTime)
        //        {
        //            timerPomodoro.Stop();
        //            int breakDuration = (int)nudBreakMinutes.Value * 60;
        //            // Show the Break Screen
        //            BreakForm breakForm = new BreakForm();
        //            breakForm.StartBreak(breakDuration);
        //            breakForm.ShowDialog();
        //            // After the break
        //            totalSeconds = (int)nudStudyMinutes.Value * 60;
        //            isStudyTime = true;
        //            timerPomodoro.Start();
        //        }

        //        else
        //        {
        //            MessageBox.Show("Break over! Back to study.");
        //            totalSeconds = (int)nudStudyMinutes.Value * 60;
        //            isStudyTime = true;
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
            //totalSeconds = (int)nudStudyMinutes.Value * 60;
            //isStudyTime = true;
            //timerPomodoro.Start();

            totalSeconds = ((int)nudStudyMinutes.Value * 60) + (int)nudStudySeconds.Value;
            isStudyTime = true;
            UpdateTimerLabel();
            timerPomodoro.Start();
        }



        //private void btnStop_Click(object sender, EventArgs e)
        //{
        //    timerPomodoro.Stop();
        //    lblTimer.Text = "00:00";
        //}

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

        //private void btnSaveSession_Click(object sender, EventArgs e)
        //{

        //}
        private void btnSaveSession_Click(object sender, EventArgs e)
        {
            // Prompt the user for a session name
            string sessionName = Microsoft.VisualBasic.Interaction.InputBox("Enter Session Name:", "Save Session", "Session " + (sessions.Count + 1));
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

    }

}
