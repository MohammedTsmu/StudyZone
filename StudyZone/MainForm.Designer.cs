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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
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
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnViewLogs = new System.Windows.Forms.Button();
            this.btnTaskManager = new System.Windows.Forms.Button();
            this.txtTaskDetails = new System.Windows.Forms.TextBox();
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.btnReminders = new System.Windows.Forms.Button();
            this.chkStartWithWindows = new System.Windows.Forms.CheckBox();
            this.btnMiniTimer = new System.Windows.Forms.Button();
            this.btnPause = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.miniTimerBtnToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BtnsDetails = new System.Windows.Forms.ToolTip(this.components);
            this.chkBoxsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblsAndTxtBoxsToolTip = new System.Windows.Forms.ToolTip(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.nudStudyMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreakMinutes)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStudySeconds)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreakSeconds)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox7.SuspendLayout();
            this.groupBox8.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcomelbl
            // 
            this.Welcomelbl.AutoSize = true;
            this.Welcomelbl.Font = new System.Drawing.Font("Arial", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelbl.Location = new System.Drawing.Point(206, 30);
            this.Welcomelbl.Name = "Welcomelbl";
            this.Welcomelbl.Size = new System.Drawing.Size(343, 33);
            this.Welcomelbl.TabIndex = 0;
            this.Welcomelbl.Text = "Welcome to Study Zone!";
            // 
            // lblTimer
            // 
            this.lblTimer.AutoSize = true;
            this.lblTimer.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(204, 85);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(122, 46);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "25:00";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.Location = new System.Drawing.Point(6, 21);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 37);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.BtnsDetails.SetToolTip(this.btnStart, "Start the focus session timer.");
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.Location = new System.Drawing.Point(168, 21);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(75, 37);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.BtnsDetails.SetToolTip(this.btnStop, "Terminate / Stop the focus session timer.");
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
            this.cmbSessions.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSessions.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.cmbSessions.FormattingEnabled = true;
            this.cmbSessions.Location = new System.Drawing.Point(6, 21);
            this.cmbSessions.Name = "cmbSessions";
            this.cmbSessions.Size = new System.Drawing.Size(426, 27);
            this.cmbSessions.TabIndex = 12;
            this.cmbSessions.Text = "Select Session";
            this.cmbSessions.SelectedIndexChanged += new System.EventHandler(this.cmbSessions_SelectedIndexChanged);
            // 
            // btnSaveSession
            // 
            this.btnSaveSession.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSession.Location = new System.Drawing.Point(438, 16);
            this.btnSaveSession.Name = "btnSaveSession";
            this.btnSaveSession.Size = new System.Drawing.Size(120, 37);
            this.btnSaveSession.TabIndex = 13;
            this.btnSaveSession.Text = "Save Session";
            this.BtnsDetails.SetToolTip(this.btnSaveSession, "Save the current duration settings as a new session or add new durations.");
            this.btnSaveSession.UseVisualStyleBackColor = true;
            this.btnSaveSession.Click += new System.EventHandler(this.btnSaveSession_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.nudStudyMinutes);
            this.groupBox1.Controls.Add(this.studyMinuteslbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudStudySeconds);
            this.groupBox1.Location = new System.Drawing.Point(12, 224);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 70);
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
            this.groupBox2.Location = new System.Drawing.Point(12, 300);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(690, 70);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Break Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 693);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(265, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "v1.0.0\r\nAll rights reserved © Dr. Mohammed Qasim.";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeleteSession
            // 
            this.btnDeleteSession.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSession.Location = new System.Drawing.Point(564, 16);
            this.btnDeleteSession.Name = "btnDeleteSession";
            this.btnDeleteSession.Size = new System.Drawing.Size(120, 37);
            this.btnDeleteSession.TabIndex = 17;
            this.btnDeleteSession.Text = "Delete Session";
            this.BtnsDetails.SetToolTip(this.btnDeleteSession, "Delete selected session.");
            this.btnDeleteSession.UseVisualStyleBackColor = true;
            this.btnDeleteSession.Click += new System.EventHandler(this.btnDeleteSession_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cmbSessions);
            this.groupBox3.Controls.Add(this.btnDeleteSession);
            this.groupBox3.Controls.Add(this.btnSaveSession);
            this.groupBox3.Location = new System.Drawing.Point(12, 148);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(690, 70);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Study Sessions";
            // 
            // btnViewLogs
            // 
            this.btnViewLogs.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLogs.Location = new System.Drawing.Point(330, 21);
            this.btnViewLogs.Name = "btnViewLogs";
            this.btnViewLogs.Size = new System.Drawing.Size(156, 37);
            this.btnViewLogs.TabIndex = 19;
            this.btnViewLogs.Text = "View Logs";
            this.BtnsDetails.SetToolTip(this.btnViewLogs, "View statistics for previous sessions and breaks.");
            this.btnViewLogs.UseVisualStyleBackColor = true;
            this.btnViewLogs.Click += new System.EventHandler(this.btnViewLogs_Click);
            // 
            // btnTaskManager
            // 
            this.btnTaskManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTaskManager.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskManager.ImageAlign = System.Drawing.ContentAlignment.TopRight;
            this.btnTaskManager.Location = new System.Drawing.Point(6, 21);
            this.btnTaskManager.Name = "btnTaskManager";
            this.btnTaskManager.Size = new System.Drawing.Size(156, 37);
            this.btnTaskManager.TabIndex = 20;
            this.btnTaskManager.Text = "Task Manager";
            this.BtnsDetails.SetToolTip(this.btnTaskManager, "Add / Edit / Delete tasks");
            this.btnTaskManager.UseVisualStyleBackColor = true;
            this.btnTaskManager.Click += new System.EventHandler(this.btnTaskManager_Click);
            // 
            // txtTaskDetails
            // 
            this.txtTaskDetails.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskDetails.Location = new System.Drawing.Point(6, 21);
            this.txtTaskDetails.Multiline = true;
            this.txtTaskDetails.Name = "txtTaskDetails";
            this.txtTaskDetails.ReadOnly = true;
            this.txtTaskDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTaskDetails.Size = new System.Drawing.Size(574, 211);
            this.txtTaskDetails.TabIndex = 22;
            this.lblsAndTxtBoxsToolTip.SetToolTip(this.txtTaskDetails, "Displays selected task details.");
            // 
            // listViewTasks
            // 
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewTasks.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTasks.FullRowSelect = true;
            this.listViewTasks.HideSelection = false;
            this.listViewTasks.Location = new System.Drawing.Point(6, 21);
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(574, 421);
            this.listViewTasks.TabIndex = 23;
            this.lblsAndTxtBoxsToolTip.SetToolTip(this.listViewTasks, "Displays selected session registered tasks.");
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            this.listViewTasks.SelectedIndexChanged += new System.EventHandler(this.listViewTasks_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 200;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Due Date";
            this.columnHeader2.Width = 100;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 80;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "StudyZone";
            this.notifyIcon.BalloonTipTitle = "StudyZone";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // btnReminders
            // 
            this.btnReminders.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReminders.Location = new System.Drawing.Point(168, 21);
            this.btnReminders.Name = "btnReminders";
            this.btnReminders.Size = new System.Drawing.Size(156, 37);
            this.btnReminders.TabIndex = 24;
            this.btnReminders.Text = "Reminders";
            this.BtnsDetails.SetToolTip(this.btnReminders, "Add a reminder to prompt the user to start a focus or study session if they forge" +
        "t.");
            this.btnReminders.UseVisualStyleBackColor = true;
            this.btnReminders.Click += new System.EventHandler(this.btnReminders_Click);
            // 
            // chkStartWithWindows
            // 
            this.chkStartWithWindows.AutoSize = true;
            this.chkStartWithWindows.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStartWithWindows.Location = new System.Drawing.Point(6, 16);
            this.chkStartWithWindows.Name = "chkStartWithWindows";
            this.chkStartWithWindows.Size = new System.Drawing.Size(207, 22);
            this.chkStartWithWindows.TabIndex = 25;
            this.chkStartWithWindows.Text = "Start when Windows starts";
            this.chkBoxsToolTip.SetToolTip(this.chkStartWithWindows, "Ensure the app starts with Windows at login or system startup.");
            this.chkStartWithWindows.UseVisualStyleBackColor = true;
            this.chkStartWithWindows.CheckedChanged += new System.EventHandler(this.chkStartWithWindows_CheckedChanged);
            // 
            // btnMiniTimer
            // 
            this.btnMiniTimer.BackgroundImage = global::StudyZone.Properties.Resources.arrow;
            this.btnMiniTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnMiniTimer.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnMiniTimer.Location = new System.Drawing.Point(646, 89);
            this.btnMiniTimer.Name = "btnMiniTimer";
            this.btnMiniTimer.Size = new System.Drawing.Size(56, 56);
            this.btnMiniTimer.TabIndex = 26;
            this.miniTimerBtnToolTip.SetToolTip(this.btnMiniTimer, "Open Mini Timer");
            this.btnMiniTimer.UseVisualStyleBackColor = true;
            this.btnMiniTimer.Click += new System.EventHandler(this.btnMiniTimer_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.Location = new System.Drawing.Point(87, 21);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(75, 37);
            this.btnPause.TabIndex = 27;
            this.btnPause.Text = "Pause";
            this.BtnsDetails.SetToolTip(this.btnPause, "Pause the focus session timer.");
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.listViewTasks);
            this.groupBox4.Location = new System.Drawing.Point(729, 30);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(586, 448);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tasks";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnPause);
            this.groupBox5.Controls.Add(this.btnStart);
            this.groupBox5.Controls.Add(this.btnStop);
            this.groupBox5.Location = new System.Drawing.Point(12, 420);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(690, 71);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Control";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnViewLogs);
            this.groupBox6.Controls.Add(this.btnTaskManager);
            this.groupBox6.Controls.Add(this.btnReminders);
            this.groupBox6.Location = new System.Drawing.Point(12, 498);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(690, 75);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Goals and Tasks";
            // 
            // groupBox7
            // 
            this.groupBox7.Controls.Add(this.chkStartWithWindows);
            this.groupBox7.Location = new System.Drawing.Point(13, 580);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(689, 44);
            this.groupBox7.TabIndex = 31;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Automation";
            // 
            // miniTimerBtnToolTip
            // 
            this.miniTimerBtnToolTip.ShowAlways = true;
            this.miniTimerBtnToolTip.ToolTipTitle = "Click to:";
            // 
            // BtnsDetails
            // 
            this.BtnsDetails.AutoPopDelay = 5000;
            this.BtnsDetails.InitialDelay = 1000;
            this.BtnsDetails.ReshowDelay = 100;
            this.BtnsDetails.ShowAlways = true;
            this.BtnsDetails.ToolTipTitle = "Click to:";
            // 
            // chkBoxsToolTip
            // 
            this.chkBoxsToolTip.AutoPopDelay = 5000;
            this.chkBoxsToolTip.InitialDelay = 1000;
            this.chkBoxsToolTip.ReshowDelay = 100;
            this.chkBoxsToolTip.ShowAlways = true;
            this.chkBoxsToolTip.ToolTipTitle = "Check to:";
            // 
            // groupBox8
            // 
            this.groupBox8.Controls.Add(this.txtTaskDetails);
            this.groupBox8.Location = new System.Drawing.Point(729, 484);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Size = new System.Drawing.Size(586, 238);
            this.groupBox8.TabIndex = 32;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Task Details";
            // 
            // lblsAndTxtBoxsToolTip
            // 
            this.lblsAndTxtBoxsToolTip.ToolTipTitle = "What is this:";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1327, 734);
            this.Controls.Add(this.groupBox8);
            this.Controls.Add(this.groupBox7);
            this.Controls.Add(this.groupBox6);
            this.Controls.Add(this.groupBox5);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.btnMiniTimer);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblTimer);
            this.Controls.Add(this.Welcomelbl);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Study Zone";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
            this.Resize += new System.EventHandler(this.MainForm_Resize);
            ((System.ComponentModel.ISupportInitialize)(this.nudStudyMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreakMinutes)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudStudySeconds)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudBreakSeconds)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox7.ResumeLayout(false);
            this.groupBox7.PerformLayout();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
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
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnViewLogs;
        private System.Windows.Forms.Button btnTaskManager;
        private System.Windows.Forms.TextBox txtTaskDetails;
        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.NotifyIcon notifyIcon;
        private System.Windows.Forms.Button btnReminders;
        private System.Windows.Forms.CheckBox chkStartWithWindows;
        private System.Windows.Forms.Button btnMiniTimer;
        private System.Windows.Forms.Button btnPause;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.GroupBox groupBox7;
        private System.Windows.Forms.ToolTip miniTimerBtnToolTip;
        private System.Windows.Forms.ToolTip BtnsDetails;
        private System.Windows.Forms.ToolTip chkBoxsToolTip;
        private System.Windows.Forms.GroupBox groupBox8;
        private System.Windows.Forms.ToolTip lblsAndTxtBoxsToolTip;
    }
}

