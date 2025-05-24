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
            DevExpress.Utils.SuperToolTip superToolTip1 = new DevExpress.Utils.SuperToolTip();
            DevExpress.Utils.ToolTipItem toolTipItem1 = new DevExpress.Utils.ToolTipItem();
            this.Welcomelbl = new System.Windows.Forms.Label();
            this.lblTimer = new System.Windows.Forms.Label();
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnSaveSession = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteSession = new DevExpress.XtraEditors.SimpleButton();
            this.txtTaskDetails = new System.Windows.Forms.TextBox();
            this.listViewTasks = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.notifyIcon = new System.Windows.Forms.NotifyIcon(this.components);
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnStop = new DevExpress.XtraEditors.SimpleButton();
            this.btnPause = new DevExpress.XtraEditors.SimpleButton();
            this.btnStart = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnTaskManager = new DevExpress.XtraEditors.SimpleButton();
            this.btnReminders = new DevExpress.XtraEditors.SimpleButton();
            this.btnViewLogs = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox7 = new System.Windows.Forms.GroupBox();
            this.chkStartWithWindows = new DevExpress.XtraEditors.CheckEdit();
            this.svgImageBoxAbout = new DevExpress.XtraEditors.SvgImageBox();
            this.miniTimerBtnToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.BtnsDetails = new System.Windows.Forms.ToolTip(this.components);
            this.chkBoxsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.groupBox8 = new System.Windows.Forms.GroupBox();
            this.lblsAndTxtBoxsToolTip = new System.Windows.Forms.ToolTip(this.components);
            this.pnRight = new System.Windows.Forms.Panel();
            this.pnLeft = new System.Windows.Forms.Panel();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnHeaderBottom = new System.Windows.Forms.Panel();
            this.btnMiniTimer = new DevExpress.XtraEditors.SvgImageBox();
            this.svgImageBox1 = new DevExpress.XtraEditors.SvgImageBox();
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
            ((System.ComponentModel.ISupportInitialize)(this.chkStartWithWindows.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBoxAbout)).BeginInit();
            this.groupBox8.SuspendLayout();
            this.pnRight.SuspendLayout();
            this.pnLeft.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.pnHeaderBottom.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btnMiniTimer)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).BeginInit();
            this.pnHeaderTop.SuspendLayout();
            this.pnMainLeft.SuspendLayout();
            this.SuspendLayout();
            // 
            // Welcomelbl
            // 
            this.Welcomelbl.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Welcomelbl.Font = new System.Drawing.Font("Arial", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Welcomelbl.Location = new System.Drawing.Point(7, 10);
            this.Welcomelbl.Name = "Welcomelbl";
            this.Welcomelbl.Size = new System.Drawing.Size(878, 90);
            this.Welcomelbl.TabIndex = 0;
            this.Welcomelbl.Text = "Welcome to Study Zone!";
            this.Welcomelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblTimer
            // 
            this.lblTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTimer.BackColor = System.Drawing.Color.Turquoise;
            this.lblTimer.Font = new System.Drawing.Font("Arial", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTimer.Location = new System.Drawing.Point(7, 0);
            this.lblTimer.Name = "lblTimer";
            this.lblTimer.Size = new System.Drawing.Size(878, 80);
            this.lblTimer.TabIndex = 1;
            this.lblTimer.Text = "00:00";
            this.lblTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // nudStudyMinutes
            // 
            this.nudStudyMinutes.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nudStudyMinutes.ForeColor = System.Drawing.Color.Navy;
            this.nudStudyMinutes.Location = new System.Drawing.Point(307, 20);
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
            this.nudBreakMinutes.ForeColor = System.Drawing.Color.Navy;
            this.nudBreakMinutes.Location = new System.Drawing.Point(307, 20);
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
            this.studyMinuteslbl.ForeColor = System.Drawing.Color.Navy;
            this.studyMinuteslbl.Location = new System.Drawing.Point(157, 24);
            this.studyMinuteslbl.Name = "studyMinuteslbl";
            this.studyMinuteslbl.Size = new System.Drawing.Size(134, 23);
            this.studyMinuteslbl.TabIndex = 6;
            this.studyMinuteslbl.Text = "Study Minutes";
            // 
            // breakMinuteslbl
            // 
            this.breakMinuteslbl.AutoSize = true;
            this.breakMinuteslbl.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.breakMinuteslbl.ForeColor = System.Drawing.Color.Navy;
            this.breakMinuteslbl.Location = new System.Drawing.Point(155, 24);
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
            this.nudStudySeconds.ForeColor = System.Drawing.Color.Navy;
            this.nudStudySeconds.Location = new System.Drawing.Point(601, 20);
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
            this.nudBreakSeconds.ForeColor = System.Drawing.Color.Navy;
            this.nudBreakSeconds.Location = new System.Drawing.Point(603, 20);
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
            this.label1.ForeColor = System.Drawing.Color.Navy;
            this.label1.Location = new System.Drawing.Point(443, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(142, 23);
            this.label1.TabIndex = 10;
            this.label1.Text = "Study Seconds";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Navy;
            this.label2.Location = new System.Drawing.Point(443, 24);
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
            this.cmbSessions.Location = new System.Drawing.Point(219, 21);
            this.cmbSessions.Name = "cmbSessions";
            this.cmbSessions.Size = new System.Drawing.Size(440, 31);
            this.cmbSessions.TabIndex = 12;
            this.cmbSessions.SelectedIndexChanged += new System.EventHandler(this.cmbSessions_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.nudStudyMinutes);
            this.groupBox1.Controls.Add(this.studyMinuteslbl);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.nudStudySeconds);
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(7, 157);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(878, 70);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Study Duration";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.nudBreakSeconds);
            this.groupBox2.Controls.Add(this.nudBreakMinutes);
            this.groupBox2.Controls.Add(this.breakMinuteslbl);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(7, 235);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(878, 70);
            this.groupBox2.TabIndex = 15;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Break Duration";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(29, 713);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 32);
            this.label3.TabIndex = 16;
            this.label3.Text = "v1.0.4\r\n© Dr. Mohammed Qasim";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.btnSaveSession);
            this.groupBox3.Controls.Add(this.btnDeleteSession);
            this.groupBox3.Controls.Add(this.cmbSessions);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox3.Location = new System.Drawing.Point(7, 18);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(878, 131);
            this.groupBox3.TabIndex = 18;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Study Sessions";
            // 
            // btnSaveSession
            // 
            this.btnSaveSession.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnSaveSession.Appearance.Options.UseFont = true;
            this.btnSaveSession.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnSaveSession.ImageOptions.SvgImage")));
            this.btnSaveSession.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnSaveSession.Location = new System.Drawing.Point(219, 60);
            this.btnSaveSession.Name = "btnSaveSession";
            this.btnSaveSession.Size = new System.Drawing.Size(195, 38);
            this.btnSaveSession.TabIndex = 19;
            this.btnSaveSession.Text = "Save Session";
            this.BtnsDetails.SetToolTip(this.btnSaveSession, "Save the current duration settings as a new session or add new durations.");
            this.btnSaveSession.Click += new System.EventHandler(this.btnSaveSession_Click);
            // 
            // btnDeleteSession
            // 
            this.btnDeleteSession.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnDeleteSession.Appearance.Options.UseFont = true;
            this.btnDeleteSession.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteSession.ImageOptions.SvgImage")));
            this.btnDeleteSession.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnDeleteSession.Location = new System.Drawing.Point(459, 60);
            this.btnDeleteSession.Name = "btnDeleteSession";
            this.btnDeleteSession.Size = new System.Drawing.Size(195, 38);
            this.btnDeleteSession.TabIndex = 18;
            this.btnDeleteSession.Text = "Delete Session";
            this.BtnsDetails.SetToolTip(this.btnDeleteSession, "Delete selected session.");
            this.btnDeleteSession.Click += new System.EventHandler(this.btnDeleteSession_Click);
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
            this.txtTaskDetails.Size = new System.Drawing.Size(563, 332);
            this.txtTaskDetails.TabIndex = 22;
            this.lblsAndTxtBoxsToolTip.SetToolTip(this.txtTaskDetails, "Displays selected task details.");
            // 
            // listViewTasks
            // 
            this.listViewTasks.AllowColumnReorder = true;
            this.listViewTasks.BackColor = System.Drawing.SystemColors.Control;
            this.listViewTasks.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
            this.listViewTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listViewTasks.Font = new System.Drawing.Font("Arial", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listViewTasks.FullRowSelect = true;
            this.listViewTasks.HideSelection = false;
            this.listViewTasks.Location = new System.Drawing.Point(10, 33);
            this.listViewTasks.Name = "listViewTasks";
            this.listViewTasks.Size = new System.Drawing.Size(563, 363);
            this.listViewTasks.TabIndex = 23;
            this.lblsAndTxtBoxsToolTip.SetToolTip(this.listViewTasks, "Displays selected session registered tasks.");
            this.listViewTasks.UseCompatibleStateImageBehavior = false;
            this.listViewTasks.View = System.Windows.Forms.View.Details;
            this.listViewTasks.SelectedIndexChanged += new System.EventHandler(this.listViewTasks_SelectedIndexChanged);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Title";
            this.columnHeader1.Width = 172;
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Due Date";
            this.columnHeader2.Width = 134;
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Status";
            this.columnHeader3.Width = 125;
            // 
            // notifyIcon
            // 
            this.notifyIcon.BalloonTipText = "StudyZone";
            this.notifyIcon.BalloonTipTitle = "StudyZone";
            this.notifyIcon.Icon = ((System.Drawing.Icon)(resources.GetObject("notifyIcon.Icon")));
            this.notifyIcon.Text = "Study Zone";
            this.notifyIcon.Visible = true;
            this.notifyIcon.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.notifyIcon_MouseDoubleClick);
            // 
            // groupBox4
            // 
            this.groupBox4.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox4.Controls.Add(this.listViewTasks);
            this.groupBox4.Dock = System.Windows.Forms.DockStyle.Top;
            this.groupBox4.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(20, 20);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox4.Size = new System.Drawing.Size(583, 406);
            this.groupBox4.TabIndex = 28;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Tasks";
            // 
            // groupBox5
            // 
            this.groupBox5.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox5.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox5.Controls.Add(this.btnStop);
            this.groupBox5.Controls.Add(this.btnPause);
            this.groupBox5.Controls.Add(this.btnStart);
            this.groupBox5.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox5.Location = new System.Drawing.Point(7, 313);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(878, 105);
            this.groupBox5.TabIndex = 29;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Control";
            // 
            // btnStop
            // 
            this.btnStop.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnStop.Appearance.ForeColor = System.Drawing.Color.Red;
            this.btnStop.Appearance.Options.UseFont = true;
            this.btnStop.Appearance.Options.UseForeColor = true;
            this.btnStop.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStop.ImageOptions.SvgImage")));
            this.btnStop.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnStop.Location = new System.Drawing.Point(545, 27);
            this.btnStop.Name = "btnStop";
            this.btnStop.Size = new System.Drawing.Size(195, 38);
            this.btnStop.TabIndex = 30;
            this.btnStop.Text = "Stop";
            this.BtnsDetails.SetToolTip(this.btnStop, "Terminate / Stop the focus session timer.");
            this.btnStop.Click += new System.EventHandler(this.btnStop_Click);
            // 
            // btnPause
            // 
            this.btnPause.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnPause.Appearance.ForeColor = System.Drawing.Color.Blue;
            this.btnPause.Appearance.Options.UseFont = true;
            this.btnPause.Appearance.Options.UseForeColor = true;
            this.btnPause.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnPause.ImageOptions.SvgImage")));
            this.btnPause.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnPause.Location = new System.Drawing.Point(337, 27);
            this.btnPause.Name = "btnPause";
            this.btnPause.Size = new System.Drawing.Size(195, 38);
            this.btnPause.TabIndex = 29;
            this.btnPause.Text = "Pause";
            this.BtnsDetails.SetToolTip(this.btnPause, "Pause the focus session timer.");
            this.btnPause.Click += new System.EventHandler(this.btnPause_Click);
            // 
            // btnStart
            // 
            this.btnStart.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnStart.Appearance.Options.UseFont = true;
            this.btnStart.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnStart.ImageOptions.SvgImage")));
            this.btnStart.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnStart.Location = new System.Drawing.Point(133, 27);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(191, 38);
            this.btnStart.TabIndex = 28;
            this.btnStart.Text = "Start";
            this.BtnsDetails.SetToolTip(this.btnStart, "Start the focus session timer.");
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // groupBox6
            // 
            this.groupBox6.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox6.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox6.Controls.Add(this.btnTaskManager);
            this.groupBox6.Controls.Add(this.btnReminders);
            this.groupBox6.Controls.Add(this.btnViewLogs);
            this.groupBox6.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox6.Location = new System.Drawing.Point(7, 426);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(878, 105);
            this.groupBox6.TabIndex = 30;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Goals and Tasks";
            // 
            // btnTaskManager
            // 
            this.btnTaskManager.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnTaskManager.Appearance.Options.UseFont = true;
            this.btnTaskManager.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnTaskManager.ImageOptions.SvgImage")));
            this.btnTaskManager.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnTaskManager.Location = new System.Drawing.Point(131, 27);
            this.btnTaskManager.Name = "btnTaskManager";
            this.btnTaskManager.Size = new System.Drawing.Size(195, 38);
            this.btnTaskManager.TabIndex = 27;
            this.btnTaskManager.Text = "Task Manager";
            this.BtnsDetails.SetToolTip(this.btnTaskManager, "Add / Edit / Delete tasks");
            this.btnTaskManager.Click += new System.EventHandler(this.btnTaskManager_Click);
            // 
            // btnReminders
            // 
            this.btnReminders.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnReminders.Appearance.Options.UseFont = true;
            this.btnReminders.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnReminders.ImageOptions.SvgImage")));
            this.btnReminders.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnReminders.Location = new System.Drawing.Point(339, 27);
            this.btnReminders.Name = "btnReminders";
            this.btnReminders.Size = new System.Drawing.Size(195, 38);
            this.btnReminders.TabIndex = 26;
            this.btnReminders.Text = "Reminders";
            this.BtnsDetails.SetToolTip(this.btnReminders, "Add a reminder to prompt the user to start a focus or study session if they forge" +
        "t.");
            this.btnReminders.Click += new System.EventHandler(this.btnReminders_Click);
            // 
            // btnViewLogs
            // 
            this.btnViewLogs.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnViewLogs.Appearance.Options.UseFont = true;
            this.btnViewLogs.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnViewLogs.ImageOptions.SvgImage")));
            this.btnViewLogs.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnViewLogs.Location = new System.Drawing.Point(547, 27);
            this.btnViewLogs.Name = "btnViewLogs";
            this.btnViewLogs.Size = new System.Drawing.Size(195, 38);
            this.btnViewLogs.TabIndex = 25;
            this.btnViewLogs.Text = "View Logs";
            this.BtnsDetails.SetToolTip(this.btnViewLogs, "View statistics for previous sessions and breaks.");
            this.btnViewLogs.Click += new System.EventHandler(this.btnViewLogs_Click);
            // 
            // groupBox7
            // 
            this.groupBox7.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox7.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox7.Controls.Add(this.chkStartWithWindows);
            this.groupBox7.Controls.Add(this.svgImageBoxAbout);
            this.groupBox7.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox7.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox7.Location = new System.Drawing.Point(8, 539);
            this.groupBox7.Name = "groupBox7";
            this.groupBox7.Size = new System.Drawing.Size(877, 82);
            this.groupBox7.TabIndex = 31;
            this.groupBox7.TabStop = false;
            this.groupBox7.Text = "Automation";
            // 
            // chkStartWithWindows
            // 
            this.chkStartWithWindows.Location = new System.Drawing.Point(91, 29);
            this.chkStartWithWindows.Name = "chkStartWithWindows";
            this.chkStartWithWindows.Properties.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.chkStartWithWindows.Properties.Appearance.Options.UseFont = true;
            this.chkStartWithWindows.Properties.Caption = "Start when Windows starts";
            this.chkStartWithWindows.Size = new System.Drawing.Size(419, 25);
            this.chkStartWithWindows.TabIndex = 27;
            this.chkBoxsToolTip.SetToolTip(this.chkStartWithWindows, "Ensure the app starts with Windows at login or system startup.");
            this.chkStartWithWindows.CheckedChanged += new System.EventHandler(this.chkStartWithWindows_CheckedChanged);
            // 
            // svgImageBoxAbout
            // 
            this.svgImageBoxAbout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.svgImageBoxAbout.Location = new System.Drawing.Point(726, 16);
            this.svgImageBoxAbout.Name = "svgImageBoxAbout";
            this.svgImageBoxAbout.Size = new System.Drawing.Size(59, 50);
            this.svgImageBoxAbout.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBoxAbout.SvgImage")));
            this.svgImageBoxAbout.TabIndex = 26;
            this.svgImageBoxAbout.ToolTip = "About Study Zone Information";
            this.svgImageBoxAbout.Click += new System.EventHandler(this.btnAbout_Click);
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
            this.groupBox8.Location = new System.Drawing.Point(20, 426);
            this.groupBox8.Name = "groupBox8";
            this.groupBox8.Padding = new System.Windows.Forms.Padding(10);
            this.groupBox8.Size = new System.Drawing.Size(583, 375);
            this.groupBox8.TabIndex = 32;
            this.groupBox8.TabStop = false;
            this.groupBox8.Text = "Task Details";
            // 
            // pnRight
            // 
            this.pnRight.Controls.Add(this.groupBox8);
            this.pnRight.Controls.Add(this.groupBox4);
            this.pnRight.Dock = System.Windows.Forms.DockStyle.Right;
            this.pnRight.Location = new System.Drawing.Point(913, 20);
            this.pnRight.Name = "pnRight";
            this.pnRight.Padding = new System.Windows.Forms.Padding(20);
            this.pnRight.Size = new System.Drawing.Size(623, 821);
            this.pnRight.TabIndex = 33;
            // 
            // pnLeft
            // 
            this.pnLeft.BackColor = System.Drawing.SystemColors.Control;
            this.pnLeft.Controls.Add(this.groupBox3);
            this.pnLeft.Controls.Add(this.groupBox1);
            this.pnLeft.Controls.Add(this.groupBox7);
            this.pnLeft.Controls.Add(this.groupBox2);
            this.pnLeft.Controls.Add(this.groupBox6);
            this.pnLeft.Controls.Add(this.groupBox5);
            this.pnLeft.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnLeft.Location = new System.Drawing.Point(0, 183);
            this.pnLeft.Name = "pnLeft";
            this.pnLeft.Size = new System.Drawing.Size(893, 638);
            this.pnLeft.TabIndex = 34;
            // 
            // pnTop
            // 
            this.pnTop.Controls.Add(this.pnHeaderBottom);
            this.pnTop.Controls.Add(this.pnHeaderTop);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(893, 183);
            this.pnTop.TabIndex = 35;
            // 
            // pnHeaderBottom
            // 
            this.pnHeaderBottom.Controls.Add(this.btnMiniTimer);
            this.pnHeaderBottom.Controls.Add(this.svgImageBox1);
            this.pnHeaderBottom.Controls.Add(this.lblTimer);
            this.pnHeaderBottom.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnHeaderBottom.Location = new System.Drawing.Point(0, 100);
            this.pnHeaderBottom.Name = "pnHeaderBottom";
            this.pnHeaderBottom.Size = new System.Drawing.Size(893, 83);
            this.pnHeaderBottom.TabIndex = 27;
            // 
            // btnMiniTimer
            // 
            this.btnMiniTimer.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMiniTimer.BackColor = System.Drawing.Color.Turquoise;
            this.btnMiniTimer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMiniTimer.Location = new System.Drawing.Point(820, 3);
            this.btnMiniTimer.Name = "btnMiniTimer";
            this.btnMiniTimer.Size = new System.Drawing.Size(65, 77);
            toolTipItem1.AllowHtmlText = DevExpress.Utils.DefaultBoolean.True;
            toolTipItem1.Text = "<b><i>Mini Mode</i></b>";
            superToolTip1.Items.Add(toolTipItem1);
            this.btnMiniTimer.SuperTip = superToolTip1;
            this.btnMiniTimer.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMiniTimer.SvgImage")));
            this.btnMiniTimer.TabIndex = 3;
            this.btnMiniTimer.Text = "svgImageBox2";
            this.btnMiniTimer.Click += new System.EventHandler(this.btnMiniTimer_Click);
            // 
            // svgImageBox1
            // 
            this.svgImageBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.svgImageBox1.BackColor = System.Drawing.Color.Turquoise;
            this.svgImageBox1.Location = new System.Drawing.Point(601, 3);
            this.svgImageBox1.Name = "svgImageBox1";
            this.svgImageBox1.Size = new System.Drawing.Size(65, 77);
            this.svgImageBox1.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("svgImageBox1.SvgImage")));
            this.svgImageBox1.TabIndex = 2;
            this.svgImageBox1.Text = "svgImageBox1";
            // 
            // pnHeaderTop
            // 
            this.pnHeaderTop.Controls.Add(this.Welcomelbl);
            this.pnHeaderTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnHeaderTop.Location = new System.Drawing.Point(0, 0);
            this.pnHeaderTop.Name = "pnHeaderTop";
            this.pnHeaderTop.Size = new System.Drawing.Size(893, 100);
            this.pnHeaderTop.TabIndex = 27;
            // 
            // pnMainLeft
            // 
            this.pnMainLeft.Controls.Add(this.pnTop);
            this.pnMainLeft.Controls.Add(this.pnLeft);
            this.pnMainLeft.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnMainLeft.Location = new System.Drawing.Point(20, 20);
            this.pnMainLeft.Name = "pnMainLeft";
            this.pnMainLeft.Size = new System.Drawing.Size(893, 821);
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
            this.Padding = new System.Windows.Forms.Padding(20);
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
            ((System.ComponentModel.ISupportInitialize)(this.chkStartWithWindows.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBoxAbout)).EndInit();
            this.groupBox8.ResumeLayout(false);
            this.groupBox8.PerformLayout();
            this.pnRight.ResumeLayout(false);
            this.pnLeft.ResumeLayout(false);
            this.pnTop.ResumeLayout(false);
            this.pnHeaderBottom.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btnMiniTimer)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.svgImageBox1)).EndInit();
            this.pnHeaderTop.ResumeLayout(false);
            this.pnMainLeft.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Welcomelbl;
        private System.Windows.Forms.Label lblTimer;
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
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtTaskDetails;
        private System.Windows.Forms.ListView listViewTasks;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.NotifyIcon notifyIcon;
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
        private DevExpress.XtraEditors.SimpleButton btnDeleteSession;
        private DevExpress.XtraEditors.SimpleButton btnSaveSession;
        private DevExpress.XtraEditors.SimpleButton btnStart;
        private DevExpress.XtraEditors.SimpleButton btnPause;
        private DevExpress.XtraEditors.SimpleButton btnStop;
        private DevExpress.XtraEditors.SimpleButton btnViewLogs;
        private DevExpress.XtraEditors.SimpleButton btnReminders;
        private DevExpress.XtraEditors.SimpleButton btnTaskManager;
        private DevExpress.XtraEditors.SvgImageBox svgImageBoxAbout;
        private DevExpress.XtraEditors.CheckEdit chkStartWithWindows;
        private DevExpress.XtraEditors.SvgImageBox svgImageBox1;
        private DevExpress.XtraEditors.SvgImageBox btnMiniTimer;
    }
}

