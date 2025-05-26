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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SessionLogsForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel3 = new System.Windows.Forms.Panel();
            this.comboFilter = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnDeleteLog = new DevExpress.XtraEditors.SimpleButton();
            this.btnApplyFilter = new DevExpress.XtraEditors.SimpleButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.lblTotalSessions = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalBreakTime = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalStudyTime = new DevExpress.XtraEditors.LabelControl();
            this.gridControlLogs = new DevExpress.XtraGrid.GridControl();
            this.gridViewLogs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.panel1.SuspendLayout();
            this.panel3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboFilter.Properties)).BeginInit();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLogs)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1052, 100);
            this.panel1.TabIndex = 8;
            // 
            // panel3
            // 
            this.panel3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel3.Controls.Add(this.comboFilter);
            this.panel3.Controls.Add(this.btnDeleteLog);
            this.panel3.Controls.Add(this.btnApplyFilter);
            this.panel3.Location = new System.Drawing.Point(697, 7);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(347, 86);
            this.panel3.TabIndex = 6;
            // 
            // comboFilter
            // 
            this.comboFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.comboFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboFilter.Location = new System.Drawing.Point(10, 5);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Properties.Appearance.Font = new System.Drawing.Font("LBC", 12F);
            this.comboFilter.Properties.Appearance.Options.UseFont = true;
            this.comboFilter.Properties.AppearanceDisabled.Font = new System.Drawing.Font("LBC", 12F);
            this.comboFilter.Properties.AppearanceDisabled.Options.UseFont = true;
            this.comboFilter.Properties.AppearanceDropDown.Font = new System.Drawing.Font("LBC", 12F);
            this.comboFilter.Properties.AppearanceDropDown.Options.UseFont = true;
            this.comboFilter.Properties.AppearanceFocused.Font = new System.Drawing.Font("LBC", 12F);
            this.comboFilter.Properties.AppearanceFocused.Options.UseFont = true;
            this.comboFilter.Properties.AppearanceItemDisabled.Font = new System.Drawing.Font("LBC", 12F);
            this.comboFilter.Properties.AppearanceItemDisabled.Options.UseFont = true;
            this.comboFilter.Properties.AppearanceItemHighlight.Font = new System.Drawing.Font("LBC", 12F);
            this.comboFilter.Properties.AppearanceItemHighlight.Options.UseFont = true;
            this.comboFilter.Properties.AppearanceItemSelected.Font = new System.Drawing.Font("LBC", 12F);
            this.comboFilter.Properties.AppearanceItemSelected.Options.UseFont = true;
            this.comboFilter.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("LBC", 12F);
            this.comboFilter.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.comboFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboFilter.Properties.Items.AddRange(new object[] {
            "All",
            "Today",
            "This Week",
            "This Month"});
            this.comboFilter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboFilter.Size = new System.Drawing.Size(326, 32);
            this.comboFilter.TabIndex = 4;
            // 
            // btnDeleteLog
            // 
            this.btnDeleteLog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnDeleteLog.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnDeleteLog.Appearance.Options.UseFont = true;
            this.btnDeleteLog.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteLog.ImageOptions.SvgImage")));
            this.btnDeleteLog.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnDeleteLog.Location = new System.Drawing.Point(176, 43);
            this.btnDeleteLog.Name = "btnDeleteLog";
            this.btnDeleteLog.Size = new System.Drawing.Size(160, 38);
            this.btnDeleteLog.TabIndex = 2;
            this.btnDeleteLog.Text = "Delete Log";
            this.btnDeleteLog.Click += new System.EventHandler(this.btnDeleteLog_Click);
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnApplyFilter.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnApplyFilter.Appearance.Options.UseFont = true;
            this.btnApplyFilter.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnApplyFilter.ImageOptions.SvgImage")));
            this.btnApplyFilter.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnApplyFilter.Location = new System.Drawing.Point(10, 43);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(160, 38);
            this.btnApplyFilter.TabIndex = 1;
            this.btnApplyFilter.Text = "Applay Filter";
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // panel2
            // 
            this.panel2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.panel2.Controls.Add(this.groupControl1);
            this.panel2.Location = new System.Drawing.Point(9, 7);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(682, 86);
            this.panel2.TabIndex = 5;
            // 
            // groupControl1
            // 
            this.groupControl1.Appearance.BackColor = System.Drawing.Color.SteelBlue;
            this.groupControl1.Appearance.Options.UseBackColor = true;
            this.groupControl1.AppearanceCaption.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupControl1.AppearanceCaption.Options.UseFont = true;
            this.groupControl1.Controls.Add(this.lblTotalSessions);
            this.groupControl1.Controls.Add(this.lblTotalBreakTime);
            this.groupControl1.Controls.Add(this.lblTotalStudyTime);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.groupControl1.Location = new System.Drawing.Point(0, 0);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(682, 86);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Statisitcs";
            // 
            // lblTotalSessions
            // 
            this.lblTotalSessions.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTotalSessions.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSessions.Appearance.Options.UseBackColor = true;
            this.lblTotalSessions.Appearance.Options.UseFont = true;
            this.lblTotalSessions.Appearance.Options.UseTextOptions = true;
            this.lblTotalSessions.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTotalSessions.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTotalSessions.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblTotalSessions.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalSessions.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalSessions.Location = new System.Drawing.Point(452, 28);
            this.lblTotalSessions.Name = "lblTotalSessions";
            this.lblTotalSessions.Padding = new System.Windows.Forms.Padding(5);
            this.lblTotalSessions.Size = new System.Drawing.Size(230, 56);
            this.lblTotalSessions.TabIndex = 8;
            this.lblTotalSessions.Text = "labelControl3";
            // 
            // lblTotalBreakTime
            // 
            this.lblTotalBreakTime.Appearance.BackColor = System.Drawing.Color.Cyan;
            this.lblTotalBreakTime.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBreakTime.Appearance.Options.UseBackColor = true;
            this.lblTotalBreakTime.Appearance.Options.UseFont = true;
            this.lblTotalBreakTime.Appearance.Options.UseTextOptions = true;
            this.lblTotalBreakTime.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTotalBreakTime.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTotalBreakTime.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblTotalBreakTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalBreakTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalBreakTime.Location = new System.Drawing.Point(227, 28);
            this.lblTotalBreakTime.Name = "lblTotalBreakTime";
            this.lblTotalBreakTime.Padding = new System.Windows.Forms.Padding(5);
            this.lblTotalBreakTime.Size = new System.Drawing.Size(225, 56);
            this.lblTotalBreakTime.TabIndex = 7;
            this.lblTotalBreakTime.Text = "labelControl2";
            // 
            // lblTotalStudyTime
            // 
            this.lblTotalStudyTime.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTotalStudyTime.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudyTime.Appearance.Options.UseBackColor = true;
            this.lblTotalStudyTime.Appearance.Options.UseFont = true;
            this.lblTotalStudyTime.Appearance.Options.UseTextOptions = true;
            this.lblTotalStudyTime.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblTotalStudyTime.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblTotalStudyTime.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblTotalStudyTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalStudyTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalStudyTime.Location = new System.Drawing.Point(2, 28);
            this.lblTotalStudyTime.Name = "lblTotalStudyTime";
            this.lblTotalStudyTime.Padding = new System.Windows.Forms.Padding(5);
            this.lblTotalStudyTime.Size = new System.Drawing.Size(225, 56);
            this.lblTotalStudyTime.TabIndex = 6;
            this.lblTotalStudyTime.Text = "labelControl1";
            // 
            // gridControlLogs
            // 
            this.gridControlLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLogs.Location = new System.Drawing.Point(5, 105);
            this.gridControlLogs.MainView = this.gridViewLogs;
            this.gridControlLogs.Name = "gridControlLogs";
            this.gridControlLogs.Size = new System.Drawing.Size(1052, 563);
            this.gridControlLogs.TabIndex = 9;
            this.gridControlLogs.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewLogs});
            // 
            // gridViewLogs
            // 
            this.gridViewLogs.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridViewLogs.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridViewLogs.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridViewLogs.Appearance.DetailTip.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.DetailTip.Options.UseFont = true;
            this.gridViewLogs.Appearance.Empty.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.Empty.Options.UseFont = true;
            this.gridViewLogs.Appearance.EvenRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.EvenRow.Options.UseFont = true;
            this.gridViewLogs.Appearance.FilterCloseButton.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridViewLogs.Appearance.FilterPanel.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.FilterPanel.Options.UseFont = true;
            this.gridViewLogs.Appearance.FixedLine.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.FixedLine.Options.UseFont = true;
            this.gridViewLogs.Appearance.FocusedCell.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.FocusedCell.Options.UseFont = true;
            this.gridViewLogs.Appearance.FocusedRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewLogs.Appearance.FooterPanel.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewLogs.Appearance.GroupButton.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.GroupButton.Options.UseFont = true;
            this.gridViewLogs.Appearance.GroupFooter.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.GroupFooter.Options.UseFont = true;
            this.gridViewLogs.Appearance.GroupPanel.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewLogs.Appearance.GroupRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewLogs.Appearance.HeaderPanel.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.gridViewLogs.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewLogs.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewLogs.Appearance.HideSelectionRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridViewLogs.Appearance.HorzLine.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.HorzLine.Options.UseFont = true;
            this.gridViewLogs.Appearance.HotTrackedRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.HotTrackedRow.Options.UseFont = true;
            this.gridViewLogs.Appearance.NoSearchResults.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.NoSearchResults.Options.UseFont = true;
            this.gridViewLogs.Appearance.OddRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.OddRow.Options.UseFont = true;
            this.gridViewLogs.Appearance.Preview.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.Preview.Options.UseFont = true;
            this.gridViewLogs.Appearance.Row.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.Row.Options.UseFont = true;
            this.gridViewLogs.Appearance.RowSeparator.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.RowSeparator.Options.UseFont = true;
            this.gridViewLogs.Appearance.SelectedRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewLogs.Appearance.TopNewRow.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.TopNewRow.Options.UseFont = true;
            this.gridViewLogs.Appearance.VertLine.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.VertLine.Options.UseFont = true;
            this.gridViewLogs.Appearance.ViewCaption.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewLogs.Appearance.ViewCaption.Options.UseFont = true;
            this.gridViewLogs.GridControl = this.gridControlLogs;
            this.gridViewLogs.Name = "gridViewLogs";
            // 
            // SessionLogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.gridControlLogs);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SessionLogsForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Session Logs and Statistics";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panel1.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboFilter.Properties)).EndInit();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLogs)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnDeleteLog;
        private DevExpress.XtraEditors.SimpleButton btnApplyFilter;
        private DevExpress.XtraEditors.ComboBoxEdit comboFilter;
        private DevExpress.XtraGrid.GridControl gridControlLogs;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewLogs;
        private DevExpress.XtraEditors.LabelControl lblTotalSessions;
        private DevExpress.XtraEditors.LabelControl lblTotalBreakTime;
        private DevExpress.XtraEditors.LabelControl lblTotalStudyTime;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
    }
}