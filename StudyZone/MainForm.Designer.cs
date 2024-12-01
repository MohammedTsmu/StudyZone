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
            this.pnRight = new System.Windows.Forms.Panel();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnHeaderBottom = new System.Windows.Forms.Panel();
            this.label4 = new System.Windows.Forms.Label();
            this.pnHeaderTop = new System.Windows.Forms.Panel();
            this.pnMainLeft = new System.Windows.Forms.Panel();
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
            this.pnRight.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.pnHeaderBottom.SuspendLayout();
            this.pnHeaderTop.SuspendLayout();
            this.pnMainLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcomelbl
            // 
            this.Welcomelbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.Welcomelbl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Welcomelbl.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelbl.Location = new System.Drawing.Point(0, 0);
            this.Welcomelbl.Name = "Welcomelbl";
            this.Welcomelbl.Size = new System.Drawing.Size(937, 100);
            this.Welcomelbl.TabIndex = 0;
            this.Welcomelbl.Text = "Welcome to Study Zone!";
            this.Welcomelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimer
            // 
            this.lblTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTimer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lblTimer.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(0, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(937, 123);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "25:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStart.ForeColor = System.Drawing.Color.Black;
            this.btnStart.Image = global::StudyZone.Properties.Resources.Play_PNG_40;
            this.btnStart.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStart.Location = new System.Drawing.Point(127, 24);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(216, 58);
            this.btnStart.TabIndex = 2;
            this.btnStart.Text = "Start";
            this.btnStart.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnsDetails.SetToolTip(this.btnStart, "Start the focus session timer.");
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // btnStop
            // 
            this.btnStop.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnStop.ForeColor = System.Drawing.Color.Black;
            this.btnStop.Image = global::StudyZone.Properties.Resources.Stop_PNG_40;
            this.btnStop.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnStop.Location = new System.Drawing.Point(575, 24);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(216, 58);
            this.btnStop.TabIndex = 3;
            this.btnStop.Text = "Stop";
            this.btnStop.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnsDetails.SetToolTip(this.btnStop, "Terminate / Stop the focus session timer.");
            this.btnStop.UseVisualStyleBackColor = true;
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // nudStudyMinutes
            // 
            this.nudStudyMinutes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStudyMinutes.ForeColor = System.Drawing.Color.Black;
            this.nudStudyMinutes.Location = new System.Drawing.Point(327, 20);
            this.nudStudyMinutes.Maximum = new decimal(new int[] {
            120,
            0,
            0,
            0});
            this.nudStudyMinutes.Name = "nudStudyMinutes";
            this.nudStudyMinutes.Size = new System.Drawing.Size(120, 30);
            this.nudStudyMinutes.TabIndex = 4;
            this.nudStudyMinutes.Value = new decimal(new int[] {
            25,
            0,
            0,
            0});
            // 
            // nudBreakMinutes
            // 
            this.nudBreakMinutes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBreakMinutes.ForeColor = System.Drawing.Color.Black;
            this.nudBreakMinutes.Location = new System.Drawing.Point(327, 20);
            this.nudBreakMinutes.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudBreakMinutes.Name = "nudBreakMinutes";
            this.nudBreakMinutes.Size = new System.Drawing.Size(120, 30);
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
            this.studyMinuteslbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studyMinuteslbl.ForeColor = System.Drawing.Color.Black;
            this.studyMinuteslbl.Location = new System.Drawing.Point(177, 24);
            this.studyMinuteslbl.Name = "studyMinuteslbl";
            this.studyMinuteslbl.Size = new System.Drawing.Size(134, 23);
            this.studyMinuteslbl.TabIndex = 6;
            this.studyMinuteslbl.Text = "Study Minutes";
            // 
            // breakMinuteslbl
            // 
            this.breakMinuteslbl.AutoSize = true;
            this.breakMinuteslbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakMinuteslbl.ForeColor = System.Drawing.Color.Black;
            this.breakMinuteslbl.Location = new System.Drawing.Point(175, 24);
            this.breakMinuteslbl.Name = "breakMinuteslbl";
            this.breakMinuteslbl.Size = new System.Drawing.Size(136, 23);
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
            this.nudStudySeconds.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStudySeconds.ForeColor = System.Drawing.Color.Black;
            this.nudStudySeconds.Location = new System.Drawing.Point(621, 20);
            this.nudStudySeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudStudySeconds.Name = "nudStudySeconds";
            this.nudStudySeconds.Size = new System.Drawing.Size(120, 30);
            this.nudStudySeconds.TabIndex = 8;
            // 
            // nudBreakSeconds
            // 
            this.nudBreakSeconds.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudBreakSeconds.ForeColor = System.Drawing.Color.Black;
            this.nudBreakSeconds.Location = new System.Drawing.Point(623, 20);
            this.nudBreakSeconds.Maximum = new decimal(new int[] {
            59,
            0,
            0,
            0});
            this.nudBreakSeconds.Name = "nudBreakSeconds";
            this.nudBreakSeconds.Size = new System.Drawing.Size(120, 30);
            this.nudBreakSeconds.TabIndex = 9;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(463, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Study Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(463, 24);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(144, 23);
            this.label2.TabIndex = 11;
            this.label2.Text = "Break Seconds";
            // 
            // cmbSessions
            // 
            this.cmbSessions.Cursor = System.Windows.Forms.Cursors.Default;
            this.cmbSessions.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbSessions.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSessions.ForeColor = System.Drawing.Color.Black;
            this.cmbSessions.FormattingEnabled = true;
            this.cmbSessions.Location = new System.Drawing.Point(239, 17);
            this.cmbSessions.Name = "cmbSessions";
            this.cmbSessions.Size = new System.Drawing.Size(440, 31);
            this.cmbSessions.TabIndex = 12;
            this.cmbSessions.Text = "Select Session";
            this.cmbSessions.SelectedIndexChanged += new System.EventHandler(this.cmbSessions_SelectedIndexChanged);
            // 
            // btnSaveSession
            // 
            this.btnSaveSession.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSaveSession.ForeColor = System.Drawing.Color.Black;
            this.btnSaveSession.Image = global::StudyZone.Properties.Resources.Save_Close;
            this.btnSaveSession.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnSaveSession.Location = new System.Drawing.Point(239, 56);
            this.btnSaveSession.Name = "btnSaveSession";
            this.btnSaveSession.Size = new System.Drawing.Size(216, 58);
            this.btnSaveSession.TabIndex = 13;
            this.btnSaveSession.Text = "Save Session";
            this.btnSaveSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnsDetails.SetToolTip(this.btnSaveSession, "Save the current duration settings as a new session or add new durations.");
            this.btnSaveSession.UseVisualStyleBackColor = true;
            this.btnSaveSession.Click += new System.EventHandler(this.btnSaveSession_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.Controls.Add(this.nudStudyMinutes);
            this.groupBox1.Controls.Add(this.studyMinuteslbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudStudySeconds);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox1.Location = new System.Drawing.Point(9, 145);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(919, 70);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Study Duration";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.Controls.Add(this.nudBreakSeconds);
            this.groupBox2.Controls.Add(this.nudBreakMinutes);
            this.groupBox2.Controls.Add(this.breakMinuteslbl);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox2.Location = new System.Drawing.Point(9, 223);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(919, 70);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Break Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(9, 693);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "v1.0.4\r\n© Dr. Mohammed Qasim";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // btnDeleteSession
            // 
            this.btnDeleteSession.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteSession.ForeColor = System.Drawing.Color.Black;
            this.btnDeleteSession.Image = global::StudyZone.Properties.Resources.Delete;
            this.btnDeleteSession.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteSession.Location = new System.Drawing.Point(463, 56);
            this.btnDeleteSession.Name = "btnDeleteSession";
            this.btnDeleteSession.Size = new System.Drawing.Size(216, 58);
            this.btnDeleteSession.TabIndex = 17;
            this.btnDeleteSession.Text = "Delete Session";
            this.btnDeleteSession.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnsDetails.SetToolTip(this.btnDeleteSession, "Delete selected session.");
            this.btnDeleteSession.UseVisualStyleBackColor = true;
            this.btnDeleteSession.Click += new System.EventHandler(this.btnDeleteSession_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.Controls.Add(this.cmbSessions);
            this.groupBox3.Controls.Add(this.btnDeleteSession);
            this.groupBox3.Controls.Add(this.btnSaveSession);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox3.Location = new System.Drawing.Point(9, 6);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(919, 131);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Study Sessions";
            // 
            // btnViewLogs
            // 
            this.btnViewLogs.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnViewLogs.ForeColor = System.Drawing.Color.Black;
            this.btnViewLogs.Image = global::StudyZone.Properties.Resources.LOG;
            this.btnViewLogs.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnViewLogs.Location = new System.Drawing.Point(575, 23);
            this.btnViewLogs.Name = "btnViewLogs";
            this.btnViewLogs.Size = new System.Drawing.Size(216, 58);
            this.btnViewLogs.TabIndex = 19;
            this.btnViewLogs.Text = "View Logs";
            this.btnViewLogs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnsDetails.SetToolTip(this.btnViewLogs, "View statistics for previous sessions and breaks.");
            this.btnViewLogs.UseVisualStyleBackColor = true;
            this.btnViewLogs.Click += new System.EventHandler(this.btnViewLogs_Click);
            // 
            // btnTaskManager
            // 
            this.btnTaskManager.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnTaskManager.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTaskManager.ForeColor = System.Drawing.Color.Black;
            this.btnTaskManager.Image = global::StudyZone.Properties.Resources.Tasks;
            this.btnTaskManager.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTaskManager.Location = new System.Drawing.Point(127, 23);
            this.btnTaskManager.Name = "btnTaskManager";
            this.btnTaskManager.Size = new System.Drawing.Size(216, 58);
            this.btnTaskManager.TabIndex = 20;
            this.btnTaskManager.Text = "Task Manager";
            this.btnTaskManager.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnsDetails.SetToolTip(this.btnTaskManager, "Add / Edit / Delete tasks");
            this.btnTaskManager.UseVisualStyleBackColor = true;
            this.btnTaskManager.Click += new System.EventHandler(this.btnTaskManager_Click);
            // 
            // txtTaskDetails
            // 
            this.txtTaskDetails.Dock = System.Windows.Forms.DockStyle.Fill;
            this.txtTaskDetails.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTaskDetails.Location = new System.Drawing.Point(10, 33);
            this.txtTaskDetails.Multiline = true;
            this.txtTaskDetails.Name = "txtTaskDetails";
            this.txtTaskDetails.ReadOnly = true;
            this.txtTaskDetails.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtTaskDetails.Size = new System.Drawing.Size(579, 386);
            this.txtTaskDetails.TabIndex = 22;
            this.lblsAndTxtBoxsToolTip.SetToolTip(this.txtTaskDetails, "Displays selected task details.");
            // 
            // listViewTasks
            // 
            this.listViewTasks.BackColor = System.Drawing.SystemColors.Control;
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewTasks.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTasks.FullRowSelect = true;
            this.listViewTasks.HideSelection = false;
            this.listViewTasks.Location = new System.Drawing.Point(6, 25);
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(601, 381);
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
            this.notifyIcon.Text = "Study Zone /  v1.0.51";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // btnReminders
            // 
            this.btnReminders.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnReminders.ForeColor = System.Drawing.Color.Black;
            this.btnReminders.Image = global::StudyZone.Properties.Resources.Bell;
            this.btnReminders.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnReminders.Location = new System.Drawing.Point(351, 23);
            this.btnReminders.Name = "btnReminders";
            this.btnReminders.Size = new System.Drawing.Size(216, 58);
            this.btnReminders.TabIndex = 24;
            this.btnReminders.Text = "Reminders";
            this.btnReminders.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnsDetails.SetToolTip(this.btnReminders, "Add a reminder to prompt the user to start a focus or study session if they forge" +
        "t.");
            this.btnReminders.UseVisualStyleBackColor = true;
            this.btnReminders.Click += new System.EventHandler(this.btnReminders_Click);
            // 
            // chkStartWithWindows
            // 
            this.chkStartWithWindows.BackColor = System.Drawing.Color.Transparent;
            this.chkStartWithWindows.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkStartWithWindows.ForeColor = System.Drawing.Color.Black;
            this.chkStartWithWindows.Image = global::StudyZone.Properties.Resources.Launch;
            this.chkStartWithWindows.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.chkStartWithWindows.Location = new System.Drawing.Point(278, 14);
            this.chkStartWithWindows.Name = "chkStartWithWindows";
            this.chkStartWithWindows.Size = new System.Drawing.Size(362, 55);
            this.chkStartWithWindows.TabIndex = 25;
            this.chkStartWithWindows.Text = "Start when Windows starts";
            this.chkBoxsToolTip.SetToolTip(this.chkStartWithWindows, "Ensure the app starts with Windows at login or system startup.");
            this.chkStartWithWindows.UseVisualStyleBackColor = false;
            this.chkStartWithWindows.CheckedChanged += new System.EventHandler(this.chkStartWithWindows_CheckedChanged);
            // 
            // btnMiniTimer
            // 
            this.btnMiniTimer.AutoSize = true;
            this.btnMiniTimer.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMiniTimer.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.btnMiniTimer.Dock = System.Windows.Forms.DockStyle.Right;
            this.btnMiniTimer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMiniTimer.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMiniTimer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.btnMiniTimer.Image = global::StudyZone.Properties.Resources.Up_Squared;
            this.btnMiniTimer.Location = new System.Drawing.Point(887, 0);
            this.btnMiniTimer.Name = "btnMiniTimer";
            this.btnMiniTimer.Size = new System.Drawing.Size(50, 100);
            this.btnMiniTimer.TabIndex = 26;
            this.miniTimerBtnToolTip.SetToolTip(this.btnMiniTimer, "Open Mini Timer");
            this.btnMiniTimer.UseVisualStyleBackColor = false;
            this.btnMiniTimer.Click += new System.EventHandler(this.btnMiniTimer_Click);
            // 
            // btnPause
            // 
            this.btnPause.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPause.ForeColor = System.Drawing.Color.Black;
            this.btnPause.Image = global::StudyZone.Properties.Resources.Pause_PNG_40;
            this.btnPause.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPause.Location = new System.Drawing.Point(351, 24);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(216, 58);
            this.btnPause.TabIndex = 27;
            this.btnPause.Text = "Pause";
            this.btnPause.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.BtnsDetails.SetToolTip(this.btnPause, "Pause the focus session timer.");
            this.btnPause.UseVisualStyleBackColor = true;
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.listViewTasks);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(10, 10);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox4.Size = new System.Drawing.Size(599, 412);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tasks";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.Controls.Add(this.btnPause);
            this.groupBox5.Controls.Add(this.btnStart);
            this.groupBox5.Controls.Add(this.btnStop);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox5.Location = new System.Drawing.Point(9, 301);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(919, 105);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Control";
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox6.Controls.Add(this.btnViewLogs);
            this.groupBox6.Controls.Add(this.btnTaskManager);
            this.groupBox6.Controls.Add(this.btnReminders);
            this.groupBox6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox6.Location = new System.Drawing.Point(9, 414);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(919, 105);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Goals and Tasks";
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox7.Controls.Add(this.chkStartWithWindows);
            this.groupBox7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.groupBox7.Location = new System.Drawing.Point(10, 527);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(918, 82);
            this.groupBox7.TabIndex = 31;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Automation";
            // 
            // miniTimerBtnToolTip
            // 
            this.miniTimerBtnToolTip.ShowAlways = true;
            // 
            // BtnsDetails
            // 
            this.BtnsDetails.AutoPopDelay = 5000;
            this.BtnsDetails.InitialDelay = 1000;
            this.BtnsDetails.ReshowDelay = 100;
            this.BtnsDetails.ShowAlways = true;
            // 
            // chkBoxsToolTip
            // 
            this.chkBoxsToolTip.AutoPopDelay = 5000;
            this.chkBoxsToolTip.InitialDelay = 1000;
            this.chkBoxsToolTip.ReshowDelay = 100;
            this.chkBoxsToolTip.ShowAlways = true;
            // 
            // groupBox8
            // 
            this.groupBox8.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox8.Controls.Add(this.txtTaskDetails);
            this.groupBox8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupBox8.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox8.Location = new System.Drawing.Point(10, 422);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox8.Size = new System.Drawing.Size(599, 429);
            this.groupBox8.TabIndex = 32;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Task Details";
            // 
            // pnRight
            // 
            this.pnRight.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnRight.Controls.Add(this.groupBox8);
            this.pnRight.Controls.Add(this.groupBox4);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(937, 0);
            this.pnRight.Name = "pnRight";
            this.pnRight.Padding = new System.Windows.Forms.Padding(10);
            this.pnRight.Size = new System.Drawing.Size(619, 861);
            this.pnRight.TabIndex = 33;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.Color.DarkGray;
            this.pnLeft.Controls.Add(this.groupBox3);
            this.pnLeft.Controls.Add(this.groupBox1);
            this.pnLeft.Controls.Add(this.groupBox7);
            this.pnLeft.Controls.Add(this.groupBox2);
            this.pnLeft.Controls.Add(this.groupBox6);
            this.pnLeft.Controls.Add(this.groupBox5);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnLeft.Location = new System.Drawing.Point(0, 223);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(937, 638);
            this.pnLeft.TabIndex = 34;
            // 
            // pnTop
            // 
            this.pnTop.BackColor = System.Drawing.SystemColors.ControlDark;
            this.pnTop.Controls.Add(this.pnHeaderBottom);
            this.pnTop.Controls.Add(this.pnHeaderTop);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(937, 223);
            this.pnTop.TabIndex = 35;
            // 
            // pnHeaderBottom
            // 
            this.pnHeaderBottom.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnHeaderBottom.Controls.Add(this.label4);
            this.pnHeaderBottom.Controls.Add(this.lblTimer);
            this.pnHeaderBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHeaderBottom.Location = new System.Drawing.Point(0, 100);
            this.pnHeaderBottom.Name = "pnHeaderBottom";
            this.pnHeaderBottom.Size = new System.Drawing.Size(937, 123);
            this.pnHeaderBottom.TabIndex = 27;
            // 
            // label4
            // 
            this.label4.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label4.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.label4.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Image = global::StudyZone.Properties.Resources.Timer1;
            this.label4.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.label4.Location = new System.Drawing.Point(602, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(242, 68);
            this.label4.TabIndex = 1;
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // pnHeaderTop
            // 
            this.pnHeaderTop.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnHeaderTop.Controls.Add(this.btnMiniTimer);
            this.pnHeaderTop.Controls.Add(this.Welcomelbl);
            this.pnHeaderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeaderTop.Location = new System.Drawing.Point(0, 0);
            this.pnHeaderTop.Name = "pnHeaderTop";
            this.pnHeaderTop.Size = new System.Drawing.Size(937, 100);
            this.pnHeaderTop.TabIndex = 27;
            // 
            // pnMainLeft
            // 
            this.pnMainLeft.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.pnMainLeft.Controls.Add(this.pnTop);
            this.pnMainLeft.Controls.Add(this.pnLeft);
            this.pnMainLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMainLeft.Location = new System.Drawing.Point(0, 0);
            this.pnMainLeft.Name = "pnMainLeft";
            this.pnMainLeft.Size = new System.Drawing.Size(937, 861);
            this.pnMainLeft.TabIndex = 34;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1556, 861);
            this.Controls.Add(this.pnMainLeft);
            this.Controls.Add(this.pnRight);
            this.Controls.Add(this.label3);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Study Zone / v1.0.51";
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
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.pnRight.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pnHeaderBottom.ResumeLayout(false);
            this.pnHeaderTop.ResumeLayout(false);
            this.pnHeaderTop.PerformLayout();
            this.pnMainLeft.ResumeLayout(false);
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
        private System.Windows.Forms.Panel pnRight;
        private System.Windows.Forms.Panel pnLeft;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnMainLeft;
        private System.Windows.Forms.Panel pnHeaderTop;
        private System.Windows.Forms.Panel pnHeaderBottom;
        private System.Windows.Forms.Label label4;
    }
}

