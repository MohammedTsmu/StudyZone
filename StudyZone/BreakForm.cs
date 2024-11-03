using System;
using System.Drawing;
using System.Windows.Forms;

namespace StudyZone
{
    public partial class BreakForm : Form
    {
        private KeyboardHook keyboardHook;
        private bool allowClose = false; // Flag to control form closing
        private int breakSeconds = 0;

        public BreakForm()
        {
            InitializeComponent();

            // Set up the form
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            //this.TopMost = true;

            // Optionally, set the background color or image
            //this.BackColor = Color.Black;
            //this.BackgroundImage = /* your background image */;
            //this.BackgroundImageLayout = ImageLayout.Stretch;

            // Add KeyPreview to capture key events
            this.KeyPreview = true;
        }

        protected override void OnLoad(EventArgs e)
        {
            base.OnLoad(e);

            // Hide the cursor
            Cursor.Hide();
            Cursor.Clip = this.Bounds;

            // Install the keyboard hook
            keyboardHook = new KeyboardHook();
            keyboardHook.Install();

            // Start the break timer if not already started
            if (!this.timerBreak.Enabled)
                this.timerBreak.Start();
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
                // Show the cursor
                Cursor.Show();
                Cursor.Clip = Rectangle.Empty;

                // Uninstall the keyboard hook
                keyboardHook.Uninstall();

                base.OnFormClosing(e); // Allow the form to close
            }
        }

        public void StartBreak(int seconds)
        {
            breakSeconds = seconds;
            UpdateTimerLabel();

            // Start the timer if not already started
            if (!this.timerBreak.Enabled)
                this.timerBreak.Start();
        }



        // Update the Timer Label
        private void UpdateTimerLabel()
        {
            int minutes = breakSeconds / 60;
            int seconds = breakSeconds % 60;
            this.lblBreakTimer.Text = $"Break Time: {minutes:D2}:{seconds:D2}";
        }

        public void timerBreak_Tick(object sender, EventArgs e)
        {
            if (breakSeconds > 0)
            {
                breakSeconds--;
                UpdateTimerLabel();
            }
            else
            {
                this.timerBreak.Stop();
                allowClose = true; // Allow the form to close
                this.Close(); // Close the break screen when time is up
            }
        }

        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            if (keyData == (Keys.Control | Keys.Shift | Keys.Q))
            {
                allowClose = true;
                this.Close();
                return true;
            }
            return base.ProcessCmdKey(ref msg, keyData);
        }
    }
}
