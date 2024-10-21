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

        // Method to update the timer label
        //public void UpdateTimerLabel(TimeSpan remainingTime)
        //{
        //    lblMiniTimer.Text = string.Format("{0:D2}:{1:D2}", remainingTime.Minutes, remainingTime.Seconds);
        //}
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

        //public void UpdateButtonStates()
        //{
        //    if (mainForm.IsSessionRunning())
        //    {
        //        btnStart.Enabled = false;
        //        btnPause.Enabled = true;
        //        //btnPause.Text = "Pause";
        //        btnPause.Image = StudyZone.Properties.Resources.pause;
        //        btnStop.Enabled = true;
        //    }
        //    else if (mainForm.IsSessionPaused())
        //    {
        //        btnStart.Enabled = false;
        //        btnPause.Enabled = true;
        //        //btnPause.Text = "Resume";
        //        btnPause.Image = StudyZone.Properties.Resources.resume;
        //        btnStop.Enabled = true;
        //    }
        //    else
        //    {
        //        btnStart.Enabled = true;
        //        btnPause.Enabled = false;
        //        //btnPause.Text = "Pause";
        //        btnPause.Image = StudyZone.Properties.Resources.pause;
        //        btnStop.Enabled = false;
        //    }
        //}
        public void UpdateButtonStates()
        {
            if (mainForm.IsSessionRunning())
            {
                btnStart.Visible = false;
                btnPause.Visible = true;
                btnStop.Visible = true;
            }
            else if (mainForm.IsSessionPaused())
            {
                btnStart.Visible = false;
                btnPause.Visible = true;
                btnStop.Visible = true;
            }
            else
            {
                btnStart.Visible = true;
                btnPause.Visible = false;
                btnStop.Visible = false;
            }

            // Rearrange buttons based on visibility
            ArrangeButtons();
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

            // Reset label size and position
            lblMiniTimer.AutoSize = false;
            lblMiniTimer.Size = new Size(this.ClientSize.Width, 40); // Adjust height as needed
            lblMiniTimer.Location = new Point(0, 10); // Position at the top with some margin

            // Reset label color
            lblMiniTimer.ForeColor = Color.White;

            // Arrange buttons
            ArrangeButtons();
        }


        //private void MiniTimerForm_Deactivate(object sender, EventArgs e)
        //{
        //    this.Opacity = 0.4;
        //    btnStart.Visible = false;
        //    btnPause.Visible = false;
        //    btnStop.Visible = false;

        //    // Increase the font size of lblMiniTimer
        //    float newFontSize = originalFont.Size * 1.5f; // Increase font size by 50%
        //    lblMiniTimer.Font = new Font(lblMiniTimer.Font.FontFamily, newFontSize, lblMiniTimer.Font.Style);

        //    // Adjust label properties
        //    lblMiniTimer.Dock = DockStyle.Fill;
        //    lblMiniTimer.TextAlign = ContentAlignment.MiddleCenter;
        //    lblMiniTimer.AutoSize = false;
        //}
        private void MiniTimerForm_Deactivate(object sender, EventArgs e)
        {
            this.Opacity = 0.4;
            btnStart.Visible = false;
            btnPause.Visible = false;
            btnStop.Visible = false;

            // Increase the font size of lblMiniTimer
            float newFontSize = Math.Min(originalFont.Size * 1.5f, this.ClientSize.Height / 2); // Adjust as needed
            lblMiniTimer.Font = new Font(lblMiniTimer.Font.FontFamily, newFontSize, lblMiniTimer.Font.Style);

            // Adjust label properties
            lblMiniTimer.Dock = DockStyle.Fill;
            lblMiniTimer.TextAlign = ContentAlignment.MiddleCenter;
            lblMiniTimer.AutoSize = false;

            // Adjust label color if needed
            lblMiniTimer.ForeColor = Color.White;
        }



        private void MiniTimerForm_Resize(object sender, EventArgs e)
        {
            //if (!this.ContainsFocus)
            //{
            //    // Adjust font size based on form size
            //    AdjustFontSize();
            //}
            //else
            //{
            //    // Re-arrange controls when resized while active
            //    ArrangeButtons();
            //}
        }


        private void AdjustFontSize()
        {
            // Calculate a suitable font size based on the form size
            float fontSize = Math.Min(this.ClientSize.Width, this.ClientSize.Height) / 3.5f; // Adjust divisor as needed
            fontSize = Math.Max(fontSize, 10); // Ensure the font size is at least 10

            lblMiniTimer.Font = new Font(lblMiniTimer.Font.FontFamily, fontSize, lblMiniTimer.Font.Style);
        }

        //private void ArrangeButtons()
        //{
        //    int buttonSize = 40; // Square buttons
        //    int spacing = 5; // Space between buttons
        //    int totalButtonsWidth = (buttonSize * 3) + (spacing * 2);
        //    int startX = (this.ClientSize.Width - totalButtonsWidth) / 2;
        //    int y = this.ClientSize.Height - buttonSize;
        //    //int y = this.ClientSize.Height - buttonSize - 10; // 10 pixels margin from bottom

        //    btnStart.Size = new Size(buttonSize, buttonSize);
        //    btnPause.Size = new Size(buttonSize, buttonSize);
        //    btnStop.Size = new Size(buttonSize, buttonSize);

        //    btnStart.Location = new Point(startX, y);
        //    btnPause.Location = new Point(startX + buttonSize + spacing, y);
        //    btnStop.Location = new Point(startX + (buttonSize + spacing) * 2, y);
        //}
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

        private void btnStart_MouseHover(object sender, EventArgs e)
        {
            // In the constructor or initialization code
            toolTip1.SetToolTip(btnStart, "Start Session");
            toolTip1.SetToolTip(btnPause, "Pause/Resume Session");
            toolTip1.SetToolTip(btnStop, "Stop Session");
        }
    }
}
