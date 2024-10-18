namespace StudyZone
{
    partial class SessionLogsForm
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
            this.dataGridViewLogs = new System.Windows.Forms.DataGridView();
            this.cmbFilter = new System.Windows.Forms.ComboBox();
            this.btnApplyFilter = new System.Windows.Forms.Button();
            this.lblTotalStudyTime = new System.Windows.Forms.Label();
            this.lblTotalBreakTime = new System.Windows.Forms.Label();
            this.lblTotalSessions = new System.Windows.Forms.Label();
            this.btnDeleteLog = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // dataGridViewLogs
            // 
            this.dataGridViewLogs.AllowUserToOrderColumns = true;
            this.dataGridViewLogs.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewLogs.Location = new System.Drawing.Point(12, 60);
            this.dataGridViewLogs.Name = "dataGridViewLogs";
            this.dataGridViewLogs.RowHeadersWidth = 51;
            this.dataGridViewLogs.RowTemplate.Height = 24;
            this.dataGridViewLogs.Size = new System.Drawing.Size(776, 281);
            this.dataGridViewLogs.TabIndex = 0;
            this.dataGridViewLogs.DataBindingComplete += new System.Windows.Forms.DataGridViewBindingCompleteEventHandler(this.dataGridViewLogs_DataBindingComplete);
            // 
            // cmbFilter
            // 
            this.cmbFilter.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbFilter.FormattingEnabled = true;
            this.cmbFilter.Location = new System.Drawing.Point(12, 12);
            this.cmbFilter.Name = "cmbFilter";
            this.cmbFilter.Size = new System.Drawing.Size(121, 24);
            this.cmbFilter.TabIndex = 1;
            this.cmbFilter.Text = "Filter";
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnApplyFilter.Location = new System.Drawing.Point(143, 12);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(121, 42);
            this.btnApplyFilter.TabIndex = 2;
            this.btnApplyFilter.Text = "Applay Filter";
            this.btnApplyFilter.UseVisualStyleBackColor = true;
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // lblTotalStudyTime
            // 
            this.lblTotalStudyTime.AutoSize = true;
            this.lblTotalStudyTime.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudyTime.Location = new System.Drawing.Point(6, 18);
            this.lblTotalStudyTime.Name = "lblTotalStudyTime";
            this.lblTotalStudyTime.Size = new System.Drawing.Size(127, 19);
            this.lblTotalStudyTime.TabIndex = 3;
            this.lblTotalStudyTime.Text = "Total Study Time";
            // 
            // lblTotalBreakTime
            // 
            this.lblTotalBreakTime.AutoSize = true;
            this.lblTotalBreakTime.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBreakTime.Location = new System.Drawing.Point(6, 37);
            this.lblTotalBreakTime.Name = "lblTotalBreakTime";
            this.lblTotalBreakTime.Size = new System.Drawing.Size(128, 19);
            this.lblTotalBreakTime.TabIndex = 4;
            this.lblTotalBreakTime.Text = "Total Break Time";
            // 
            // lblTotalSessions
            // 
            this.lblTotalSessions.AutoSize = true;
            this.lblTotalSessions.Font = new System.Drawing.Font("Arial", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSessions.Location = new System.Drawing.Point(6, 56);
            this.lblTotalSessions.Name = "lblTotalSessions";
            this.lblTotalSessions.Size = new System.Drawing.Size(112, 19);
            this.lblTotalSessions.TabIndex = 5;
            this.lblTotalSessions.Text = "Total Sessions";
            // 
            // btnDeleteLog
            // 
            this.btnDeleteLog.Font = new System.Drawing.Font("Arial", 7.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteLog.Location = new System.Drawing.Point(270, 12);
            this.btnDeleteLog.Name = "btnDeleteLog";
            this.btnDeleteLog.Size = new System.Drawing.Size(197, 42);
            this.btnDeleteLog.TabIndex = 6;
            this.btnDeleteLog.Text = "Delete Selected Log";
            this.btnDeleteLog.UseVisualStyleBackColor = true;
            this.btnDeleteLog.Click += new System.EventHandler(this.btnDeleteLog_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblTotalStudyTime);
            this.groupBox1.Controls.Add(this.lblTotalBreakTime);
            this.groupBox1.Controls.Add(this.lblTotalSessions);
            this.groupBox1.Location = new System.Drawing.Point(12, 347);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 91);
            this.groupBox1.TabIndex = 7;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Statisitcs";
            // 
            // SessionLogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnDeleteLog);
            this.Controls.Add(this.btnApplyFilter);
            this.Controls.Add(this.cmbFilter);
            this.Controls.Add(this.dataGridViewLogs);
            this.Name = "SessionLogsForm";
            this.Text = "SessionLogsForm";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewLogs)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridViewLogs;
        private System.Windows.Forms.ComboBox cmbFilter;
        private System.Windows.Forms.Button btnApplyFilter;
        private System.Windows.Forms.Label lblTotalStudyTime;
        private System.Windows.Forms.Label lblTotalBreakTime;
        private System.Windows.Forms.Label lblTotalSessions;
        private System.Windows.Forms.Button btnDeleteLog;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}