using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;

namespace StudyZone
{
    public partial class BreakForm : Form
    {
        private KeyboardHook keyboardHook;
        private bool allowClose = false; // Flag to control form closing
        private int breakSeconds = 0;
        private int totalBreakSeconds = 0;
        private Label lblCountdownTimer;
        private Label lblQuote;
        private CircularProgressBar progressBar;
        private SoundPlayer player;

        private List<string> motivationalQuotes = new List<string>
        {
            "“The future depends on what you do today.” – Mahatma Gandhi",
            "“Don't watch the clock; do what it does. Keep going.” – Sam Levenson",
            "“Success is not the key to happiness. Happiness is the key to success.” – Albert Schweitzer",
            // Add more quotes as desired
        };

        public BreakForm()
        {
            InitializeComponent();

            // Form settings
            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.TopMost = true;
            this.BackColor = Color.Black;
            this.KeyPreview = true;

            // Set the background image
            this.BackgroundImage = Properties.Resources.BackgroundImage; // Replace 'BackgroundImage' with your resource name
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Initialize controls
            InitializeTimerLabel();
            InitializeQuoteLabel();
            InitializeProgressBar();
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

            // Play background music
            player = new SoundPlayer(Properties.Resources.BackgroundMusic); // Replace 'BackgroundMusic' with your resource name
            player.PlayLooping();
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

                // Stop the music
                if (player != null)
                {
                    player.Stop();
                    player.Dispose();
                }

                base.OnFormClosing(e); // Allow the form to close
            }
        }

        public void StartBreak(int seconds)
        {
            breakSeconds = seconds;
            totalBreakSeconds = seconds; // Keep track of the total duration
            UpdateTimerLabel();
            UpdateProgressBar();

            // Start the timer if not already started
            if (!this.timerBreak.Enabled)
                this.timerBreak.Start();
        }

        private void UpdateTimerLabel()
        {
            int minutes = breakSeconds / 60;
            int seconds = breakSeconds % 60;
            lblCountdownTimer.Text = $"{minutes:D2}:{seconds:D2}";
        }

        private void timerBreak_Tick(object sender, EventArgs e)
        {
            if (breakSeconds > 0)
            {
                breakSeconds--;
                UpdateTimerLabel();
                UpdateProgressBar();
            }
            else
            {
                this.timerBreak.Stop();
                allowClose = true;
                this.Close();
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

        private void InitializeTimerLabel()
        {
            lblCountdownTimer = new Label();
            lblCountdownTimer.AutoSize = false;
            lblCountdownTimer.Size = new Size(800, 200);
            lblCountdownTimer.Location = new Point((this.Width - lblCountdownTimer.Width) / 2, 100);
            lblCountdownTimer.Font = new Font("Segoe UI", 72F, FontStyle.Bold);
            lblCountdownTimer.ForeColor = Color.White;
            lblCountdownTimer.TextAlign = ContentAlignment.MiddleCenter;
            lblCountdownTimer.BackColor = Color.Transparent;
            this.Controls.Add(lblCountdownTimer);
        }

        private void InitializeQuoteLabel()
        {
            lblQuote = new Label();
            lblQuote.AutoSize = false;
            lblQuote.Size = new Size(1000, 100);
            lblQuote.Location = new Point((this.Width - lblQuote.Width) / 2, lblCountdownTimer.Bottom + 20);
            lblQuote.Font = new Font("Segoe UI", 24F, FontStyle.Italic);
            lblQuote.ForeColor = Color.White;
            lblQuote.TextAlign = ContentAlignment.MiddleCenter;
            lblQuote.BackColor = Color.Transparent;
            this.Controls.Add(lblQuote);

            // Set a random quote
            Random rand = new Random();
            int index = rand.Next(motivationalQuotes.Count);
            lblQuote.Text = motivationalQuotes[index];
        }

        private void InitializeProgressBar()
        {
            progressBar = new CircularProgressBar();
            progressBar.Size = new Size(300, 300);
            progressBar.Location = new Point((this.Width - progressBar.Width) / 2, lblQuote.Bottom + 20);
            progressBar.BackColor = Color.Transparent;
            //progressBar.BackColor = Color.Black; // Use a solid color for testing
            this.Controls.Add(progressBar);
        }
        

        private void UpdateProgressBar()
        {
            progressBar.Progress = (int)(((double)(totalBreakSeconds - breakSeconds) / totalBreakSeconds) * 100);
            progressBar.Invalidate(); // Force the control to repaint
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle, Color.FromArgb(50, Color.Black), Color.Transparent, 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }
    }
}
