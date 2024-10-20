using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudyZone
{
    public partial class MiniTimerForm : Form
    {
        private MainForm mainForm;
        private Font originalFont;


        public MiniTimerForm(MainForm parentForm)
        {
            InitializeComponent();
            mainForm = parentForm;


            // Store the original font
            originalFont = lblMiniTimer.Font;

            // Update the timer label and button states based on the main form's state
            UpdateTimerLabel(mainForm.GetRemainingTime());
            UpdateButtonStates();

            // Subscribe to the TimerTick event from the main form
            mainForm.TimerTick += MainForm_TimerTick;
        }

        // Method to update the timer label
        public void UpdateTimerLabel(TimeSpan remainingTime)
        {
            lblMiniTimer.Text = string.Format("{0:D2}:{1:D2}", remainingTime.Minutes, remainingTime.Seconds);
        }

        // Event handler for the main form's TimerTick event
        private void MainForm_TimerTick(TimeSpan remainingTime)
        {
            // Update the timer label
            UpdateTimerLabel(remainingTime);
        }

        // Unsubscribe from the TimerTick event when the form is closing
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            mainForm.TimerTick -= MainForm_TimerTick;
            base.OnFormClosing(e);
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            mainForm.StartSession();
            UpdateButtonStates();
        }


        private void btnPause_Click(object sender, EventArgs e)
        {
            mainForm.PauseSession();
            UpdateButtonStates();
        }


        // Stop button click event handler
        private void btnStop_Click(object sender, EventArgs e)
        {
            mainForm.StopSession();
            UpdateButtonStates();
        }

        public void UpdateButtonStates()
        {
            if (mainForm.IsSessionRunning())
            {
                btnStart.Enabled = false;
                btnPause.Enabled = true;
                btnPause.Text = "Pause";
                btnStop.Enabled = true;
            }
            else if (mainForm.IsSessionPaused())
            {
                btnStart.Enabled = false;
                btnPause.Enabled = true;
                btnPause.Text = "Resume";
                btnStop.Enabled = true;
            }
            else
            {
                btnStart.Enabled = true;
                btnPause.Enabled = false;
                btnPause.Text = "Pause";
                btnStop.Enabled = false;
            }
        }

        private void MiniTimerForm_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;
            btnStart.Visible = true;
            btnPause.Visible = true;
            btnStop.Visible = true;

            // Reset the font size of lblMiniTimer
            lblMiniTimer.Font = originalFont;

            // Reset label properties if modified
            lblMiniTimer.Dock = DockStyle.None;
            lblMiniTimer.TextAlign = ContentAlignment.MiddleCenter;

            // Optionally, reset the label size and position
            lblMiniTimer.AutoSize = false;
            lblMiniTimer.Size = new Size(200, 100); // Adjust as needed
            lblMiniTimer.Location = new Point((this.ClientSize.Width - lblMiniTimer.Width) / 2, 20); // Center horizontally
        }

        private void MiniTimerForm_Deactivate(object sender, EventArgs e)
        {
            this.Opacity = 0.4;
            btnStart.Visible = false;
            btnPause.Visible = false;
            btnStop.Visible = false;

            // Increase the font size of lblMiniTimer
            lblMiniTimer.Font = new Font(lblMiniTimer.Font.FontFamily, lblMiniTimer.Font.Size * 2, lblMiniTimer.Font.Style);

            // Adjust label properties
            lblMiniTimer.Dock = DockStyle.Fill;
            lblMiniTimer.TextAlign = ContentAlignment.MiddleCenter;
            lblMiniTimer.AutoSize = false; // Ensure it fills the form
        }

        private void MiniTimerForm_Resize(object sender, EventArgs e)
        {
            if (!this.ContainsFocus)
            {
                // Adjust font size based on form size
                AdjustFontSize();
            }
        }

        private void AdjustFontSize()
        {
            // Calculate a suitable font size based on the form size
            float fontSize = Math.Min(this.ClientSize.Width, this.ClientSize.Height) / 2;
            lblMiniTimer.Font = new Font(lblMiniTimer.Font.FontFamily, fontSize, lblMiniTimer.Font.Style);
        }

    }
}
