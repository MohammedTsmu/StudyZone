namespace StudyZone
{
    partial class MainForm
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
            this.Welcomelbl = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.btnStop = new System.Windows.Forms.Button();
            this.nudStudyMinutes = new System.Windows.Forms.NumericUpDown();
            this.nudBreakMinutes = new System.Windows.Forms.NumericUpDown();
            this.studyMinuteslbl = new System.Windows.Forms.Label();
            this.breakMinuteslbl = new System.Windows.Forms.Label();
            this.timerPomodoro = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudStudyMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreakMinutes)).BeginInit();
            this.SuspendLayout();
            // 
            // Welcomelbl
            // 
            this.Welcomelbl.AutoSize = true;
            this.Welcomelbl.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelbl.Location = new System.Drawing.Point(200, 50);
            this.Welcomelbl.Name = "Welcomelbl";
            this.Welcomelbl.Size = new System.Drawing.Size(343, 33);
            this.Welcomelbl.TabIndex = 0;
            this.Welcomelbl.Text = "Welcome to Study Zone!";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(206, 161);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(122, 46);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "25:00";
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(206, 236);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Location = new System.Drawing.Point(288, 236);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 23);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // nudStudyMinutes
            // 
            this.nudStudyMinutes.Location = new System.Drawing.Point(301, 274);
            this.nudStudyMinutes.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudStudyMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudStudyMinutes.Name = "nudStudyMinutes";
            this.nudStudyMinutes.Size = new System.Drawing.Size(120, 22);
            this.nudStudyMinutes.TabIndex = 4;
            this.nudStudyMinutes.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // nudBreakMinutes
            // 
            this.nudBreakMinutes.Location = new System.Drawing.Point(301, 302);
            this.nudBreakMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudBreakMinutes.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudBreakMinutes.Name = "nudBreakMinutes";
            this.nudBreakMinutes.Size = new System.Drawing.Size(120, 22);
            this.nudBreakMinutes.TabIndex = 5;
            this.nudBreakMinutes.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // studyMinuteslbl
            // 
            this.studyMinuteslbl.AutoSize = true;
            this.studyMinuteslbl.Location = new System.Drawing.Point(203, 280);
            this.studyMinuteslbl.Name = "studyMinuteslbl";
            this.studyMinuteslbl.Size = new System.Drawing.Size(90, 16);
            this.studyMinuteslbl.TabIndex = 6;
            this.studyMinuteslbl.Text = "Study Minutes";
            // 
            // breakMinuteslbl
            // 
            this.breakMinuteslbl.AutoSize = true;
            this.breakMinuteslbl.Location = new System.Drawing.Point(203, 308);
            this.breakMinuteslbl.Name = "breakMinuteslbl";
            this.breakMinuteslbl.Size = new System.Drawing.Size(92, 16);
            this.breakMinuteslbl.TabIndex = 7;
            this.breakMinuteslbl.Text = "Break Minutes";
            // 
            // timerPomodoro
            // 
            this.timerPomodoro.Interval = 1000;
            this.timerPomodoro.Tick += new System.EventHandler(this.timerPomodoro_Tick);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.breakMinuteslbl);
            this.Controls.Add(this.studyMinuteslbl);
            this.Controls.Add(this.nudBreakMinutes);
            this.Controls.Add(this.nudStudyMinutes);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.Welcomelbl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Study Zone";
            ((System.ComponentModel.ISupportInitialize)(this.nudStudyMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreakMinutes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcomelbl;
        private System.Windows.Forms.Label lblTimer;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Button btnStop;
        private System.Windows.Forms.NumericUpDown nudStudyMinutes;
        private System.Windows.Forms.NumericUpDown nudBreakMinutes;
        private System.Windows.Forms.Label studyMinuteslbl;
        private System.Windows.Forms.Label breakMinuteslbl;
        private System.Windows.Forms.Timer timerPomodoro;
    }
}

