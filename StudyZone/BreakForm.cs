using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Media;
using System.Diagnostics;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Rebar;
using System.Runtime.InteropServices;

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
        // Add these fields at the class level
        private List<Particle> particles = new List<Particle>();
        private Timer particleTimer;
        private Stopwatch stopwatch;
        private float lastFrameTime = 0f;
        private static Random rand = new Random();
        private int maxParticles = 100; // Set an appropriate limit



        public BreakForm()
        {
            InitializeComponent();

            // Form settings
            //this.FormBorderStyle = FormBorderStyle.None;
            //this.WindowState = FormWindowState.Maximized;
            //this.TopMost = true;
            //this.BackColor = Color.Black;
            //this.KeyPreview = true;

            this.FormBorderStyle = FormBorderStyle.None;
            this.WindowState = FormWindowState.Maximized;
            this.StartPosition = FormStartPosition.CenterScreen;
            this.BackColor = Color.Black;
            this.KeyPreview = true;


            // Set the background image
            this.BackgroundImage = Properties.Resources.BackgroundImage; // Replace 'BackgroundImage' with your resource name
            this.BackgroundImageLayout = ImageLayout.Stretch;

            // Initialize controls
            InitializeTimerLabel();
            InitializeQuoteLabel();
            InitializeProgressBar();
            this.Resize += BreakForm_Resize;

            // Initialize and start the particle timer in OnLoad or here
            InitializeParticleSystem();
            // Enable double buffering to reduce flickering and improve rendering performance
            this.SetStyle(ControlStyles.AllPaintingInWmPaint | ControlStyles.UserPaint | ControlStyles.DoubleBuffer, true);
        }
        private void BreakForm_Resize(object sender, EventArgs e)
        {
            if (lblCountdownTimer != null)
            {
                lblCountdownTimer.Location = new Point(
                    (this.ClientSize.Width - lblCountdownTimer.Width) / 2,
                    (this.ClientSize.Height - lblCountdownTimer.Height) / 3
                );
            }

            if (lblQuote != null)
            {
                lblQuote.Location = new Point(
                    (this.ClientSize.Width - lblQuote.Width) / 2,
                    lblCountdownTimer.Bottom + 20
                );
            }

            if (progressBar != null)
            {
                progressBar.Location = new Point(
                    (this.ClientSize.Width - progressBar.Width) / 2,
                    lblQuote.Bottom + 20
                );
            }
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

            // Call the resize event handler to initially center elements
            BreakForm_Resize(this, EventArgs.Empty);
        }

        private void ParticleTimer_Tick(object sender, EventArgs e)
        {
            try
            {
                float currentTime = (float)stopwatch.Elapsed.TotalSeconds;
                float deltaTime = currentTime - lastFrameTime;
                lastFrameTime = currentTime;

                // Update particles
                UpdateParticles(deltaTime);

                // Invalidate only the area where particles are drawn
                Rectangle particleArea = new Rectangle(0, 0, this.Width, this.Height);
                this.Invalidate(particleArea, false);
            }
            catch (Exception ex)
            {
                Debug.WriteLine($"Exception in ParticleTimer_Tick: {ex.Message}");
                // Optionally, stop the timer to prevent further issues
                particleTimer.Stop();
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

                // Stop the particle timer
                if (particleTimer != null)
                {
                    particleTimer.Stop();
                    particleTimer.Dispose();
                }

                // Stop the stopwatch
                if (stopwatch != null)
                {
                    stopwatch.Stop();
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
            lblCountdownTimer.Font = new Font("Segoe UI", 72F, FontStyle.Bold);
            lblCountdownTimer.ForeColor = Color.White;
            lblCountdownTimer.TextAlign = ContentAlignment.MiddleCenter;
            lblCountdownTimer.BackColor = Color.Transparent;

            // تعيين الموقع بعد معرفة حجم النموذج
            lblCountdownTimer.Location = new Point(
                (this.ClientSize.Width - lblCountdownTimer.Width) / 2,
                (this.ClientSize.Height - lblCountdownTimer.Height) / 3
            );

            this.Controls.Add(lblCountdownTimer);
        }

        private void InitializeQuoteLabel()
        {
            lblQuote = new Label();
            lblQuote.AutoSize = false;
            lblQuote.Size = new Size(1000, 100);
            lblQuote.Font = new Font("Segoe UI", 24F, FontStyle.Italic);
            lblQuote.ForeColor = Color.White;
            lblQuote.TextAlign = ContentAlignment.MiddleCenter;
            lblQuote.BackColor = Color.Transparent;

            // تعيين الموقع بعد إعداد lblCountdownTimer
            lblQuote.Location = new Point(
                (this.ClientSize.Width - lblQuote.Width) / 2,
                lblCountdownTimer.Bottom + 20
            );

            this.Controls.Add(lblQuote);

            // اختيار اقتباس عشوائي
            Random rand = new Random();
            int index = rand.Next(motivationalQuotes.Count);
            lblQuote.Text = motivationalQuotes[index];
        }

        private void InitializeProgressBar()
        {
            progressBar = new CircularProgressBar();
            progressBar.Size = new Size(300, 300);
            progressBar.BackColor = Color.Transparent;

            // تعيين الموقع بعد إعداد lblQuote
            progressBar.Location = new Point(
                (this.ClientSize.Width - progressBar.Width) / 2,
                lblQuote.Bottom + 20
            );

            this.Controls.Add(progressBar);
        }



        private void InitializeParticleSystem()
        {
            // If not already initialized in OnLoad
            stopwatch = new Stopwatch();
            stopwatch.Start();

            particleTimer = new Timer();
            particleTimer.Interval = 16; // Approximately 60 FPS
            particleTimer.Tick += ParticleTimer_Tick;
            particleTimer.Start();
        }

        private void UpdateProgressBar()
        {
            progressBar.Progress = (int)(((double)(totalBreakSeconds - breakSeconds) / totalBreakSeconds) * 100);
            progressBar.Invalidate(); // Force the control to repaint
        }

        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            // Draw particles
            DrawParticles(e.Graphics);

            // ... existing gradient overlay code ...
            using (System.Drawing.Drawing2D.LinearGradientBrush brush = new System.Drawing.Drawing2D.LinearGradientBrush(
                this.ClientRectangle, Color.FromArgb(50, Color.Black), Color.Transparent, 90F))
            {
                e.Graphics.FillRectangle(brush, this.ClientRectangle);
            }
        }

        private void DrawParticles(Graphics g)
        {
            foreach (var particle in particles)
            {
                // Skip particles with no remaining life
                if (particle.Life <= 0)
                    continue;

                using (SolidBrush brush = new SolidBrush(particle.Color))
                {
                    float x = particle.Position.X - particle.Size / 2;
                    float y = particle.Position.Y - particle.Size / 2;
                    g.FillEllipse(brush, x, y, particle.Size, particle.Size);
                }
            }
        }



        private void UpdateParticles(float deltaTime)
        {
            // Add new particles if below the maximum limit
            if (particles.Count < maxParticles)
            {
                AddParticles();
            }

            // Update existing particles
            for (int i = particles.Count - 1; i >= 0; i--)
            {
                particles[i].Update(deltaTime);

                // Remove particles that have expired
                if (particles[i].Life <= 0)
                {
                    particles.RemoveAt(i);
                }
            }
            // Log particle count
            Debug.WriteLine($"Particle Count: {particles.Count}");
        }


        //private void AddParticles()
        //{
        //    // Generate particles at a reduced rate
        //    int particlesToAdd = 1; // Reduce the number of particles added per frame

        //    for (int i = 0; i < particlesToAdd; i++)
        //    {
        //        // Generate random position at the bottom of the form
        //        float x = (float)(rand.NextDouble() * this.Width);
        //        float y = this.Height + 10; // Start slightly off-screen

        //        particles.Add(new Particle(new PointF(x, y)));
        //    }
        //}
        private void AddParticles()
        {
            int particlesToAdd = 14; // مضاعفة عدد الجسيمات المضافة

            for (int i = 0; i < particlesToAdd; i++)
            {
                float x = (float)(rand.NextDouble() * this.Width);
                float y = this.Height - 10; // وضع الجسيمات أعلى قليلاً من أسفل النافذة

                particles.Add(new Particle(new PointF(x, y)));
            }
        }

    }
}