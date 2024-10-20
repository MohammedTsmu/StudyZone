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
            this.lstReminders = new System.Windows.Forms.ListBox();
            this.btnAddReminder = new System.Windows.Forms.Button();
            this.btnEditReminder = new System.Windows.Forms.Button();
            this.btnDeleteReminder = new System.Windows.Forms.Button();
            this.btnToggleReminder = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lstReminders
            // 
            this.lstReminders.FormattingEnabled = true;
            this.lstReminders.ItemHeight = 16;
            this.lstReminders.Location = new System.Drawing.Point(46, 33);
            this.lstReminders.Name = "lstReminders";
            this.lstReminders.Size = new System.Drawing.Size(303, 340);
            this.lstReminders.TabIndex = 0;
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.Location = new System.Drawing.Point(388, 33);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(144, 23);
            this.btnAddReminder.TabIndex = 1;
            this.btnAddReminder.Text = "Add Reminder";
            this.btnAddReminder.UseVisualStyleBackColor = true;
            this.btnAddReminder.Click += new System.EventHandler(this.btnAddReminder_Click);
            // 
            // btnEditReminder
            // 
            this.btnEditReminder.Location = new System.Drawing.Point(388, 62);
            this.btnEditReminder.Name = "btnEditReminder";
            this.btnEditReminder.Size = new System.Drawing.Size(144, 23);
            this.btnEditReminder.TabIndex = 2;
            this.btnEditReminder.Text = "Edit Reminder";
            this.btnEditReminder.UseVisualStyleBackColor = true;
            this.btnEditReminder.Click += new System.EventHandler(this.btnEditReminder_Click);
            // 
            // btnDeleteReminder
            // 
            this.btnDeleteReminder.Location = new System.Drawing.Point(388, 91);
            this.btnDeleteReminder.Name = "btnDeleteReminder";
            this.btnDeleteReminder.Size = new System.Drawing.Size(144, 23);
            this.btnDeleteReminder.TabIndex = 3;
            this.btnDeleteReminder.Text = "Delete Reminder";
            this.btnDeleteReminder.UseVisualStyleBackColor = true;
            this.btnDeleteReminder.Click += new System.EventHandler(this.btnDeleteReminder_Click);
            // 
            // btnToggleReminder
            // 
            this.btnToggleReminder.Location = new System.Drawing.Point(388, 120);
            this.btnToggleReminder.Name = "btnToggleReminder";
            this.btnToggleReminder.Size = new System.Drawing.Size(144, 23);
            this.btnToggleReminder.TabIndex = 4;
            this.btnToggleReminder.Text = "Toggle Reminder";
            this.btnToggleReminder.UseVisualStyleBackColor = true;
            this.btnToggleReminder.Click += new System.EventHandler(this.btnToggleReminder_Click);
            // 
            // ReminderManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnToggleReminder);
            this.Controls.Add(this.btnDeleteReminder);
            this.Controls.Add(this.btnEditReminder);
            this.Controls.Add(this.btnAddReminder);
            this.Controls.Add(this.lstReminders);
            this.Name = "ReminderManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReminderManagerForm";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstReminders;
        private System.Windows.Forms.Button btnAddReminder;
        private System.Windows.Forms.Button btnEditReminder;
        private System.Windows.Forms.Button btnDeleteReminder;
        private System.Windows.Forms.Button btnToggleReminder;
    }
}