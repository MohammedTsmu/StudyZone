using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudyZone
{
    public partial class TaskEditForm : Form
    {
        private TaskItem task;
        private List<string> sessionNames;

        public TaskEditForm(TaskItem taskItem, List<string> sessions)
        {
            InitializeComponent();
            task = taskItem;
            sessionNames = sessions;

            cmbSessions.Items.AddRange(sessionNames.ToArray());
            LoadTask();
        }

        // Other methods will go here
        private void LoadTask()
        {
            txtTitle.Text = task.Title;
            txtDescription.Text = task.Description;
            if (task.DueDate.HasValue)
            {
                dtpDueDate.Value = task.DueDate.Value;
                dtpDueDate.Checked = true;
            }
            else
            {
                dtpDueDate.Checked = false;
            }
            if (!string.IsNullOrEmpty(task.SessionAssignment))
            {
                cmbSessions.SelectedItem = task.SessionAssignment;
            }
        }


        private void btnOK_Click(object sender, EventArgs e)
        {
            // Validate inputs
            if (string.IsNullOrWhiteSpace(txtTitle.Text))
            {
                MessageBox.Show("Please enter a task title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Update the task object
            task.Title = txtTitle.Text.Trim();
            task.Description = txtDescription.Text.Trim();
            if (dtpDueDate.Checked)
            {
                task.DueDate = dtpDueDate.Value;
            }
            else
            {
                task.DueDate = null;
            }
            if (cmbSessions.SelectedItem != null)
            {
                task.SessionAssignment = cmbSessions.SelectedItem.ToString();
            }
            else
            {
                task.SessionAssignment = null;
            }

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
