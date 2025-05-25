namespace StudyZone
{
    partial class ReminderManagerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReminderManagerForm));
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnToggleReminder = new DevExpress.XtraEditors.SimpleButton();
            this.btnDeleteReminder = new DevExpress.XtraEditors.SimpleButton();
            this.btnEditReminder = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddReminder = new DevExpress.XtraEditors.SimpleButton();
            this.listBoxReminders = new DevExpress.XtraEditors.ListBoxControl();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.listBoxReminders)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.SteelBlue;
            this.panel1.Controls.Add(this.btnToggleReminder);
            this.panel1.Controls.Add(this.btnDeleteReminder);
            this.panel1.Controls.Add(this.btnEditReminder);
            this.panel1.Controls.Add(this.btnAddReminder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(5, 555);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(843, 60);
            this.panel1.TabIndex = 999;
            this.panel1.TabStop = true;
            // 
            // btnToggleReminder
            // 
            this.btnToggleReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToggleReminder.Appearance.Font = new System.Drawing.Font("LBC", 12F);
            this.btnToggleReminder.Appearance.Options.UseFont = true;
            this.btnToggleReminder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnToggleReminder.ImageOptions.SvgImage")));
            this.btnToggleReminder.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnToggleReminder.Location = new System.Drawing.Point(32, 11);
            this.btnToggleReminder.Name = "btnToggleReminder";
            this.btnToggleReminder.Size = new System.Drawing.Size(190, 38);
            this.btnToggleReminder.TabIndex = 4;
            this.btnToggleReminder.Text = "Toggle On/Off";
            this.btnToggleReminder.Click += new System.EventHandler(this.btnToggleReminder_Click);
            // 
            // btnDeleteReminder
            // 
            this.btnDeleteReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteReminder.Appearance.Font = new System.Drawing.Font("LBC", 12F);
            this.btnDeleteReminder.Appearance.Options.UseFont = true;
            this.btnDeleteReminder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteReminder.ImageOptions.SvgImage")));
            this.btnDeleteReminder.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnDeleteReminder.Location = new System.Drawing.Point(228, 11);
            this.btnDeleteReminder.Name = "btnDeleteReminder";
            this.btnDeleteReminder.Size = new System.Drawing.Size(190, 38);
            this.btnDeleteReminder.TabIndex = 3;
            this.btnDeleteReminder.Text = "Delete";
            this.btnDeleteReminder.Click += new System.EventHandler(this.btnDeleteReminder_Click);
            // 
            // btnEditReminder
            // 
            this.btnEditReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditReminder.Appearance.Font = new System.Drawing.Font("LBC", 12F);
            this.btnEditReminder.Appearance.Options.UseFont = true;
            this.btnEditReminder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEditReminder.ImageOptions.SvgImage")));
            this.btnEditReminder.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnEditReminder.Location = new System.Drawing.Point(424, 11);
            this.btnEditReminder.Name = "btnEditReminder";
            this.btnEditReminder.Size = new System.Drawing.Size(190, 38);
            this.btnEditReminder.TabIndex = 2;
            this.btnEditReminder.Text = "Edit";
            this.btnEditReminder.Click += new System.EventHandler(this.btnEditReminder_Click);
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddReminder.Appearance.Font = new System.Drawing.Font("LBC", 12F);
            this.btnAddReminder.Appearance.Options.UseFont = true;
            this.btnAddReminder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddReminder.ImageOptions.SvgImage")));
            this.btnAddReminder.ImageOptions.SvgImageSize = new System.Drawing.Size(25, 25);
            this.btnAddReminder.Location = new System.Drawing.Point(620, 11);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(190, 38);
            this.btnAddReminder.TabIndex = 1;
            this.btnAddReminder.Text = "Add";
            this.btnAddReminder.Click += new System.EventHandler(this.btnAddReminder_Click);
            // 
            // listBoxReminders
            // 
            this.listBoxReminders.Appearance.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxReminders.Appearance.Font = new System.Drawing.Font("LBC", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(178)));
            this.listBoxReminders.Appearance.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxReminders.Appearance.Options.UseBackColor = true;
            this.listBoxReminders.Appearance.Options.UseFont = true;
            this.listBoxReminders.Appearance.Options.UseForeColor = true;
            this.listBoxReminders.Appearance.Options.UseTextOptions = true;
            this.listBoxReminders.Appearance.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.listBoxReminders.Appearance.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.listBoxReminders.Appearance.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.listBoxReminders.AppearanceDisabled.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxReminders.AppearanceDisabled.Font = new System.Drawing.Font("LBC", 12F);
            this.listBoxReminders.AppearanceDisabled.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxReminders.AppearanceDisabled.Options.UseBackColor = true;
            this.listBoxReminders.AppearanceDisabled.Options.UseFont = true;
            this.listBoxReminders.AppearanceDisabled.Options.UseForeColor = true;
            this.listBoxReminders.AppearanceDisabled.Options.UseTextOptions = true;
            this.listBoxReminders.AppearanceDisabled.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.listBoxReminders.AppearanceDisabled.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.listBoxReminders.AppearanceDisabled.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.listBoxReminders.AppearanceHighlight.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxReminders.AppearanceHighlight.Font = new System.Drawing.Font("LBC", 12F);
            this.listBoxReminders.AppearanceHighlight.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxReminders.AppearanceHighlight.Options.UseBackColor = true;
            this.listBoxReminders.AppearanceHighlight.Options.UseFont = true;
            this.listBoxReminders.AppearanceHighlight.Options.UseForeColor = true;
            this.listBoxReminders.AppearanceHighlight.Options.UseTextOptions = true;
            this.listBoxReminders.AppearanceHighlight.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.listBoxReminders.AppearanceHighlight.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.listBoxReminders.AppearanceHighlight.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.listBoxReminders.AppearanceSelected.BackColor = System.Drawing.Color.WhiteSmoke;
            this.listBoxReminders.AppearanceSelected.Font = new System.Drawing.Font("LBC", 12F);
            this.listBoxReminders.AppearanceSelected.ForeColor = System.Drawing.Color.DarkSlateGray;
            this.listBoxReminders.AppearanceSelected.Options.UseBackColor = true;
            this.listBoxReminders.AppearanceSelected.Options.UseFont = true;
            this.listBoxReminders.AppearanceSelected.Options.UseForeColor = true;
            this.listBoxReminders.AppearanceSelected.Options.UseTextOptions = true;
            this.listBoxReminders.AppearanceSelected.TextOptions.HAlignment = DevExpress.Utils.HorzAlignment.Center;
            this.listBoxReminders.AppearanceSelected.TextOptions.VAlignment = DevExpress.Utils.VertAlignment.Center;
            this.listBoxReminders.AppearanceSelected.TextOptions.WordWrap = DevExpress.Utils.WordWrap.Wrap;
            this.listBoxReminders.Cursor = System.Windows.Forms.Cursors.Hand;
            this.listBoxReminders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listBoxReminders.HotTrackItems = true;
            this.listBoxReminders.HotTrackSelectMode = DevExpress.XtraEditors.HotTrackSelectMode.SelectItemOnClick;
            this.listBoxReminders.ItemPadding = new System.Windows.Forms.Padding(5);
            this.listBoxReminders.Location = new System.Drawing.Point(5, 5);
            this.listBoxReminders.Name = "listBoxReminders";
            this.listBoxReminders.Size = new System.Drawing.Size(843, 550);
            this.listBoxReminders.TabIndex = 1000;
            // 
            // ReminderManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(853, 620);
            this.Controls.Add(this.listBoxReminders);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ReminderManagerForm";
            this.Padding = new System.Windows.Forms.Padding(5);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder Manager";
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.listBoxReminders)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnAddReminder;
        private DevExpress.XtraEditors.SimpleButton btnEditReminder;
        private DevExpress.XtraEditors.SimpleButton btnDeleteReminder;
        private DevExpress.XtraEditors.SimpleButton btnToggleReminder;
        private DevExpress.XtraEditors.ListBoxControl listBoxReminders;
    }
}