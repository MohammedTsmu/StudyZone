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
        private bool rowStyleAttached = false;

        //public TaskManagerForm(List<TaskItem> tasksList, Action saveTasksAction, List<StudySession> sessionsList)
        //{
        //    InitializeComponent();
        //    tasks = tasksList;
        //    saveTasksToFile = saveTasksAction;
        //    sessions = sessionsList;

        //    // Initialize session filter
        //    cmbSessionFilter.Items.Add("All Sessions");
        //    foreach (var session in sessions)
        //    {
        //        cmbSessionFilter.Items.Add(session.SessionName);
        //    }
        //    cmbSessionFilter.SelectedIndex = 0; // Default to 'All Sessions'

        //    // Initialize due date filter
        //    cmbDueDateFilter.Items.AddRange(new string[] { "Any Time", "Today", "This Week", "This Month", "Overdue" });
        //    cmbDueDateFilter.SelectedIndex = 0; // Default to 'Any Time'

        //    // Initialize sorting ComboBox
        //    cmbSortBy.Items.AddRange(new string[] { "Title", "Due Date", "Status" });
        //    cmbSortBy.SelectedIndex = 0; // Default to 'Title'


        //    //To Be Deleted //To Be Deleted //To Be Deleted //To Be Deleted //To Be Deleted 
        //    //To Be Deleted //To Be Deleted //To Be Deleted //To Be Deleted //To Be Deleted 
        //    // Attach event handlers AFTER initialization
        //    //chkShowCompleted.CheckedChanged += chkShowCompleted_CheckedChanged;
        //    //cmbSortBy.SelectedIndexChanged += cmbSortBy_SelectedIndexChanged;
        //    //cmbSessionFilter.SelectedIndexChanged += cmbSessionFilter_SelectedIndexChanged;
        //    //cmbDueDateFilter.SelectedIndexChanged += cmbDueDateFilter_SelectedIndexChanged;


        //    //// Attach event handlers AFTER initialization
        //    comboSessionFilter.SelectedIndexChanged += cmbSessionFilter_SelectedIndexChanged;
        //    comboDueDateFilter.SelectedIndexChanged += cmbDueDateFilter_SelectedIndexChanged;
        //    comboSortBy.SelectedIndexChanged += cmbSortBy_SelectedIndexChanged;
        //    checkShowCompleted.CheckedChanged += chkShowCompleted_CheckedChanged;

        //    LoadTasks();
        //}
        public TaskManagerForm(List<TaskItem> tasksList, Action saveTasksAction, List<StudySession> sessionsList)
        {
            InitializeComponent();
            tasks = tasksList;
            saveTasksToFile = saveTasksAction;
            sessions = sessionsList;

            // 🔷 تهيئة ComboBoxEdit للجلسات
            comboSessionFilter.Properties.Items.Add("All Sessions");
            foreach (var session in sessions)
            {
                comboSessionFilter.Properties.Items.Add(session.SessionName);
            }
            comboSessionFilter.SelectedIndex = 0;

            // 🔷 تهيئة ComboBoxEdit للفلترة حسب التاريخ
            comboDueDateFilter.Properties.Items.AddRange(new string[]
            {
        "Any Time", "Today", "This Week", "This Month", "Overdue"
            });
            comboDueDateFilter.SelectedIndex = 0;

            // 🔷 تهيئة ComboBoxEdit للترتيب
            comboSortBy.Properties.Items.AddRange(new string[]
            {
        "Title", "Due Date", "Status"
            });
            comboSortBy.SelectedIndex = 0;

            // 🔷 ربط الأحداث
            checkShowCompleted.CheckedChanged += chkShowCompleted_CheckedChanged;
            comboSortBy.SelectedIndexChanged += cmbSortBy_SelectedIndexChanged;
            comboSessionFilter.SelectedIndexChanged += cmbSessionFilter_SelectedIndexChanged;
            comboDueDateFilter.SelectedIndexChanged += cmbDueDateFilter_SelectedIndexChanged;

            // تحميل المهام
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
            var view = gridControlTasks.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view != null && view.FocusedRowHandle >= 0)
            {
                var selectedTask = view.GetRow(view.FocusedRowHandle) as TaskItem;

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
            var view = gridControlTasks.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view != null && view.FocusedRowHandle >= 0)
            {
                var selectedTask = view.GetRow(view.FocusedRowHandle) as TaskItem;

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


        //private void btnMarkCompleted_Click(object sender, EventArgs e)
        //{
        //    var view = gridControlTasks.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
        //    if (view != null && view.FocusedRowHandle >= 0)
        //    {
        //        var selectedTask = view.GetRow(view.FocusedRowHandle) as TaskItem;

        //        if (selectedTask != null)
        //        {
        //            selectedTask.IsCompleted = true;
        //            saveTasksToFile();
        //            LoadTasks();
        //        }
        //    }
        //    else
        //    {
        //        MessageBox.Show("Please select a task to mark as completed.", "Mark as Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
        //    }
        //}




        private void btnToggleCompleted_Click(object sender, EventArgs e)
        {
            var view = gridControlTasks.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view != null && view.FocusedRowHandle >= 0)
            {
                var selectedTask = view.GetRow(view.FocusedRowHandle) as TaskItem;

                if (selectedTask != null)
                {
                    // Toggle the status (true ↔ false)
                    selectedTask.IsCompleted = !selectedTask.IsCompleted;
                    saveTasksToFile();
                    LoadTasks();
                }
            }
            else
            {
                MessageBox.Show("Please select a task to toggle its status.", "Toggle Completed", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }



        private void chkShowCompleted_CheckedChanged(object sender, EventArgs e)
        {
            LoadTasks();
        }



        //private void LoadTasks()
        //{
        //    // Apply filters
        //    List<TaskItem> displayedTasks = new List<TaskItem>();

        //    //string sessionFilter = cmbSessionFilter.SelectedItem as string ?? "All Sessions";
        //    string sessionFilter = comboSessionFilter.SelectedItem?.ToString() ?? "All Sessions";

        //    string dueDateFilter = cmbDueDateFilter.SelectedItem as string ?? "Any Time";


        //    foreach (var task in tasks)
        //    {
        //        // Filter by completion status
        //        //if (!chkShowCompleted.Checked && task.IsCompleted)
        //        if (!checkShowCompleted.Checked && task.IsCompleted)
        //            continue;

        //        // Filter by session assignment
        //        if (sessionFilter != "All Sessions")
        //        {
        //            if (task.SessionAssignment != sessionFilter)
        //                continue;
        //        }

        //        // Filter by due date
        //        if (!IsTaskWithinDueDateFilter(task, dueDateFilter))
        //            continue;

        //        displayedTasks.Add(task);
        //    }

        //    // Apply sorting
        //    switch (cmbSortBy.SelectedItem as string)
        //    {
        //        case "Title":
        //            displayedTasks.Sort((x, y) => x.Title.CompareTo(y.Title));
        //            break;
        //        case "Due Date":
        //            displayedTasks.Sort((x, y) => Nullable.Compare(x.DueDate, y.DueDate));
        //            break;
        //        case "Status":
        //            displayedTasks.Sort((x, y) => x.IsCompleted.CompareTo(y.IsCompleted));
        //            break;
        //        default:
        //            // Default sorting if none selected
        //            break;
        //    }

        //    gridControlTasks.DataSource = null;
        //    gridControlTasks.DataSource = displayedTasks;


        //    var view = gridControlTasks.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
        //    if (view != null)
        //    {
        //        view.Columns["Title"].Caption = "Task Title";
        //        view.Columns["Title"].Width = 250;

        //        view.Columns["DueDate"].Caption = "Due Date";
        //        view.Columns["DueDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
        //        view.Columns["DueDate"].DisplayFormat.FormatString = "d"; // Short date

        //        view.Columns["IsCompleted"].Caption = "Completed";

        //        view.Columns["SessionAssignment"].Caption = "Assigned Session";
        //        view.Columns["SessionAssignment"].Width = 190;

        //        view.Columns["Description"].Caption = "Description";
        //        view.Columns["Description"].Width = 188;

        //        view.OptionsView.ShowGroupPanel = false;
        //        view.OptionsBehavior.Editable = false;

        //    }
        //    if (!rowStyleAttached)
        //    {
        //        gridViewTasks.RowStyle += (s, e) =>
        //        {
        //            var gridViewLocal = s as DevExpress.XtraGrid.Views.Grid.GridView;
        //            if (gridViewLocal == null) return;

        //            var task = gridViewLocal.GetRow(e.RowHandle) as TaskItem;
        //            if (task != null && task.IsCompleted)
        //            {
        //                e.Appearance.BackColor = System.Drawing.Color.LightGray;
        //                e.Appearance.ForeColor = System.Drawing.Color.DarkGray;
        //                e.HighPriority = true;
        //            }
        //        };

        //        rowStyleAttached = true;
        //    }

        //}
        private void LoadTasks()
        {
            List<TaskItem> displayedTasks = new List<TaskItem>();

            string sessionFilter = comboSessionFilter.SelectedItem?.ToString() ?? "All Sessions";
            string dueDateFilter = comboDueDateFilter.SelectedItem?.ToString() ?? "Any Time";

            foreach (var task in tasks)
            {
                // فلترة حسب إظهار المهام المكتملة
                if (!checkShowCompleted.Checked && task.IsCompleted)
                    continue;

                // فلترة حسب الجلسة
                if (sessionFilter != "All Sessions" && task.SessionAssignment != sessionFilter)
                    continue;

                // فلترة حسب التاريخ
                if (!IsTaskWithinDueDateFilter(task, dueDateFilter))
                    continue;

                displayedTasks.Add(task);
            }

            // ترتيب حسب الاختيار
            switch (comboSortBy.SelectedItem?.ToString())
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

            // ربط البيانات بـ GridControl
            gridControlTasks.DataSource = null;
            gridControlTasks.DataSource = displayedTasks;

            // إعداد الأعمدة
            var view = gridControlTasks.MainView as DevExpress.XtraGrid.Views.Grid.GridView;
            if (view != null)
            {
                view.Columns["Title"].Caption = "Task Title";
                view.Columns["Title"].Width = 250;

                view.Columns["DueDate"].Caption = "Due Date";
                view.Columns["DueDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
                view.Columns["DueDate"].DisplayFormat.FormatString = "d";

                view.Columns["IsCompleted"].Caption = "Completed";
                view.Columns["SessionAssignment"].Caption = "Assigned Session";
                view.Columns["SessionAssignment"].Width = 190;

                view.Columns["Description"].Caption = "Description";
                view.Columns["Description"].Width = 188;

                view.OptionsView.ShowGroupPanel = false;
                view.OptionsBehavior.Editable = false;

                // إظهار فلترة تلقائية
                view.OptionsView.ShowAutoFilterRow = true;
            }

            // تخصيص الصف المكتمل بلون مختلف
            if (!rowStyleAttached)
            {
                gridViewTasks.RowStyle += (s, e) =>
                {
                    var gridViewLocal = s as DevExpress.XtraGrid.Views.Grid.GridView;
                    if (gridViewLocal == null) return;

                    var task = gridViewLocal.GetRow(e.RowHandle) as TaskItem;
                    if (task != null && task.IsCompleted)
                    {
                        e.Appearance.BackColor = System.Drawing.Color.LightGray;
                        e.Appearance.ForeColor = System.Drawing.Color.DarkGray;
                        e.HighPriority = true;
                    }
                };
                rowStyleAttached = true;
            }
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