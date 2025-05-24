using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudyZone
{
    public partial class ReminderManagerForm : Form
    {
        private List<StudyReminder> reminders;
        private Action saveRemindersToFile;

        public ReminderManagerForm(List<StudyReminder> remindersList, Action saveRemindersAction)
        {
            InitializeComponent();
            reminders = remindersList;
            saveRemindersToFile = saveRemindersAction;


            LoadReminders();
        }



        // Other methods will go here
        private void LoadReminders()
        {
            lstReminders.Items.Clear();
            foreach (var reminder in reminders)
            {
                lstReminders.Items.Add(reminder);
            }
        }

        
        private void btnAddReminder_Click(object sender, EventArgs e)
        {
            StudyReminder newReminder = new StudyReminder();
            ReminderEditForm editForm = new ReminderEditForm(newReminder);

            editForm.Text = "Add Reminder";
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                reminders.Add(newReminder);
                saveRemindersToFile();
                LoadReminders();
            }
        }

        private void btnEditReminder_Click(object sender, EventArgs e)
        {
            if (lstReminders.SelectedItem is StudyReminder selectedReminder)
            {
                ReminderEditForm editForm = new ReminderEditForm(selectedReminder);
                if (editForm.ShowDialog() == DialogResult.OK)
                {
                    saveRemindersToFile();
                    LoadReminders();
                }
            }
            else
            {
                MessageBox.Show("Please select a reminder to edit.", "Edit Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnDeleteReminder_Click(object sender, EventArgs e)
        {
            if (lstReminders.SelectedItem is StudyReminder selectedReminder)
            {
                var result = MessageBox.Show($"Are you sure you want to delete the reminder '{selectedReminder.ReminderName}'?", "Delete Reminder", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (result == DialogResult.Yes)
                {
                    reminders.Remove(selectedReminder);
                    saveRemindersToFile();
                    LoadReminders();
                }
            }
            else
            {
                MessageBox.Show("Please select a reminder to delete.", "Delete Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void btnToggleReminder_Click(object sender, EventArgs e)
        {
            if (lstReminders.SelectedItem is StudyReminder selectedReminder)
            {
                selectedReminder.IsEnabled = !selectedReminder.IsEnabled;
                saveRemindersToFile();
                LoadReminders();

                // Provide feedback to the user
                string status = selectedReminder.IsEnabled ? "enabled" : "disabled";
                MessageBox.Show($"Reminder '{selectedReminder.ReminderName}' is now {status}.", "Reminder Status", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a reminder to enable or disable.", "Toggle Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


    }
}
