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
            this.panelSummary = new DevExpress.XtraEditors.PanelControl();
            this.lblSummaryCount = new DevExpress.XtraEditors.LabelControl();
            this.lblSummaryBreak = new DevExpress.XtraEditors.LabelControl();
            this.lblSummaryStudy = new DevExpress.XtraEditors.LabelControl();
            this.comboFilter = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnApplyFilter = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteLog = new DevExpress.XtraEditors.SimpleButton();
            this.gridControlLogs = new DevExpress.XtraGrid.GridControl();
            this.gridViewLogs = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.lblTotalStudyTime = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalBreakTime = new DevExpress.XtraEditors.LabelControl();
            this.lblTotalSessions = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.panelSummary)).BeginInit();
            this.panelSummary.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLogs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.Controls.Add(this.panelSummary);
            this.panel1.Controls.Add(this.comboFilter);
            this.panel1.Controls.Add(this.btnApplyFilter);
            this.panel1.Controls.Add(this.btnDeleteLog);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(5, 5);
            this.panel1.Name = "panel1";
            this.panel1.Padding = new System.Windows.Forms.Padding(10);
            this.panel1.Size = new System.Drawing.Size(1052, 106);
            this.panel1.TabIndex = 8;
            // 
            // panelSummary
            // 
            this.panelSummary.Controls.Add(this.lblSummaryCount);
            this.panelSummary.Controls.Add(this.lblSummaryBreak);
            this.panelSummary.Controls.Add(this.lblSummaryStudy);
            this.panelSummary.Location = new System.Drawing.Point(33, 13);
            this.panelSummary.Name = "panelSummary";
            this.panelSummary.Size = new System.Drawing.Size(594, 72);
            this.panelSummary.TabIndex = 5;
            // 
            // lblSummaryCount
            // 
            this.lblSummaryCount.Appearance.Font = new System.Drawing.Font("LBC", 12F);
            this.lblSummaryCount.Appearance.Options.UseFont = true;
            this.lblSummaryCount.Appearance.Options.UseTextOptions = true;
            this.lblSummaryCount.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblSummaryCount.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblSummaryCount.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblSummaryCount.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSummaryCount.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSummaryCount.Location = new System.Drawing.Point(390, 2);
            this.lblSummaryCount.Name = "lblSummaryCount";
            this.lblSummaryCount.Size = new System.Drawing.Size(194, 68);
            this.lblSummaryCount.TabIndex = 2;
            this.lblSummaryCount.Text = "labelControl3";
            // 
            // lblSummaryBreak
            // 
            this.lblSummaryBreak.Appearance.Font = new System.Drawing.Font("LBC", 12F);
            this.lblSummaryBreak.Appearance.Options.UseFont = true;
            this.lblSummaryBreak.Appearance.Options.UseTextOptions = true;
            this.lblSummaryBreak.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblSummaryBreak.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblSummaryBreak.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblSummaryBreak.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSummaryBreak.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSummaryBreak.Location = new System.Drawing.Point(196, 2);
            this.lblSummaryBreak.Name = "lblSummaryBreak";
            this.lblSummaryBreak.Size = new System.Drawing.Size(194, 68);
            this.lblSummaryBreak.TabIndex = 1;
            this.lblSummaryBreak.Text = "labelControl2";
            // 
            // lblSummaryStudy
            // 
            this.lblSummaryStudy.Appearance.Font = new System.Drawing.Font("LBC", 12F);
            this.lblSummaryStudy.Appearance.Options.UseFont = true;
            this.lblSummaryStudy.Appearance.Options.UseTextOptions = true;
            this.lblSummaryStudy.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.lblSummaryStudy.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.lblSummaryStudy.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.lblSummaryStudy.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblSummaryStudy.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblSummaryStudy.Location = new System.Drawing.Point(2, 2);
            this.lblSummaryStudy.Name = "lblSummaryStudy";
            this.lblSummaryStudy.Size = new System.Drawing.Size(194, 68);
            this.lblSummaryStudy.TabIndex = 0;
            this.lblSummaryStudy.Text = "labelControl1";
            // 
            // comboFilter
            // 
            this.comboFilter.Location = new System.Drawing.Point(633, 17);
            this.comboFilter.Name = "comboFilter";
            this.comboFilter.Properties.Appearance.Font = new System.Drawing.Font("LBC", 12F);
            this.comboFilter.Properties.Appearance.Options.UseFont = true;
            this.comboFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboFilter.Properties.Items.AddRange(new object[] {
            "All",
            "Today",
            "This Week",
            "This Month"});
            this.comboFilter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboFilter.Size = new System.Drawing.Size(386, 32);
            this.comboFilter.TabIndex = 4;
            // 
            // btnApplyFilter
            // 
            this.btnApplyFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnApplyFilter.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnApplyFilter.Appearance.Options.UseFont = true;
            this.btnApplyFilter.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnApplyFilter.ImageOptions.SvgImage")));
            this.btnApplyFilter.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnApplyFilter.Location = new System.Drawing.Point(633, 55);
            this.btnApplyFilter.Name = "btnApplyFilter";
            this.btnApplyFilter.Size = new System.Drawing.Size(190, 38);
            this.btnApplyFilter.TabIndex = 1;
            this.btnApplyFilter.Text = "Applay Filter";
            this.btnApplyFilter.Click += new System.EventHandler(this.btnApplyFilter_Click);
            // 
            // btnDeleteLog
            // 
            this.btnDeleteLog.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteLog.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnDeleteLog.Appearance.Options.UseFont = true;
            this.btnDeleteLog.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteLog.ImageOptions.SvgImage")));
            this.btnDeleteLog.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnDeleteLog.Location = new System.Drawing.Point(829, 55);
            this.btnDeleteLog.Name = "btnDeleteLog";
            this.btnDeleteLog.Size = new System.Drawing.Size(190, 38);
            this.btnDeleteLog.TabIndex = 2;
            this.btnDeleteLog.Text = "Delete Log";
            this.btnDeleteLog.Click += new System.EventHandler(this.btnDeleteLog_Click);
            // 
            // gridControlLogs
            // 
            this.gridControlLogs.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlLogs.Location = new System.Drawing.Point(5, 111);
            this.gridControlLogs.MainView = this.gridViewLogs;
            this.gridControlLogs.Name = "gridControlLogs";
            this.gridControlLogs.Size = new System.Drawing.Size(1052, 557);
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
            // lblTotalStudyTime
            // 
            this.lblTotalStudyTime.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.lblTotalStudyTime.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalStudyTime.Appearance.Options.UseBackColor = true;
            this.lblTotalStudyTime.Appearance.Options.UseFont = true;
            this.lblTotalStudyTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalStudyTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalStudyTime.Location = new System.Drawing.Point(2, 28);
            this.lblTotalStudyTime.Name = "lblTotalStudyTime";
            this.lblTotalStudyTime.Size = new System.Drawing.Size(248, 70);
            this.lblTotalStudyTime.TabIndex = 6;
            this.lblTotalStudyTime.Text = "labelControl1";
            // 
            // lblTotalBreakTime
            // 
            this.lblTotalBreakTime.Appearance.BackColor = System.Drawing.Color.Cyan;
            this.lblTotalBreakTime.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalBreakTime.Appearance.Options.UseBackColor = true;
            this.lblTotalBreakTime.Appearance.Options.UseFont = true;
            this.lblTotalBreakTime.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalBreakTime.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalBreakTime.Location = new System.Drawing.Point(250, 28);
            this.lblTotalBreakTime.Name = "lblTotalBreakTime";
            this.lblTotalBreakTime.Size = new System.Drawing.Size(268, 70);
            this.lblTotalBreakTime.TabIndex = 7;
            this.lblTotalBreakTime.Text = "labelControl2";
            // 
            // lblTotalSessions
            // 
            this.lblTotalSessions.Appearance.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.lblTotalSessions.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalSessions.Appearance.Options.UseBackColor = true;
            this.lblTotalSessions.Appearance.Options.UseFont = true;
            this.lblTotalSessions.AutoSizeMode = DevExpress.XtraEditors.LabelAutoSizeMode.None;
            this.lblTotalSessions.Dock = System.Windows.Forms.DockStyle.Left;
            this.lblTotalSessions.Location = new System.Drawing.Point(518, 28);
            this.lblTotalSessions.Name = "lblTotalSessions";
            this.lblTotalSessions.Size = new System.Drawing.Size(279, 70);
            this.lblTotalSessions.TabIndex = 8;
            this.lblTotalSessions.Text = "labelControl3";
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
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(5, 568);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(1052, 100);
            this.groupControl1.TabIndex = 10;
            this.groupControl1.Text = "Statisitcs";
            // 
            // SessionLogsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1062, 673);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.gridControlLogs);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "SessionLogsForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Session Logs and Statistics";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.panelSummary)).EndInit();
            this.panelSummary.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.comboFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewLogs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
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
        private DevExpress.XtraEditors.PanelControl panelSummary;
        private DevExpress.XtraEditors.LabelControl lblSummaryCount;
        private DevExpress.XtraEditors.LabelControl lblSummaryBreak;
        private DevExpress.XtraEditors.LabelControl lblSummaryStudy;
    }
}