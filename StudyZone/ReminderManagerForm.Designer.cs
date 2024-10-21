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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lstReminders
            // 
            this.lstReminders.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lstReminders.FormattingEnabled = true;
            this.lstReminders.ItemHeight = 24;
            this.lstReminders.Location = new System.Drawing.Point(12, 12);
            this.lstReminders.Name = "lstReminders";
            this.lstReminders.Size = new System.Drawing.Size(570, 412);
            this.lstReminders.TabIndex = 0;
            // 
            // btnAddReminder
            // 
            this.btnAddReminder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAddReminder.Location = new System.Drawing.Point(6, 21);
            this.btnAddReminder.Name = "btnAddReminder";
            this.btnAddReminder.Size = new System.Drawing.Size(188, 40);
            this.btnAddReminder.TabIndex = 1;
            this.btnAddReminder.Text = "Add Reminder";
            this.btnAddReminder.UseVisualStyleBackColor = true;
            this.btnAddReminder.Click += new System.EventHandler(this.btnAddReminder_Click);
            // 
            // btnEditReminder
            // 
            this.btnEditReminder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEditReminder.Location = new System.Drawing.Point(6, 67);
            this.btnEditReminder.Name = "btnEditReminder";
            this.btnEditReminder.Size = new System.Drawing.Size(188, 40);
            this.btnEditReminder.TabIndex = 2;
            this.btnEditReminder.Text = "Edit Reminder";
            this.btnEditReminder.UseVisualStyleBackColor = true;
            this.btnEditReminder.Click += new System.EventHandler(this.btnEditReminder_Click);
            // 
            // btnDeleteReminder
            // 
            this.btnDeleteReminder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDeleteReminder.Location = new System.Drawing.Point(6, 113);
            this.btnDeleteReminder.Name = "btnDeleteReminder";
            this.btnDeleteReminder.Size = new System.Drawing.Size(188, 40);
            this.btnDeleteReminder.TabIndex = 3;
            this.btnDeleteReminder.Text = "Delete Reminder";
            this.btnDeleteReminder.UseVisualStyleBackColor = true;
            this.btnDeleteReminder.Click += new System.EventHandler(this.btnDeleteReminder_Click);
            // 
            // btnToggleReminder
            // 
            this.btnToggleReminder.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnToggleReminder.Location = new System.Drawing.Point(6, 159);
            this.btnToggleReminder.Name = "btnToggleReminder";
            this.btnToggleReminder.Size = new System.Drawing.Size(188, 40);
            this.btnToggleReminder.TabIndex = 4;
            this.btnToggleReminder.Text = "Toggle Reminder";
            this.btnToggleReminder.UseVisualStyleBackColor = true;
            this.btnToggleReminder.Click += new System.EventHandler(this.btnToggleReminder_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnToggleReminder);
            this.groupBox1.Controls.Add(this.btnAddReminder);
            this.groupBox1.Controls.Add(this.btnDeleteReminder);
            this.groupBox1.Controls.Add(this.btnEditReminder);
            this.groupBox1.Location = new System.Drawing.Point(588, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 400);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Action";
            // 
            // ReminderManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 439);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lstReminders);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ReminderManagerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Reminder Manager";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lstReminders;
        private System.Windows.Forms.Button btnAddReminder;
        private System.Windows.Forms.Button btnEditReminder;
        private System.Windows.Forms.Button btnDeleteReminder;
        private System.Windows.Forms.Button btnToggleReminder;
        private System.Windows.Forms.GroupBox groupBox1;
    }
}