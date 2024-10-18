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
            this.nudStudySeconds = new System.Windows.Forms.NumericUpDown();
            this.nudBreakSeconds = new System.Windows.Forms.NumericUpDown();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.cmbSessions = new System.Windows.Forms.ComboBox();
            this.btnSaveSession = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnDeleteSession = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.nudStudyMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreakMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStudySeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreakSeconds)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            this.lblTimer.Location = new System.Drawing.Point(210, 119);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(122, 46);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "25:00";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(206, 351);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 37);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(288, 351);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 37);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // nudStudyMinutes
            // 
            this.nudStudyMinutes.Location = new System.Drawing.Point(107, 28);
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
            this.nudBreakMinutes.Location = new System.Drawing.Point(107, 21);
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
            this.studyMinuteslbl.Location = new System.Drawing.Point(9, 34);
            this.studyMinuteslbl.Name = "studyMinuteslbl";
            this.studyMinuteslbl.Size = new System.Drawing.Size(90, 16);
            this.studyMinuteslbl.TabIndex = 6;
            this.studyMinuteslbl.Text = "Study Minutes";
            // 
            // breakMinuteslbl
            // 
            this.breakMinuteslbl.AutoSize = true;
            this.breakMinuteslbl.Location = new System.Drawing.Point(9, 27);
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
            // nudStudySeconds
            // 
            this.nudStudySeconds.Location = new System.Drawing.Point(358, 28);
            this.nudStudySeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudStudySeconds.Name = "nudStudySeconds";
            this.nudStudySeconds.Size = new System.Drawing.Size(120, 22);
            this.nudStudySeconds.TabIndex = 8;
            // 
            // nudBreakSeconds
            // 
            this.nudBreakSeconds.Location = new System.Drawing.Point(358, 21);
            this.nudBreakSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudBreakSeconds.Name = "nudBreakSeconds";
            this.nudBreakSeconds.Size = new System.Drawing.Size(120, 22);
            this.nudBreakSeconds.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(249, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 10;
            this.label1.Text = "Study Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(252, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 11;
            this.label2.Text = "Break Seconds";
            // 
            // cmbSessions
            // 
            this.cmbSessions.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbSessions.FormattingEnabled = true;
            this.cmbSessions.Location = new System.Drawing.Point(13, 12);
            this.cmbSessions.Name = "cmbSessions";
            this.cmbSessions.Size = new System.Drawing.Size(218, 27);
            this.cmbSessions.TabIndex = 12;
            this.cmbSessions.Text = "Select Session";
            this.cmbSessions.SelectedIndexChanged += new System.EventHandler(this.cmbSessions_SelectedIndexChanged);
            // 
            // btnSaveSession
            // 
            this.btnSaveSession.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSession.Location = new System.Drawing.Point(13, 44);
            this.btnSaveSession.Name = "btnSaveSession";
            this.btnSaveSession.Size = new System.Drawing.Size(120, 37);
            this.btnSaveSession.TabIndex = 13;
            this.btnSaveSession.Text = "Save Session";
            this.btnSaveSession.UseVisualStyleBackColor = true;
            this.btnSaveSession.Click += new System.EventHandler(this.btnSaveSession_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudStudyMinutes);
            this.groupBox1.Controls.Add(this.studyMinuteslbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudStudySeconds);
            this.groupBox1.Location = new System.Drawing.Point(206, 179);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(484, 69);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Study Duration";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.nudBreakSeconds);
            this.groupBox2.Controls.Add(this.nudBreakMinutes);
            this.groupBox2.Controls.Add(this.breakMinuteslbl);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Location = new System.Drawing.Point(206, 254);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(484, 69);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Break Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(10, 512);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "v1.0.0 / AGPL-3.0 license\r\nAll rights reserved © Dr. Mohammed Qasim.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeleteSession
            // 
            this.btnDeleteSession.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSession.Location = new System.Drawing.Point(13, 87);
            this.btnDeleteSession.Name = "btnDeleteSession";
            this.btnDeleteSession.Size = new System.Drawing.Size(120, 37);
            this.btnDeleteSession.TabIndex = 17;
            this.btnDeleteSession.Text = "Delete Session";
            this.btnDeleteSession.UseVisualStyleBackColor = true;
            this.btnDeleteSession.Click += new System.EventHandler(this.btnDeleteSession_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(782, 553);
            this.Controls.Add(this.btnDeleteSession);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnSaveSession);
            this.Controls.Add(this.cmbSessions);
            this.Controls.Add(this.btnStop);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.Welcomelbl);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Study Zone";
            ((System.ComponentModel.ISupportInitialize)(this.nudStudyMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreakMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStudySeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreakSeconds)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.NumericUpDown nudStudySeconds;
        private System.Windows.Forms.NumericUpDown nudBreakSeconds;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox cmbSessions;
        private System.Windows.Forms.Button btnSaveSession;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnDeleteSession;
    }
}

