//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Data;
//using System.Drawing;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;
//using System.Windows.Forms;

//namespace StudyZone
//{
//    public partial class ReminderEditForm : Form
//    {
//        public ReminderEditForm()
//        {
//            InitializeComponent();
//        }
//    }
//}

using System;
using System.Windows.Forms;

namespace StudyZone
{
    public partial class ReminderEditForm : Form
    {
        private StudyReminder reminder;

        public ReminderEditForm(StudyReminder reminderItem)
        {
            InitializeComponent();
            reminder = reminderItem;
            LoadReminder();
        }

        // Other methods will go here
        private void LoadReminder()
        {
            txtReminderName.Text = reminder.ReminderName;
            dtpReminderTime.Value = DateTime.Today.Add(reminder.ReminderTime.TimeOfDay);
            chkIsRecurring.Checked = reminder.IsRecurring;
            chkIsEnabled.Checked = reminder.IsEnabled;
        }

        private void btnOK_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtReminderName.Text))
            {
                MessageBox.Show("Please enter a reminder name.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update the reminder object
            reminder.ReminderName = txtReminderName.Text.Trim();
            reminder.ReminderTime = DateTime.Today.Add(dtpReminderTime.Value.TimeOfDay);
            reminder.IsRecurring = chkIsRecurring.Checked;
            reminder.IsEnabled = chkIsEnabled.Checked;

            this.DialogResult = DialogResult.OK;
            this.Close();
        }


        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }

    }
}
