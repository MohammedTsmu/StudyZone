using System;
using System.Collections.Generic;
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
            // Update initial layout
            ArrangeButtons();
        }

        public void UpdateTimerLabel(TimeSpan remainingTime)
        {
            if (remainingTime.TotalHours >= 1)
            {
                // If total hours is greater than or equal to 1, include hours in the format
                lblMiniTimer.Text = string.Format("{0:D2}:{1:D2}:{2:D2}", (int)remainingTime.TotalHours, remainingTime.Minutes, remainingTime.Seconds);
            }
            else
            {
                // Otherwise, display minutes and seconds only
                lblMiniTimer.Text = string.Format("{0:D2}:{1:D2}", remainingTime.Minutes, remainingTime.Seconds);
            }
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
                btnStart.Visible = false;
                btnPause.Visible = true;
                btnStop.Visible = true;
                //btnPause.Text = "Pause";
                btnPause.Image = StudyZone.Properties.Resources.pause;
            }
            else if (mainForm.IsSessionPaused())
            {
                btnStart.Visible = false;
                btnPause.Visible = true;
                btnStop.Visible = true;
                //btnPause.Text = "Resume";
                btnPause.Image = StudyZone.Properties.Resources.resume;
            }
            else
            {
                btnStart.Visible = true;
                btnPause.Visible = false;
                btnStop.Visible = false;
                //btnPause.Text = "Pause";
                btnPause.Image = StudyZone.Properties.Resources.pause;
            }

            // Rearrange buttons based on visibility
            ArrangeButtons();
        }

        private void MiniTimerForm_Activated(object sender, EventArgs e)
        {
            this.Opacity = 1;

            // Update button states based on the current session state
            UpdateButtonStates();

            // Reset the font size of lblMiniTimer
            lblMiniTimer.Font = originalFont;

            // Increase the font size of lblMiniTimer
            float newFontSize = Math.Min(originalFont.Size * 1.4f, this.ClientSize.Height / 2); // Adjust as needed
            lblMiniTimer.Font = new Font(lblMiniTimer.Font.FontFamily, newFontSize, lblMiniTimer.Font.Style);

            // Reset label properties if modified
            lblMiniTimer.Dock = DockStyle.None;
            lblMiniTimer.TextAlign = ContentAlignment.MiddleCenter;

            // Reset label size and position
            lblMiniTimer.AutoSize = false;
            lblMiniTimer.Size = new Size(this.ClientSize.Width, 40); // Adjust height as needed
            lblMiniTimer.Location = new Point(0, 10); // Position at the top with some margin

            // Reset label color
            lblMiniTimer.ForeColor = Color.White;

            // Arrange buttons
            ArrangeButtons();
        }

        private void MiniTimerForm_Deactivate(object sender, EventArgs e)
        {
            this.Opacity = 0.4;
            btnStart.Visible = false;
            btnPause.Visible = false;
            btnStop.Visible = false;
            lblMiniTimer.Font = originalFont;

            // Increase the font size of lblMiniTimer
            float newFontSize = Math.Min(originalFont.Size * 1.6f, this.ClientSize.Height / 2); // Adjust as needed
            lblMiniTimer.Font = new Font(lblMiniTimer.Font.FontFamily, newFontSize, lblMiniTimer.Font.Style);

            // Adjust label properties
            lblMiniTimer.Dock = DockStyle.Fill;
            lblMiniTimer.TextAlign = ContentAlignment.MiddleCenter;
            lblMiniTimer.AutoSize = false;

            // Adjust label color if needed
            lblMiniTimer.ForeColor = Color.White;
        }

        private void ArrangeButtons()
        {
            int buttonSize = 40;
            int spacing = 5;
            List<Button> visibleButtons = new List<Button>();

            if (btnStart.Visible)
                visibleButtons.Add(btnStart);
            if (btnPause.Visible)
                visibleButtons.Add(btnPause);
            if (btnStop.Visible)
                visibleButtons.Add(btnStop);

            int totalButtonsWidth = (buttonSize * visibleButtons.Count) + (spacing * (visibleButtons.Count - 1));
            int startX = (this.ClientSize.Width - totalButtonsWidth) / 2;
            int y = this.ClientSize.Height - buttonSize;
            //int y = this.ClientSize.Height - buttonSize - 10;

            for (int i = 0; i < visibleButtons.Count; i++)
            {
                Button btn = visibleButtons[i];
                btn.Size = new Size(buttonSize, buttonSize);
                btn.Location = new Point(startX + i * (buttonSize + spacing), y);
            }
        }

        private void MiniTimerForm_Load(object sender, EventArgs e)
        {
            UpdateButtonStates();
        }
    }
}