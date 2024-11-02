namespace StudyZone
{
    partial class SettingsForm
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
            this.groupBoxPauseReminders = new System.Windows.Forms.GroupBox();
            this.chkEnablePauseReminders = new System.Windows.Forms.CheckBox();
            this.lblReminderThreshold = new System.Windows.Forms.Label();
            this.nudReminderThreshold = new System.Windows.Forms.NumericUpDown();
            this.lblReminderInterval = new System.Windows.Forms.Label();
            this.nudReminderInterval = new System.Windows.Forms.NumericUpDown();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBoxPauseReminders.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReminderThreshold)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReminderInterval)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBoxPauseReminders
            // 
            this.groupBoxPauseReminders.Controls.Add(this.btnCancel);
            this.groupBoxPauseReminders.Controls.Add(this.btnSave);
            this.groupBoxPauseReminders.Controls.Add(this.nudReminderInterval);
            this.groupBoxPauseReminders.Controls.Add(this.lblReminderInterval);
            this.groupBoxPauseReminders.Controls.Add(this.nudReminderThreshold);
            this.groupBoxPauseReminders.Controls.Add(this.lblReminderThreshold);
            this.groupBoxPauseReminders.Controls.Add(this.chkEnablePauseReminders);
            this.groupBoxPauseReminders.Location = new System.Drawing.Point(13, 13);
            this.groupBoxPauseReminders.Name = "groupBoxPauseReminders";
            this.groupBoxPauseReminders.Size = new System.Drawing.Size(775, 425);
            this.groupBoxPauseReminders.TabIndex = 0;
            this.groupBoxPauseReminders.TabStop = false;
            this.groupBoxPauseReminders.Text = "Pause Reminder Settings";
            // 
            // chkEnablePauseReminders
            // 
            this.chkEnablePauseReminders.AutoSize = true;
            this.chkEnablePauseReminders.Location = new System.Drawing.Point(7, 22);
            this.chkEnablePauseReminders.Name = "chkEnablePauseReminders";
            this.chkEnablePauseReminders.Size = new System.Drawing.Size(183, 20);
            this.chkEnablePauseReminders.TabIndex = 0;
            this.chkEnablePauseReminders.Text = "Enable Pause Reminders";
            this.chkEnablePauseReminders.UseVisualStyleBackColor = true;
            this.chkEnablePauseReminders.CheckedChanged += new System.EventHandler(this.chkEnablePauseReminders_CheckedChanged);
            // 
            // lblReminderThreshold
            // 
            this.lblReminderThreshold.AutoSize = true;
            this.lblReminderThreshold.Location = new System.Drawing.Point(7, 49);
            this.lblReminderThreshold.Name = "lblReminderThreshold";
            this.lblReminderThreshold.Size = new System.Drawing.Size(190, 16);
            this.lblReminderThreshold.TabIndex = 1;
            this.lblReminderThreshold.Text = "Reminder Threshold (minutes):";
            // 
            // nudReminderThreshold
            // 
            this.nudReminderThreshold.Location = new System.Drawing.Point(7, 69);
            this.nudReminderThreshold.Maximum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.nudReminderThreshold.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.nudReminderThreshold.Name = "nudReminderThreshold";
            this.nudReminderThreshold.Size = new System.Drawing.Size(120, 22);
            this.nudReminderThreshold.TabIndex = 2;
            this.nudReminderThreshold.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // lblReminderInterval
            // 
            this.lblReminderInterval.AutoSize = true;
            this.lblReminderInterval.Location = new System.Drawing.Point(7, 98);
            this.lblReminderInterval.Name = "lblReminderInterval";
            this.lblReminderInterval.Size = new System.Drawing.Size(172, 16);
            this.lblReminderInterval.TabIndex = 3;
            this.lblReminderInterval.Text = "Reminder Interval (minutes):";
            // 
            // nudReminderInterval
            // 
            this.nudReminderInterval.Location = new System.Drawing.Point(7, 118);
            this.nudReminderInterval.Maximum = new decimal(new int[] {
            30,
            0,
            0,
            0});
            this.nudReminderInterval.Minimum = new decimal(new int[] {
            2,
            0,
            0,
            0});
            this.nudReminderInterval.Name = "nudReminderInterval";
            this.nudReminderInterval.Size = new System.Drawing.Size(120, 22);
            this.nudReminderInterval.TabIndex = 4;
            this.nudReminderInterval.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(7, 147);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(7, 177);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 6;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // SettingsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBoxPauseReminders);
            this.Name = "SettingsForm";
            this.Text = "Settings";
            this.groupBoxPauseReminders.ResumeLayout(false);
            this.groupBoxPauseReminders.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.nudReminderThreshold)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.nudReminderInterval)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBoxPauseReminders;
        private System.Windows.Forms.NumericUpDown nudReminderThreshold;
        private System.Windows.Forms.Label lblReminderThreshold;
        private System.Windows.Forms.CheckBox chkEnablePauseReminders;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.NumericUpDown nudReminderInterval;
        private System.Windows.Forms.Label lblReminderInterval;
    }
}