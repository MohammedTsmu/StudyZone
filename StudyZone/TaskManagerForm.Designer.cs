namespace StudyZone
{
    partial class TaskManagerForm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManagerForm));
            this.dataGridViewTasks = new System.Windows.Forms.DataGridView();
            this.chkShowCompleted = new System.Windows.Forms.CheckBox();
            this.cmbSortBy = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbSessionFilter = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.cmbDueDateFilter = new System.Windows.Forms.ComboBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnFill = new System.Windows.Forms.Panel();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.btnMarkCompleted = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteTask = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddTask = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.pnTop.SuspendLayout();
            this.pnFill.SuspendLayout();
            this.pnBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewTasks
            // 
            this.dataGridViewTasks.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridViewTasks.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridViewTasks.BackgroundColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTasks.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.dataGridViewTasks.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dataGridViewTasks.Location = new System.Drawing.Point(0, 0);
            this.dataGridViewTasks.Name = "dataGridViewTasks";
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTasks.RowHeadersDefaultCellStyle = dataGridViewCellStyle5;
            this.dataGridViewTasks.RowHeadersWidth = 51;
            dataGridViewCellStyle6.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dataGridViewTasks.RowsDefaultCellStyle = dataGridViewCellStyle6;
            this.dataGridViewTasks.RowTemplate.Height = 24;
            this.dataGridViewTasks.Size = new System.Drawing.Size(1200, 424);
            this.dataGridViewTasks.TabIndex = 0;
            this.dataGridViewTasks.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.DataGridViewTasks_DataBindingComplete);
            // 
            // chkShowCompleted
            // 
            this.chkShowCompleted.AutoSize = true;
            this.chkShowCompleted.BackColor = System.Drawing.Color.Transparent;
            this.chkShowCompleted.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.chkShowCompleted.ForeColor = System.Drawing.Color.Black;
            this.chkShowCompleted.Location = new System.Drawing.Point(170, 14);
            this.chkShowCompleted.Name = "chkShowCompleted";
            this.chkShowCompleted.Size = new System.Drawing.Size(239, 27);
            this.chkShowCompleted.TabIndex = 6;
            this.chkShowCompleted.Text = "Show Completed Tasks";
            this.chkShowCompleted.UseVisualStyleBackColor = false;
            this.chkShowCompleted.CheckedChanged += new System.EventHandler(this.chkShowCompleted_CheckedChanged);
            // 
            // cmbSortBy
            // 
            this.cmbSortBy.BackColor = System.Drawing.Color.Silver;
            this.cmbSortBy.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSortBy.ForeColor = System.Drawing.Color.Black;
            this.cmbSortBy.FormattingEnabled = true;
            this.cmbSortBy.Location = new System.Drawing.Point(208, 12);
            this.cmbSortBy.Name = "cmbSortBy";
            this.cmbSortBy.Size = new System.Drawing.Size(208, 31);
            this.cmbSortBy.TabIndex = 5;
            this.cmbSortBy.SelectedIndexChanged += new System.EventHandler(this.cmbSortBy_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(163, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "By:";
            // 
            // cmbSessionFilter
            // 
            this.cmbSessionFilter.BackColor = System.Drawing.Color.Silver;
            this.cmbSessionFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbSessionFilter.ForeColor = System.Drawing.Color.Black;
            this.cmbSessionFilter.FormattingEnabled = true;
            this.cmbSessionFilter.Location = new System.Drawing.Point(370, 15);
            this.cmbSessionFilter.Name = "cmbSessionFilter";
            this.cmbSessionFilter.Size = new System.Drawing.Size(208, 31);
            this.cmbSessionFilter.TabIndex = 7;
            this.cmbSessionFilter.SelectedIndexChanged += new System.EventHandler(this.cmbSessionFilter_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(279, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 23);
            this.label2.TabIndex = 9;
            this.label2.Text = "Session:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(584, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Due Date:";
            // 
            // cmbDueDateFilter
            // 
            this.cmbDueDateFilter.BackColor = System.Drawing.Color.Silver;
            this.cmbDueDateFilter.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbDueDateFilter.ForeColor = System.Drawing.Color.Black;
            this.cmbDueDateFilter.FormattingEnabled = true;
            this.cmbDueDateFilter.Location = new System.Drawing.Point(689, 15);
            this.cmbDueDateFilter.Name = "cmbDueDateFilter";
            this.cmbDueDateFilter.Size = new System.Drawing.Size(208, 31);
            this.cmbDueDateFilter.TabIndex = 8;
            this.cmbDueDateFilter.SelectedIndexChanged += new System.EventHandler(this.cmbDueDateFilter_SelectedIndexChanged);
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.cmbSortBy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 54);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.cmbDueDateFilter);
            this.groupBox2.Controls.Add(this.cmbSessionFilter);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox2.Location = new System.Drawing.Point(11, 72);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1177, 61);
            this.groupBox2.TabIndex = 13;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Filter";
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.chkShowCompleted);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox3.Location = new System.Drawing.Point(608, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 54);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // pnTop
            // 
            this.pnTop.AutoScroll = true;
            this.pnTop.Controls.Add(this.groupBox1);
            this.pnTop.Controls.Add(this.groupBox3);
            this.pnTop.Controls.Add(this.groupBox2);
            this.pnTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnTop.Location = new System.Drawing.Point(0, 0);
            this.pnTop.Name = "pnTop";
            this.pnTop.Size = new System.Drawing.Size(1200, 151);
            this.pnTop.TabIndex = 8;
            // 
            // pnFill
            // 
            this.pnFill.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.pnFill.Controls.Add(this.dataGridViewTasks);
            this.pnFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFill.Location = new System.Drawing.Point(0, 151);
            this.pnFill.Name = "pnFill";
            this.pnFill.Size = new System.Drawing.Size(1200, 424);
            this.pnFill.TabIndex = 9;
            // 
            // pnBottom
            // 
            this.pnBottom.BackColor = System.Drawing.SystemColors.ControlLight;
            this.pnBottom.Controls.Add(this.btnMarkCompleted);
            this.pnBottom.Controls.Add(this.btnDeleteTask);
            this.pnBottom.Controls.Add(this.simpleButton1);
            this.pnBottom.Controls.Add(this.btnAddTask);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 575);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(1200, 71);
            this.pnBottom.TabIndex = 10;
            // 
            // btnMarkCompleted
            // 
            this.btnMarkCompleted.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnMarkCompleted.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnMarkCompleted.Appearance.Options.UseFont = true;
            this.btnMarkCompleted.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnMarkCompleted.ImageOptions.SvgImage")));
            this.btnMarkCompleted.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnMarkCompleted.Location = new System.Drawing.Point(794, 16);
            this.btnMarkCompleted.Name = "btnMarkCompleted";
            this.btnMarkCompleted.Size = new System.Drawing.Size(237, 38);
            this.btnMarkCompleted.TabIndex = 4;
            this.btnMarkCompleted.Text = "Mark Completed";
            this.btnMarkCompleted.Click += new System.EventHandler(this.btnMarkCompleted_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteTask.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTask.Appearance.Options.UseFont = true;
            this.btnDeleteTask.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteTask.ImageOptions.SvgImage")));
            this.btnDeleteTask.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnDeleteTask.Location = new System.Drawing.Point(586, 16);
            this.btnDeleteTask.Name = "btnDeleteTask";
            this.btnDeleteTask.Size = new System.Drawing.Size(190, 38);
            this.btnDeleteTask.TabIndex = 3;
            this.btnDeleteTask.Text = "Delete";
            this.btnDeleteTask.Click += new System.EventHandler(this.btnDeleteTask_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.simpleButton1.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.simpleButton1.Appearance.Options.UseFont = true;
            this.simpleButton1.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("simpleButton1.ImageOptions.SvgImage")));
            this.simpleButton1.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.simpleButton1.Location = new System.Drawing.Point(378, 16);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(190, 38);
            this.simpleButton1.TabIndex = 2;
            this.simpleButton1.Text = "Edit";
            this.simpleButton1.Click += new System.EventHandler(this.btnEditTask_Click);
            // 
            // btnAddTask
            // 
            this.btnAddTask.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddTask.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddTask.Appearance.Options.UseFont = true;
            this.btnAddTask.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddTask.ImageOptions.SvgImage")));
            this.btnAddTask.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnAddTask.Location = new System.Drawing.Point(170, 16);
            this.btnAddTask.Name = "btnAddTask";
            this.btnAddTask.Size = new System.Drawing.Size(190, 38);
            this.btnAddTask.TabIndex = 1;
            this.btnAddTask.Text = "Add";
            this.btnAddTask.Click += new System.EventHandler(this.btnAddTask_Click);
            // 
            // TaskManagerForm
            // 
            this.AccessibleName = "Task Manager";
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1200, 646);
            this.Controls.Add(this.pnFill);
            this.Controls.Add(this.pnBottom);
            this.Controls.Add(this.pnTop);
            this.Name = "TaskManagerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.TopMost = true;
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewTasks)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.pnTop.ResumeLayout(false);
            this.pnFill.ResumeLayout(false);
            this.pnBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewTasks;
        private System.Windows.Forms.CheckBox chkShowCompleted;
        private System.Windows.Forms.ComboBox cmbSortBy;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbSessionFilter;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cmbDueDateFilter;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnFill;
        private System.Windows.Forms.Panel pnBottom;
        private DevExpress.XtraEditors.SimpleButton btnAddTask;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnDeleteTask;
        private DevExpress.XtraEditors.SimpleButton btnMarkCompleted;
    }
}