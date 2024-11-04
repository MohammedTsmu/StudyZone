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
            this.label1 = new System.Windows.Forms.Label();
            this.lblBreakTimer = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // timerBreak
            // 
            this.timerBreak.Interval = 1000;
            this.timerBreak.Tick += new System.EventHandler(this.timerBreak_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.Control;
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(124, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Screen Locked🔒";
            // 
            // lblBreakTimer
            // 
            this.lblBreakTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBreakTimer.AutoSize = true;
            this.lblBreakTimer.BackColor = System.Drawing.Color.Transparent;
            this.lblBreakTimer.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblBreakTimer.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBreakTimer.ForeColor = System.Drawing.Color.White;
            this.lblBreakTimer.Location = new System.Drawing.Point(130, 180);
            this.lblBreakTimer.Name = "lblBreakTimer";
            this.lblBreakTimer.Size = new System.Drawing.Size(542, 72);
            this.lblBreakTimer.TabIndex = 0;
            this.lblBreakTimer.Text = "Break Time: 05:00";
            this.lblBreakTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BreakForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DarkBlue;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblBreakTimer);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "BreakForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Break Screen";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Timer timerBreak;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblBreakTimer;
    }
}