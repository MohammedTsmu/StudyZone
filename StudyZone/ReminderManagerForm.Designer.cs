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
            this.lstReminders = new System.Windows.Forms.ListBox();
            this.btnAddReminder = new System.Windows.Forms.Button();
            this.btnEditReminder = new System.Windows.Forms.Button();
            this.btnDeleteReminder = new System.Windows.Forms.Button();
            this.btnToggleReminder = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstReminders
            // 
            this.lstReminders.Dock = System.Windows.Forms.DockStyle.Fill;
            this.lstReminders.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstReminders.FormattingEnabled = true;
            this.lstReminders.ItemHeight = 23;
            this.lstReminders.Location = new System.Drawing.Point(0, 0);
            this.lstReminders.Name = "lstReminders";
            this.lstReminders.ScrollAlwaysVisible = true;
            this.lstReminders.Size = new System.Drawing.Size(638, 506);
            this.lstReminders.TabIndex = 0;
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAddReminder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReminder.Image = global::StudyZone.Properties.Resources.Add;
            this.btnAddReminder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnAddReminder.Location = new System.Drawing.Point(36, 64);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(250, 90);
            this.btnAddReminder.TabIndex = 1;
            this.btnAddReminder.Text = "Add Reminder";
            this.btnAddReminder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnAddReminder.UseVisualStyleBackColor = true;
            this.btnAddReminder.Click += new System.EventHandler(this.btnAddReminder_Click);
            // 
            // btnEditReminder
            // 
            this.btnEditReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEditReminder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditReminder.Image = global::StudyZone.Properties.Resources.Edit_Text_File;
            this.btnEditReminder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEditReminder.Location = new System.Drawing.Point(36, 160);
            this.btnEditReminder.Name = "btnEditReminder";
            this.btnEditReminder.Size = new System.Drawing.Size(250, 90);
            this.btnEditReminder.TabIndex = 2;
            this.btnEditReminder.Text = "Edit Reminder";
            this.btnEditReminder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEditReminder.UseVisualStyleBackColor = true;
            this.btnEditReminder.Click += new System.EventHandler(this.btnEditReminder_Click);
            // 
            // btnDeleteReminder
            // 
            this.btnDeleteReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnDeleteReminder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReminder.Image = global::StudyZone.Properties.Resources.Delete;
            this.btnDeleteReminder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnDeleteReminder.Location = new System.Drawing.Point(36, 256);
            this.btnDeleteReminder.Name = "btnDeleteReminder";
            this.btnDeleteReminder.Size = new System.Drawing.Size(250, 90);
            this.btnDeleteReminder.TabIndex = 3;
            this.btnDeleteReminder.Text = "Delete Reminder";
            this.btnDeleteReminder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnDeleteReminder.UseVisualStyleBackColor = true;
            this.btnDeleteReminder.Click += new System.EventHandler(this.btnDeleteReminder_Click);
            // 
            // btnToggleReminder
            // 
            this.btnToggleReminder.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnToggleReminder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleReminder.Image = global::StudyZone.Properties.Resources.Toggle_On;
            this.btnToggleReminder.ImageAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnToggleReminder.Location = new System.Drawing.Point(36, 352);
            this.btnToggleReminder.Name = "btnToggleReminder";
            this.btnToggleReminder.Size = new System.Drawing.Size(250, 90);
            this.btnToggleReminder.TabIndex = 4;
            this.btnToggleReminder.Text = "Toggle Reminder";
            this.btnToggleReminder.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnToggleReminder.UseVisualStyleBackColor = true;
            this.btnToggleReminder.Click += new System.EventHandler(this.btnToggleReminder_Click);
            // 
            // panel1
            // 
            this.panel1.AutoScroll = true;
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.panel1.Controls.Add(this.btnToggleReminder);
            this.panel1.Controls.Add(this.btnAddReminder);
            this.panel1.Controls.Add(this.btnEditReminder);
            this.panel1.Controls.Add(this.btnDeleteReminder);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(322, 506);
            this.panel1.TabIndex = 6;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.ControlDark;
            this.panel2.Controls.Add(this.lstReminders);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel2.Location = new System.Drawing.Point(322, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(638, 506);
            this.panel2.TabIndex = 7;
            // 
            // ReminderManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(960, 506);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReminderManagerForm";
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder Manager";
            this.panel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstReminders;
        private System.Windows.Forms.Button btnAddReminder;
        private System.Windows.Forms.Button btnEditReminder;
        private System.Windows.Forms.Button btnDeleteReminder;
        private System.Windows.Forms.Button btnToggleReminder;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
    }
}