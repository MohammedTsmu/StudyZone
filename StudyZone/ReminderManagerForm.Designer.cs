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
            this.lstReminders = new System.Windows.Forms.ListBox();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.panel1.Controls.Add(this.btnToggleReminder);
            this.panel1.Controls.Add(this.btnDeleteReminder);
            this.panel1.Controls.Add(this.btnEditReminder);
            this.panel1.Controls.Add(this.btnAddReminder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(20, 532);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(920, 68);
            this.panel1.TabIndex = 999;
            this.panel1.TabStop = true;
            // 
            // btnToggleReminder
            // 
            this.btnToggleReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToggleReminder.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnToggleReminder.Appearance.Options.UseFont = true;
            this.btnToggleReminder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnToggleReminder.ImageOptions.SvgImage")));
            this.btnToggleReminder.Location = new System.Drawing.Point(48, 9);
            this.btnToggleReminder.Name = "btnToggleReminder";
            this.btnToggleReminder.Size = new System.Drawing.Size(200, 50);
            this.btnToggleReminder.TabIndex = 4;
            this.btnToggleReminder.Text = "Toggle On/Off";
            this.btnToggleReminder.Click += new System.EventHandler(this.btnToggleReminder_Click);
            // 
            // btnDeleteReminder
            // 
            this.btnDeleteReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteReminder.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnDeleteReminder.Appearance.Options.UseFont = true;
            this.btnDeleteReminder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnDeleteReminder.ImageOptions.SvgImage")));
            this.btnDeleteReminder.Location = new System.Drawing.Point(256, 9);
            this.btnDeleteReminder.Name = "btnDeleteReminder";
            this.btnDeleteReminder.Size = new System.Drawing.Size(200, 50);
            this.btnDeleteReminder.TabIndex = 3;
            this.btnDeleteReminder.Text = "Delete";
            this.btnDeleteReminder.Click += new System.EventHandler(this.btnDeleteReminder_Click);
            // 
            // btnEditReminder
            // 
            this.btnEditReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditReminder.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnEditReminder.Appearance.Options.UseFont = true;
            this.btnEditReminder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnEditReminder.ImageOptions.SvgImage")));
            this.btnEditReminder.Location = new System.Drawing.Point(464, 9);
            this.btnEditReminder.Name = "btnEditReminder";
            this.btnEditReminder.Size = new System.Drawing.Size(200, 50);
            this.btnEditReminder.TabIndex = 2;
            this.btnEditReminder.Text = "Edit";
            this.btnEditReminder.Click += new System.EventHandler(this.btnEditReminder_Click);
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddReminder.Appearance.Font = new System.Drawing.Font("Arial", 11F, System.Drawing.FontStyle.Bold);
            this.btnAddReminder.Appearance.Options.UseFont = true;
            this.btnAddReminder.ImageOptions.SvgImage = ((DevExpress.Utils.Svg.SvgImage)(resources.GetObject("btnAddReminder.ImageOptions.SvgImage")));
            this.btnAddReminder.Location = new System.Drawing.Point(672, 9);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(200, 50);
            this.btnAddReminder.TabIndex = 1;
            this.btnAddReminder.Text = "Add";
            this.btnAddReminder.Click += new System.EventHandler(this.btnAddReminder_Click);
            // 
            // lstReminders
            // 
            this.lstReminders.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.lstReminders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstReminders.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstReminders.FormattingEnabled = true;
            this.lstReminders.ItemHeight = 24;
            this.lstReminders.Location = new System.Drawing.Point(20, 20);
            this.lstReminders.Name = "lstReminders";
            this.lstReminders.ScrollAlwaysVisible = true;
            this.lstReminders.Size = new System.Drawing.Size(920, 512);
            this.lstReminders.TabIndex = 5;
            // 
            // ReminderManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 620);
            this.Controls.Add(this.lstReminders);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReminderManagerForm";
            this.Padding = new System.Windows.Forms.Padding(20);
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder Manager";
            this.TopMost = true;
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel1;
        private DevExpress.XtraEditors.SimpleButton btnAddReminder;
        private DevExpress.XtraEditors.SimpleButton btnEditReminder;
        private DevExpress.XtraEditors.SimpleButton btnDeleteReminder;
        private DevExpress.XtraEditors.SimpleButton btnToggleReminder;
        private System.Windows.Forms.ListBox lstReminders;
    }
}