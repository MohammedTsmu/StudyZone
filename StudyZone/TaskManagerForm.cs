using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace StudyZone
{
    public partial class TaskManagerForm : Form
    {
        private List<TaskItem> tasks;
        private Action saveTasksToFile;
        private List<StudySession> sessions;

        public TaskManagerForm(List<TaskItem> tasksList, Action saveTasksAction, List<StudySession> sessionsList)
        {
            InitializeComponent();
            tasks = tasksList;
            saveTasksToFile = saveTasksAction;
            sessions = sessionsList;

            // Attach event handlers
            dataGridViewTasks.DataBindingComplete += DataGridViewTasks_DataBindingComplete;
            chkShowCompleted.CheckedChanged += chkShowCompleted_CheckedChanged;

            //Sorting
            //Initialize cmbSortBy in the Constructor:
            cmbSortBy.Items.AddRange(new string[] { "Title", "Due Date", "Status" });
            cmbSortBy.SelectedIndex = 0; // Default to 'Title'

            

            LoadTasks();
        }

        
        private void btnAddTask_Click(object sender, EventArgs e)
        {
            TaskItem newTask = new TaskItem();
            TaskEditForm editForm = new TaskEditForm(newTask, GetSessionNames());
            if (editForm.ShowDialog() == DialogResult.OK)
            {
                tasks.Add(newTask);
                saveTasksToFile();
                LoadTasks();
            }
        }


        private void btnEditTask_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.CurrentRow != null)
            {
                var selectedTask = dataGridViewTasks.CurrentRow.DataBoundItem as TaskItem;
                if (selectedTask != null)
                {
                    TaskEditForm editForm = new TaskEditForm(selectedTask, GetSessionNames());
                    if (editForm.ShowDialog() == DialogResult.OK)
                    {
                        saveTasksToFile();
                        LoadTasks();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a task to edit.", "Edit Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnDeleteTask_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.CurrentRow != null)
            {
                var selectedTask = dataGridViewTasks.CurrentRow.DataBoundItem as TaskItem;
                if (selectedTask != null)
                {
                    var result = MessageBox.Show($"Are you sure you want to delete the task '{selectedTask.Title}'?", "Delete Task", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        tasks.Remove(selectedTask);
                        saveTasksToFile();
                        LoadTasks();
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a task to delete.", "Delete Task", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void btnMarkCompleted_Click(object sender, EventArgs e)
        {
            if (dataGridViewTasks.CurrentRow != null)
            {
                var selectedTask = dataGridViewTasks.CurrentRow.DataBoundItem as TaskItem;
                if (selectedTask != null)
                {
                    selectedTask.IsCompleted = true;
                    saveTasksToFile();
                    LoadTasks();
                }
            }
            else
            {
                MessageBox.Show("Please select a task to mark as completed.", "Mark as Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        private void chkShowCompleted_CheckedChanged(object sender, EventArgs e)
        {
            LoadTasks();
        }


        //private void DataGridViewTasks_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        //{

        //}

        // Other methods will go here
        //private void LoadTasks()
        //{
        //    // Apply filters
        //    List<TaskItem> displayedTasks = new List<TaskItem>();
        //    foreach (var task in tasks)
        //    {
        //        if (!chkShowCompleted.Checked && task.IsCompleted)
        //            continue;
        //        displayedTasks.Add(task);
        //    }

        //    dataGridViewTasks.DataSource = null;
        //    dataGridViewTasks.DataSource = displayedTasks;
        //}
        private void LoadTasks()
        {
            // Apply filters
            List<TaskItem> displayedTasks = new List<TaskItem>();
            foreach (var task in tasks)
            {
                if (!chkShowCompleted.Checked && task.IsCompleted)
                    continue;
                displayedTasks.Add(task);
            }

            // Apply sorting
            switch (cmbSortBy.SelectedItem as string)
            {
                case "Title":
                    displayedTasks.Sort((x, y) => x.Title.CompareTo(y.Title));
                    break;
                case "Due Date":
                    displayedTasks.Sort((x, y) => Nullable.Compare(x.DueDate, y.DueDate));
                    break;
                case "Status":
                    displayedTasks.Sort((x, y) => x.IsCompleted.CompareTo(y.IsCompleted));
                    break;
            }

            dataGridViewTasks.DataSource = null;
            dataGridViewTasks.DataSource = displayedTasks;
        }


        private void DataGridViewTasks_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Adjust column headers and formatting
            dataGridViewTasks.Columns["Title"].HeaderText = "Task Title";
            dataGridViewTasks.Columns["DueDate"].HeaderText = "Due Date";
            dataGridViewTasks.Columns["IsCompleted"].HeaderText = "Completed";
            dataGridViewTasks.Columns["SessionAssignment"].HeaderText = "Assigned Session";

            dataGridViewTasks.Columns["Description"].Visible = false; // Hide description column in grid

            // Format the DueDate column
            dataGridViewTasks.Columns["DueDate"].DefaultCellStyle.Format = "d"; // Short date pattern
        }

        private List<string> GetSessionNames()
        {
            List<string> sessionNames = new List<string>();
            foreach (var session in sessions)
            {
                sessionNames.Add(session.SessionName);
            }
            return sessionNames;
        }

        //private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        //{

        //}
        private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTasks();
        }
    }
}