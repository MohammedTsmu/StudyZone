namespace StudyZone
{
    partial class BreakForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }


        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BreakForm));
            this.timerBreak = new System.Windows.Forms.Timer(this.components);
            this.lblScreenLocked = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerBreak
            // 
            this.timerBreak.Interval = 1000;
            this.timerBreak.Tick += new System.EventHandler(this.timerBreak_Tick);
            // 
            // lblScreenLocked
            // 
            this.lblScreenLocked.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblScreenLocked.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblScreenLocked.ForeColor = System.Drawing.SystemColors.Control;
            this.lblScreenLocked.Location = new System.Drawing.Point(0, 0);
            this.lblScreenLocked.Name = "lblScreenLocked";
            this.lblScreenLocked.Size = new System.Drawing.Size(800, 42);
            this.lblScreenLocked.TabIndex = 1;
            this.lblScreenLocked.Text = "Screen Locked🔒";
            this.lblScreenLocked.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BreakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblScreenLocked);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BreakForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Break Screen";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer timerBreak;
        private System.Windows.Forms.Label lblScreenLocked;
    }
}