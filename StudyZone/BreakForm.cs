using System;
using System.Windows.Forms;

namespace StudyZone
{
    public partial class BreakForm : Form
    {
        public BreakForm()
        {
            InitializeComponent();
        }

        protected override CreateParams CreateParams
        {
            get
            {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x08000000; // WS_EX_NOACTIVATE
                return cp;
            }
        }

        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            if (!allowClose)
            {
                // Prevent the form from being closed by the user
                e.Cancel = true;
            }
            else
            {
                base.OnFormClosing(e); // Allow the form to close
            }
        }

        // Declare variables to keep track of the break time
        int breakSeconds = 0;
        private bool allowClose = false; // Flag to control form closing

        public void StartBreak(int seconds)
        {
            breakSeconds = seconds;
            UpdateTimerLabel();
            timerBreak.Start();
        }

        // Update the Timer Label
        private void UpdateTimerLabel()
        {
            int minutes = breakSeconds / 60;
            int seconds = breakSeconds % 60;
            lblBreakTimer.Text = $"Break Time: {minutes:D2}:{seconds:D2}";
        }

        private void timerBreak_Tick(object sender, EventArgs e)
        {
            if (breakSeconds > 0)
            {
                breakSeconds--;
                UpdateTimerLabel();
            }
            else
            {
                timerBreak.Stop();
                allowClose = true; // Allow the form to close
                this.Close(); // Close the break screen when time is up
            }
        }
    }
}