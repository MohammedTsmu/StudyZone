namespace StudyZone
{
    partial class ReminderEditForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtReminderName = new System.Windows.Forms.TextBox();
            this.dtpReminderTime = new System.Windows.Forms.DateTimePicker();
            this.chkIsRecurring = new System.Windows.Forms.CheckBox();
            this.chkIsEnabled = new System.Windows.Forms.CheckBox();
            this.btnOK = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 16);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reminder Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(16, 73);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 16);
            this.label2.TabIndex = 1;
            this.label2.Text = "Reminder Time";
            // 
            // txtReminderName
            // 
            this.txtReminderName.Location = new System.Drawing.Point(125, 40);
            this.txtReminderName.Name = "txtReminderName";
            this.txtReminderName.Size = new System.Drawing.Size(100, 22);
            this.txtReminderName.TabIndex = 2;
            // 
            // dtpReminderTime
            // 
            this.dtpReminderTime.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.dtpReminderTime.Location = new System.Drawing.Point(125, 73);
            this.dtpReminderTime.Name = "dtpReminderTime";
            this.dtpReminderTime.ShowUpDown = true;
            this.dtpReminderTime.Size = new System.Drawing.Size(200, 22);
            this.dtpReminderTime.TabIndex = 3;
            // 
            // chkIsRecurring
            // 
            this.chkIsRecurring.AutoSize = true;
            this.chkIsRecurring.Location = new System.Drawing.Point(19, 122);
            this.chkIsRecurring.Name = "chkIsRecurring";
            this.chkIsRecurring.Size = new System.Drawing.Size(121, 20);
            this.chkIsRecurring.TabIndex = 4;
            this.chkIsRecurring.Text = "Recurring Daily";
            this.chkIsRecurring.UseVisualStyleBackColor = true;
            // 
            // chkIsEnabled
            // 
            this.chkIsEnabled.AutoSize = true;
            this.chkIsEnabled.Location = new System.Drawing.Point(19, 149);
            this.chkIsEnabled.Name = "chkIsEnabled";
            this.chkIsEnabled.Size = new System.Drawing.Size(80, 20);
            this.chkIsEnabled.TabIndex = 5;
            this.chkIsEnabled.Text = "Enabled";
            this.chkIsEnabled.UseVisualStyleBackColor = true;
            // 
            // btnOK
            // 
            this.btnOK.Location = new System.Drawing.Point(19, 205);
            this.btnOK.Name = "btnOK";
            this.btnOK.Size = new System.Drawing.Size(75, 23);
            this.btnOK.TabIndex = 6;
            this.btnOK.Text = "OK";
            this.btnOK.UseVisualStyleBackColor = true;
            this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(101, 204);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // ReminderEditForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnOK);
            this.Controls.Add(this.chkIsEnabled);
            this.Controls.Add(this.chkIsRecurring);
            this.Controls.Add(this.dtpReminderTime);
            this.Controls.Add(this.txtReminderName);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "ReminderEditForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReminderEditForm";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtReminderName;
        private System.Windows.Forms.DateTimePicker dtpReminderTime;
        private System.Windows.Forms.CheckBox chkIsRecurring;
        private System.Windows.Forms.CheckBox chkIsEnabled;
        private System.Windows.Forms.Button btnOK;
        private System.Windows.Forms.Button btnCancel;
    }
}