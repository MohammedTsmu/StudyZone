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

            // Initialize session filter
            cmbSessionFilter.Items.Add("All Sessions");
            foreach (var session in sessions)
            {
                cmbSessionFilter.Items.Add(session.SessionName);
            }
            cmbSessionFilter.SelectedIndex = 0; // Default to 'All Sessions'

            // Initialize due date filter
            cmbDueDateFilter.Items.AddRange(new string[] { "Any Time", "Today", "This Week", "This Month", "Overdue" });
            cmbDueDateFilter.SelectedIndex = 0; // Default to 'Any Time'

            // Initialize sorting ComboBox
            cmbSortBy.Items.AddRange(new string[] { "Title", "Due Date", "Status" });
            cmbSortBy.SelectedIndex = 0; // Default to 'Title'

            // Attach event handlers AFTER initialization
            chkShowCompleted.CheckedChanged += chkShowCompleted_CheckedChanged;
            cmbSortBy.SelectedIndexChanged += cmbSortBy_SelectedIndexChanged;
            cmbSessionFilter.SelectedIndexChanged += cmbSessionFilter_SelectedIndexChanged;
            cmbDueDateFilter.SelectedIndexChanged += cmbDueDateFilter_SelectedIndexChanged;

            dataGridViewTasks.DataBindingComplete += DataGridViewTasks_DataBindingComplete;
            LoadTasks();
        }




        private void btnAddTask_Click(object sender, EventArgs e)
        {
            TaskItem newTask = new TaskItem();
            TaskEditForm editForm = new TaskEditForm(newTask, GetSessionNames());
            editForm.Text = "Add New Task";
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

        

        private void LoadTasks()
        {
            // Apply filters
            List<TaskItem> displayedTasks = new List<TaskItem>();

            string sessionFilter = cmbSessionFilter.SelectedItem as string ?? "All Sessions";
            string dueDateFilter = cmbDueDateFilter.SelectedItem as string ?? "Any Time";

            foreach (var task in tasks)
            {
                // Filter by completion status
                if (!chkShowCompleted.Checked && task.IsCompleted)
                    continue;

                // Filter by session assignment
                if (sessionFilter != "All Sessions")
                {
                    if (task.SessionAssignment != sessionFilter)
                        continue;
                }

                // Filter by due date
                if (!IsTaskWithinDueDateFilter(task, dueDateFilter))
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
                default:
                    // Default sorting if none selected
                    break;
            }

            dataGridViewTasks.DataSource = null;
            dataGridViewTasks.DataSource = displayedTasks;
        }




        private void DataGridViewTasks_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Adjust column headers and formatting
            dataGridViewTasks.Columns["Title"].HeaderText = "Task Title";
            dataGridViewTasks.Columns["Title"].Width = 250;
            dataGridViewTasks.Columns["DueDate"].HeaderText = "Due Date";
            dataGridViewTasks.Columns["IsCompleted"].HeaderText = "Completed";
            dataGridViewTasks.Columns["SessionAssignment"].HeaderText = "Assigned Session";
            dataGridViewTasks.Columns["SessionAssignment"].Width = 190;
            //dataGridViewTasks.Columns["Description"].Visible = false; // Hide description column in grid
            dataGridViewTasks.Columns["Description"].HeaderText = "Description";
            dataGridViewTasks.Columns["Description"].Width = 188;

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

        private bool IsTaskWithinDueDateFilter(TaskItem task, string dueDateFilter)
        {
            DateTime today = DateTime.Today;

            switch (dueDateFilter)
            {
                case "Any Time":
                    return true;
                case "Today":
                    if (task.DueDate.HasValue && task.DueDate.Value.Date == today)
                        return true;
                    break;
                case "This Week":
                    if (task.DueDate.HasValue)
                    {
                        var calendar = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
                        var weekRule = System.Globalization.DateTimeFormatInfo.CurrentInfo.CalendarWeekRule;
                        var firstDayOfWeek = System.Globalization.DateTimeFormatInfo.CurrentInfo.FirstDayOfWeek;

                        int taskWeek = calendar.GetWeekOfYear(task.DueDate.Value.Date, weekRule, firstDayOfWeek);
                        int currentWeek = calendar.GetWeekOfYear(today, weekRule, firstDayOfWeek);

                        if (taskWeek == currentWeek && task.DueDate.Value.Year == today.Year)
                            return true;
                    }
                    break;
                case "This Month":
                    if (task.DueDate.HasValue && task.DueDate.Value.Year == today.Year && task.DueDate.Value.Month == today.Month)
                        return true;
                    break;
                case "Overdue":
                    if (task.DueDate.HasValue && task.DueDate.Value.Date < today)
                        return true;
                    break;
                default:
                    return true; // If filter is not recognized, include the task
            }
            return false;
        }



        private void cmbSortBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTasks();
        }

       
        private void cmbSessionFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbSessionFilter.SelectedItem != null)
            {
                LoadTasks();
            }
        }


        private void cmbDueDateFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadTasks();
        }
    
    }
}