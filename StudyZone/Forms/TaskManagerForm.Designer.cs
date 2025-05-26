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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TaskManagerForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboSortBy = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.comboDueDateFilter = new DevExpress.XtraEditors.ComboBoxEdit();
            this.comboSessionFilter = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.checkShowCompleted = new DevExpress.XtraEditors.CheckEdit();
            this.pnTop = new System.Windows.Forms.Panel();
            this.pnFill = new System.Windows.Forms.Panel();
            this.gridControlTasks = new DevExpress.XtraGrid.GridControl();
            this.gridViewTasks = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.pnBottom = new System.Windows.Forms.Panel();
            this.btnToggleCompleted = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteTask = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddTask = new DevExpress.XtraEditors.SimpleButton();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboSortBy.Properties)).BeginInit();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboDueDateFilter.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboSessionFilter.Properties)).BeginInit();
            this.groupBox3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.checkShowCompleted.Properties)).BeginInit();
            this.pnTop.SuspendLayout();
            this.pnFill.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTasks)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTasks)).BeginInit();
            this.pnBottom.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Arial", 12F);
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(162, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "By:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Arial", 12F);
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
            this.label3.Font = new System.Drawing.Font("Arial", 12F);
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(585, 19);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(99, 23);
            this.label3.TabIndex = 10;
            this.label3.Text = "Due Date:";
            // 
            // groupBox1
            // 
            this.groupBox1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox1.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox1.Controls.Add(this.comboSortBy);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.groupBox1.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(590, 54);
            this.groupBox1.TabIndex = 12;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Sort";
            // 
            // comboSortBy
            // 
            this.comboSortBy.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboSortBy.Location = new System.Drawing.Point(207, 11);
            this.comboSortBy.Name = "comboSortBy";
            this.comboSortBy.Properties.Appearance.Font = new System.Drawing.Font("LBC", 12F);
            this.comboSortBy.Properties.Appearance.Options.UseFont = true;
            this.comboSortBy.Properties.AppearanceDisabled.Font = new System.Drawing.Font("LBC", 12F);
            this.comboSortBy.Properties.AppearanceDisabled.Options.UseFont = true;
            this.comboSortBy.Properties.AppearanceDropDown.Font = new System.Drawing.Font("LBC", 12F);
            this.comboSortBy.Properties.AppearanceDropDown.Options.UseFont = true;
            this.comboSortBy.Properties.AppearanceFocused.Font = new System.Drawing.Font("LBC", 12F);
            this.comboSortBy.Properties.AppearanceFocused.Options.UseFont = true;
            this.comboSortBy.Properties.AppearanceItemDisabled.Font = new System.Drawing.Font("LBC", 12F);
            this.comboSortBy.Properties.AppearanceItemDisabled.Options.UseFont = true;
            this.comboSortBy.Properties.AppearanceItemHighlight.Font = new System.Drawing.Font("LBC", 12F);
            this.comboSortBy.Properties.AppearanceItemHighlight.Options.UseFont = true;
            this.comboSortBy.Properties.AppearanceItemSelected.Font = new System.Drawing.Font("LBC", 12F);
            this.comboSortBy.Properties.AppearanceItemSelected.Options.UseFont = true;
            this.comboSortBy.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("LBC", 12F);
            this.comboSortBy.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.comboSortBy.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboSortBy.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboSortBy.Size = new System.Drawing.Size(209, 32);
            this.comboSortBy.TabIndex = 13;
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox2.Controls.Add(this.comboDueDateFilter);
            this.groupBox2.Controls.Add(this.comboSessionFilter);
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
            // comboDueDateFilter
            // 
            this.comboDueDateFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboDueDateFilter.Location = new System.Drawing.Point(690, 14);
            this.comboDueDateFilter.Name = "comboDueDateFilter";
            this.comboDueDateFilter.Properties.Appearance.Font = new System.Drawing.Font("LBC", 12F);
            this.comboDueDateFilter.Properties.Appearance.Options.UseFont = true;
            this.comboDueDateFilter.Properties.AppearanceDisabled.Font = new System.Drawing.Font("LBC", 12F);
            this.comboDueDateFilter.Properties.AppearanceDisabled.Options.UseFont = true;
            this.comboDueDateFilter.Properties.AppearanceDropDown.Font = new System.Drawing.Font("LBC", 12F);
            this.comboDueDateFilter.Properties.AppearanceDropDown.Options.UseFont = true;
            this.comboDueDateFilter.Properties.AppearanceFocused.Font = new System.Drawing.Font("LBC", 12F);
            this.comboDueDateFilter.Properties.AppearanceFocused.Options.UseFont = true;
            this.comboDueDateFilter.Properties.AppearanceItemDisabled.Font = new System.Drawing.Font("LBC", 12F);
            this.comboDueDateFilter.Properties.AppearanceItemDisabled.Options.UseFont = true;
            this.comboDueDateFilter.Properties.AppearanceItemHighlight.Font = new System.Drawing.Font("LBC", 12F);
            this.comboDueDateFilter.Properties.AppearanceItemHighlight.Options.UseFont = true;
            this.comboDueDateFilter.Properties.AppearanceItemSelected.Font = new System.Drawing.Font("LBC", 12F);
            this.comboDueDateFilter.Properties.AppearanceItemSelected.Options.UseFont = true;
            this.comboDueDateFilter.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("LBC", 12F);
            this.comboDueDateFilter.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.comboDueDateFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboDueDateFilter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboDueDateFilter.Size = new System.Drawing.Size(208, 32);
            this.comboDueDateFilter.TabIndex = 12;
            // 
            // comboSessionFilter
            // 
            this.comboSessionFilter.Cursor = System.Windows.Forms.Cursors.Hand;
            this.comboSessionFilter.Location = new System.Drawing.Point(370, 14);
            this.comboSessionFilter.Name = "comboSessionFilter";
            this.comboSessionFilter.Properties.Appearance.Font = new System.Drawing.Font("LBC", 12F);
            this.comboSessionFilter.Properties.Appearance.Options.UseFont = true;
            this.comboSessionFilter.Properties.AppearanceDisabled.Font = new System.Drawing.Font("LBC", 12F);
            this.comboSessionFilter.Properties.AppearanceDisabled.Options.UseFont = true;
            this.comboSessionFilter.Properties.AppearanceDropDown.Font = new System.Drawing.Font("LBC", 12F);
            this.comboSessionFilter.Properties.AppearanceDropDown.Options.UseFont = true;
            this.comboSessionFilter.Properties.AppearanceFocused.Font = new System.Drawing.Font("LBC", 12F);
            this.comboSessionFilter.Properties.AppearanceFocused.Options.UseFont = true;
            this.comboSessionFilter.Properties.AppearanceItemDisabled.Font = new System.Drawing.Font("LBC", 12F);
            this.comboSessionFilter.Properties.AppearanceItemDisabled.Options.UseFont = true;
            this.comboSessionFilter.Properties.AppearanceItemHighlight.Font = new System.Drawing.Font("LBC", 12F);
            this.comboSessionFilter.Properties.AppearanceItemHighlight.Options.UseFont = true;
            this.comboSessionFilter.Properties.AppearanceItemSelected.Font = new System.Drawing.Font("LBC", 12F);
            this.comboSessionFilter.Properties.AppearanceItemSelected.Options.UseFont = true;
            this.comboSessionFilter.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("LBC", 12F);
            this.comboSessionFilter.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.comboSessionFilter.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboSessionFilter.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.comboSessionFilter.Size = new System.Drawing.Size(209, 32);
            this.comboSessionFilter.TabIndex = 11;
            // 
            // groupBox3
            // 
            this.groupBox3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.groupBox3.BackColor = System.Drawing.SystemColors.ControlLight;
            this.groupBox3.Controls.Add(this.checkShowCompleted);
            this.groupBox3.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.SystemColors.Desktop;
            this.groupBox3.Location = new System.Drawing.Point(608, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(580, 54);
            this.groupBox3.TabIndex = 14;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Status";
            // 
            // checkShowCompleted
            // 
            this.checkShowCompleted.Cursor = System.Windows.Forms.Cursors.Hand;
            this.checkShowCompleted.Location = new System.Drawing.Point(155, 12);
            this.checkShowCompleted.Name = "checkShowCompleted";
            this.checkShowCompleted.Properties.Appearance.Font = new System.Drawing.Font("Arial", 12F);
            this.checkShowCompleted.Properties.Appearance.Options.UseFont = true;
            this.checkShowCompleted.Properties.AppearanceDisabled.Font = new System.Drawing.Font("LBC", 12F);
            this.checkShowCompleted.Properties.AppearanceDisabled.Options.UseFont = true;
            this.checkShowCompleted.Properties.AppearanceFocused.Font = new System.Drawing.Font("LBC", 12F);
            this.checkShowCompleted.Properties.AppearanceFocused.Options.UseFont = true;
            this.checkShowCompleted.Properties.AppearanceReadOnly.Font = new System.Drawing.Font("LBC", 12F);
            this.checkShowCompleted.Properties.AppearanceReadOnly.Options.UseFont = true;
            this.checkShowCompleted.Properties.Caption = "Show Completed Tasks";
            this.checkShowCompleted.Properties.GlyphAlignment = DevExpress.Utils.HorzAlignment.Default;
            this.checkShowCompleted.Size = new System.Drawing.Size(271, 27);
            this.checkShowCompleted.TabIndex = 7;
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
            this.pnFill.BackColor = System.Drawing.Color.Transparent;
            this.pnFill.Controls.Add(this.gridControlTasks);
            this.pnFill.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnFill.Location = new System.Drawing.Point(0, 151);
            this.pnFill.Name = "pnFill";
            this.pnFill.Size = new System.Drawing.Size(1200, 424);
            this.pnFill.TabIndex = 9;
            // 
            // gridControlTasks
            // 
            this.gridControlTasks.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gridControlTasks.Location = new System.Drawing.Point(0, 0);
            this.gridControlTasks.MainView = this.gridViewTasks;
            this.gridControlTasks.Name = "gridControlTasks";
            this.gridControlTasks.Size = new System.Drawing.Size(1200, 424);
            this.gridControlTasks.TabIndex = 1;
            this.gridControlTasks.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridViewTasks});
            // 
            // gridViewTasks
            // 
            this.gridViewTasks.Appearance.ColumnFilterButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.ColumnFilterButton.Options.UseFont = true;
            this.gridViewTasks.Appearance.ColumnFilterButton.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.ColumnFilterButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.ColumnFilterButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.ColumnFilterButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.ColumnFilterButtonActive.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.ColumnFilterButtonActive.Options.UseFont = true;
            this.gridViewTasks.Appearance.ColumnFilterButtonActive.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.ColumnFilterButtonActive.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.ColumnFilterButtonActive.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.ColumnFilterButtonActive.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.CustomizationFormHint.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.CustomizationFormHint.Options.UseFont = true;
            this.gridViewTasks.Appearance.CustomizationFormHint.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.CustomizationFormHint.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.CustomizationFormHint.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.CustomizationFormHint.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.DetailTip.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.DetailTip.Options.UseFont = true;
            this.gridViewTasks.Appearance.DetailTip.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.DetailTip.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.DetailTip.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.DetailTip.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.Empty.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.Empty.Options.UseFont = true;
            this.gridViewTasks.Appearance.Empty.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.Empty.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.Empty.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.Empty.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.EvenRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.EvenRow.Options.UseFont = true;
            this.gridViewTasks.Appearance.EvenRow.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.EvenRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.EvenRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.EvenRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.FilterCloseButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.FilterCloseButton.Options.UseFont = true;
            this.gridViewTasks.Appearance.FilterCloseButton.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.FilterCloseButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.FilterCloseButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.FilterCloseButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.FilterPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.FilterPanel.Options.UseFont = true;
            this.gridViewTasks.Appearance.FilterPanel.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.FilterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.FilterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.FilterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.FixedLine.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.FixedLine.Options.UseFont = true;
            this.gridViewTasks.Appearance.FixedLine.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.FixedLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.FixedLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.FixedLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.FocusedCell.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.FocusedCell.Options.UseFont = true;
            this.gridViewTasks.Appearance.FocusedCell.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.FocusedCell.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.FocusedCell.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.FocusedCell.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.FocusedRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.FocusedRow.Options.UseFont = true;
            this.gridViewTasks.Appearance.FocusedRow.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.FocusedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.FocusedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.FocusedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.FooterPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.FooterPanel.Options.UseFont = true;
            this.gridViewTasks.Appearance.FooterPanel.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.FooterPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.FooterPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.FooterPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.GroupButton.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.GroupButton.Options.UseFont = true;
            this.gridViewTasks.Appearance.GroupButton.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.GroupButton.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.GroupButton.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.GroupButton.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.GroupFooter.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.GroupFooter.Options.UseFont = true;
            this.gridViewTasks.Appearance.GroupFooter.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.GroupFooter.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.GroupFooter.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.GroupFooter.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.GroupPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.GroupPanel.Options.UseFont = true;
            this.gridViewTasks.Appearance.GroupPanel.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.GroupPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.GroupPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.GroupPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.GroupRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.GroupRow.Options.UseFont = true;
            this.gridViewTasks.Appearance.GroupRow.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.GroupRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.GroupRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.GroupRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.HeaderPanel.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.HeaderPanel.ForeColor = System.Drawing.Color.Black;
            this.gridViewTasks.Appearance.HeaderPanel.Options.UseFont = true;
            this.gridViewTasks.Appearance.HeaderPanel.Options.UseForeColor = true;
            this.gridViewTasks.Appearance.HeaderPanel.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.HeaderPanel.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.HeaderPanel.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.HeaderPanel.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.HideSelectionRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.HideSelectionRow.Options.UseFont = true;
            this.gridViewTasks.Appearance.HideSelectionRow.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.HideSelectionRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.HideSelectionRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.HideSelectionRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.HorzLine.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.HorzLine.Options.UseFont = true;
            this.gridViewTasks.Appearance.HorzLine.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.HorzLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.HorzLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.HorzLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.HotTrackedRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.HotTrackedRow.Options.UseFont = true;
            this.gridViewTasks.Appearance.HotTrackedRow.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.HotTrackedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.HotTrackedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.HotTrackedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.NoSearchResults.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.NoSearchResults.Options.UseFont = true;
            this.gridViewTasks.Appearance.NoSearchResults.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.NoSearchResults.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.NoSearchResults.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.NoSearchResults.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.OddRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.OddRow.Options.UseFont = true;
            this.gridViewTasks.Appearance.OddRow.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.OddRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.OddRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.OddRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.Preview.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.Preview.Options.UseFont = true;
            this.gridViewTasks.Appearance.Preview.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.Preview.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.Preview.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.Preview.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.Row.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.Row.Options.UseFont = true;
            this.gridViewTasks.Appearance.Row.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.Row.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.Row.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.Row.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.RowSeparator.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.RowSeparator.Options.UseFont = true;
            this.gridViewTasks.Appearance.RowSeparator.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.RowSeparator.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.RowSeparator.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.RowSeparator.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.SelectedRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.SelectedRow.Options.UseFont = true;
            this.gridViewTasks.Appearance.SelectedRow.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.SelectedRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.SelectedRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.SelectedRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.TopNewRow.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.TopNewRow.Options.UseFont = true;
            this.gridViewTasks.Appearance.TopNewRow.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.TopNewRow.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.TopNewRow.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.TopNewRow.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.VertLine.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.VertLine.Options.UseFont = true;
            this.gridViewTasks.Appearance.VertLine.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.VertLine.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.VertLine.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.VertLine.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.Appearance.ViewCaption.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gridViewTasks.Appearance.ViewCaption.Options.UseFont = true;
            this.gridViewTasks.Appearance.ViewCaption.Options.UseTextOptions = true;
            this.gridViewTasks.Appearance.ViewCaption.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.gridViewTasks.Appearance.ViewCaption.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.gridViewTasks.Appearance.ViewCaption.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.gridViewTasks.GridControl = this.gridControlTasks;
            this.gridViewTasks.Name = "gridViewTasks";
            // 
            // pnBottom
            // 
            this.pnBottom.BackColor = System.Drawing.Color.SteelBlue;
            this.pnBottom.Controls.Add(this.btnToggleCompleted);
            this.pnBottom.Controls.Add(this.btnDeleteTask);
            this.pnBottom.Controls.Add(this.simpleButton1);
            this.pnBottom.Controls.Add(this.btnAddTask);
            this.pnBottom.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.pnBottom.Location = new System.Drawing.Point(0, 575);
            this.pnBottom.Name = "pnBottom";
            this.pnBottom.Size = new System.Drawing.Size(1200, 71);
            this.pnBottom.TabIndex = 10;
            // 
            // btnToggleCompleted
            // 
            this.btnToggleCompleted.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToggleCompleted.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnToggleCompleted.Appearance.Options.UseFont = true;
            this.btnToggleCompleted.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnToggleCompleted.ImageOptions.SvgImage")));
            this.btnToggleCompleted.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnToggleCompleted.Location = new System.Drawing.Point(178, 16);
            this.btnToggleCompleted.Name = "btnToggleCompleted";
            this.btnToggleCompleted.Size = new System.Drawing.Size(310, 38);
            this.btnToggleCompleted.TabIndex = 4;
            this.btnToggleCompleted.Text = "Mark / Unmark Completed";
            this.btnToggleCompleted.Click += new System.EventHandler(this.btnToggleCompleted_Click);
            // 
            // btnDeleteTask
            // 
            this.btnDeleteTask.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteTask.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnDeleteTask.Appearance.Options.UseFont = true;
            this.btnDeleteTask.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteTask.ImageOptions.SvgImage")));
            this.btnDeleteTask.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnDeleteTask.Location = new System.Drawing.Point(494, 16);
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
            this.simpleButton1.Location = new System.Drawing.Point(690, 16);
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
            this.btnAddTask.Location = new System.Drawing.Point(886, 16);
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
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "TaskManagerForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Task Manager";
            this.TopMost = true;
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboSortBy.Properties)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.comboDueDateFilter.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboSessionFilter.Properties)).EndInit();
            this.groupBox3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.checkShowCompleted.Properties)).EndInit();
            this.pnTop.ResumeLayout(false);
            this.pnFill.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridControlTasks)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridViewTasks)).EndInit();
            this.pnBottom.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Panel pnTop;
        private System.Windows.Forms.Panel pnFill;
        private System.Windows.Forms.Panel pnBottom;
        private DevExpress.XtraEditors.SimpleButton btnAddTask;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnDeleteTask;
        private DevExpress.XtraEditors.SimpleButton btnToggleCompleted;
        private DevExpress.XtraGrid.GridControl gridControlTasks;
        private DevExpress.XtraGrid.Views.Grid.GridView gridViewTasks;
        private DevExpress.XtraEditors.ComboBoxEdit comboSortBy;
        private DevExpress.XtraEditors.ComboBoxEdit comboDueDateFilter;
        private DevExpress.XtraEditors.ComboBoxEdit comboSessionFilter;
        private DevExpress.XtraEditors.CheckEdit checkShowCompleted;
    }
}