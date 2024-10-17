using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyZone
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        
        int totalSeconds = 0;
        bool isStudyTime = true;

        private void timerPomodoro_Tick(object sender, EventArgs e)
        {
            if (totalSeconds > 0)
            {
                totalSeconds--;
                int minutes = totalSeconds / 60;
                int seconds = totalSeconds % 60;
                lblTimer.Text = $"{minutes:D2}:{seconds:D2}";
            }
            else
            {
                timerPomodoro.Stop();
                //if (isStudyTime)
                //{
                //    MessageBox.Show("Time for a break!");
                //    totalSeconds = (int)nudBreakMinutes.Value * 60;
                //    isStudyTime = false;
                //    timerPomodoro.Start();
                //}
                if (isStudyTime)
                {
                    timerPomodoro.Stop();
                    int breakDuration = (int)nudBreakMinutes.Value * 60;
                    // Show the Break Screen
                    BreakForm breakForm = new BreakForm();
                    breakForm.StartBreak(breakDuration);
                    breakForm.ShowDialog();
                    // After the break
                    totalSeconds = (int)nudStudyMinutes.Value * 60;
                    isStudyTime = true;
                    timerPomodoro.Start();
                }

                else
                {
                    MessageBox.Show("Break over! Back to study.");
                    totalSeconds = (int)nudStudyMinutes.Value * 60;
                    isStudyTime = true;
                    timerPomodoro.Start();
                }
            }
        }


        private void btnStart_Click(object sender, EventArgs e)
        {
            totalSeconds = (int)nudStudyMinutes.Value * 60;
            isStudyTime = true;
            timerPomodoro.Start();
        }

        

        private void btnStop_Click(object sender, EventArgs e)
        {
            timerPomodoro.Stop();
            lblTimer.Text = "00:00";
        }

    }
}
