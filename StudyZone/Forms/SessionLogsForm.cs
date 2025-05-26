//using DevExpress.XtraEditors;
//using DevExpress.XtraGrid;
//using DevExpress.XtraGrid.Views.Grid;
//using System;
//using System.Collections.Generic;
//using System.ComponentModel;
//using System.Drawing;
//using System.Windows.Forms;

//namespace StudyZone
//{
//    public partial class SessionLogsForm : Form
//    {
//        private List<SessionLog> sessionLogs;
//        //private BindingList<SessionLog> sessionLogs;

//        private Action saveSessionLogsToFile;

//        // ✅ متغير لتخزين الفلتر الحالي
//        private string currentFilter = "All";


//        public SessionLogsForm(List<SessionLog> logs, Action saveSessionLogsAction)
//        {
//            InitializeComponent();
//            sessionLogs = logs;
//            saveSessionLogsToFile = saveSessionLogsAction;

//            comboFilter.Properties.Items.Clear();
//            comboFilter.Properties.Items.AddRange(new string[] { "All", "Today", "Last 7 Days", "This Month" });
//            comboFilter.SelectedIndex = 0;

//            btnApplyFilter.Click += btnApplyFilter_Click;
//            btnDeleteLog.Click += btnDeleteLog_Click;

//            LoadSessionLogs();
//        }

//        private void LoadSessionLogs()
//        {
//            gridControlLogs.DataSource = null;
//            gridControlLogs.DataSource = sessionLogs;

//            var view = gridControlLogs.MainView as GridView;
//            if (view != null)
//            {
//                view.Columns["SessionName"].Caption = "Session Name";
//                view.Columns["SessionName"].VisibleIndex = 0;

//                view.Columns["SessionDate"].Caption = "Date";
//                view.Columns["StudyDuration"].Caption = "Study Duration";
//                view.Columns["BreakDuration"].Caption = "Break Duration";
//                view.Columns["NumberOfBreaks"].Caption = "Breaks Taken";

//                view.Columns["SessionDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
//                view.Columns["SessionDate"].DisplayFormat.FormatString = "g";

//                view.Columns["SessionDate"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;

//                view.OptionsBehavior.Editable = false;
//                view.OptionsView.ShowGroupPanel = false;
//                view.OptionsView.ShowAutoFilterRow = true;

//                view.RowStyle += (s, e) =>
//                {
//                    var gridView = s as GridView;
//                    var row = gridView.GetRow(e.RowHandle) as SessionLog;
//                    if (row != null && row.StudyDuration.TotalMinutes >= 90)
//                    {
//                        e.Appearance.BackColor = Color.LightGreen;
//                    }
//                };

//            }

//            UpdateStatistics(sessionLogs);
//            UpdateSummaryBar(sessionLogs);
//        }

//        private void ApplyFilter()
//        {
//            List<SessionLog> filteredLogs = new List<SessionLog>();
//            DateTime now = DateTime.Now;

//            foreach (var log in sessionLogs)
//            {
//                switch (comboFilter.SelectedItem?.ToString())
//                {
//                    case "All":
//                        filteredLogs.Add(log);
//                        break;
//                    case "Today":
//                        if (log.SessionDate.Date == now.Date)
//                            filteredLogs.Add(log);
//                        break;
//                    case "Last 7 Days":
//                        if ((now - log.SessionDate).TotalDays <= 7)
//                            filteredLogs.Add(log);
//                        break;
//                    case "This Month":
//                        if (log.SessionDate.Year == now.Year && log.SessionDate.Month == now.Month)
//                            filteredLogs.Add(log);
//                        break;
//                }
//            }
//            currentFilter = comboFilter.SelectedItem?.ToString() ?? "All";

//            gridControlLogs.DataSource = null;
//            gridControlLogs.DataSource = filteredLogs;

//            UpdateStatistics(filteredLogs);
//            UpdateSummaryBar(filteredLogs);
//        }

//        private void UpdateStatistics(List<SessionLog> logs)
//        {
//            TimeSpan totalStudyTime = TimeSpan.Zero;
//            TimeSpan totalBreakTime = TimeSpan.Zero;
//            int totalSessions = logs.Count;

//            foreach (var log in logs)
//            {
//                totalStudyTime += log.StudyDuration;
//                totalBreakTime += log.BreakDuration;
//            }

//            lblTotalStudyTime.Text = $"Total Study Time: {totalStudyTime}";
//            lblTotalBreakTime.Text = $"Total Break Time: {totalBreakTime}";
//            lblTotalSessions.Text = $"Total Sessions: {totalSessions}";
//        }

//        private void UpdateSummaryBar(List<SessionLog> logs)
//        {
//            TimeSpan totalStudy = TimeSpan.Zero;
//            TimeSpan totalBreak = TimeSpan.Zero;
//            int count = logs.Count;

//            foreach (var log in logs)
//            {
//                totalStudy += log.StudyDuration;
//                totalBreak += log.BreakDuration;
//            }

//            lblSummaryStudy.Text = $"🕓 Study: {totalStudy}";
//            lblSummaryBreak.Text = $"☕ Break: {totalBreak}";
//            lblSummaryCount.Text = $"📦 Sessions: {count}";
//        }

//        private void btnApplyFilter_Click(object sender, EventArgs e)
//        {
//            ApplyFilter();
//        }

//        //private void btnDeleteLog_Click(object sender, EventArgs e)
//        //{
//        //    var view = gridControlLogs.MainView as GridView;
//        //    if (view != null && view.FocusedRowHandle >= 0)
//        //    {
//        //        var selectedLog = view.GetRow(view.FocusedRowHandle) as SessionLog;
//        //        if (selectedLog != null)
//        //        {
//        //            var result = XtraMessageBox.Show("Are you sure you want to delete this log?", "Delete Log", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
//        //            if (result == DialogResult.Yes)
//        //            {
//        //                sessionLogs.Remove(selectedLog);
//        //                saveSessionLogsToFile();
//        //                //ApplyFilter();

//        //                //int deletedRowHandle = view.FocusedRowHandle;

//        //                //sessionLogs.Remove(selectedLog);
//        //                //saveSessionLogsToFile();

//        //                //// أعد تحميل الفلترة بعد التحديث
//        //                //ApplyFilter();

//        //                //// إزالة التركيز يدويًا بعد الحذف
//        //                //view.ClearSelection();
//        //                //view.FocusedRowHandle = GridControl.InvalidRowHandle;

//        //            }
//        //        }
//        //    }
//        //    else
//        //    {
//        //        XtraMessageBox.Show("Please select a log to delete.", "Delete Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        //    }
//        //}

//        //private void btnDeleteLog_Click(object sender, EventArgs e)
//        //{
//        //    var view = gridControlLogs.MainView as GridView;
//        //    if (view != null && view.FocusedRowHandle >= 0)
//        //    {
//        //        var selectedLog = view.GetRow(view.FocusedRowHandle) as SessionLog;
//        //        if (selectedLog != null)
//        //        {
//        //            var result = XtraMessageBox.Show("Are you sure you want to delete this log?", "Delete Log", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
//        //            if (result == DialogResult.Yes)
//        //            {
//        //                sessionLogs.Remove(selectedLog);
//        //                saveSessionLogsToFile();

//        //                ReloadFilteredLogs(); // ✅ يعتمد على currentFilter وليس All

//        //                view.ClearSelection();
//        //                view.FocusedRowHandle = GridControl.InvalidRowHandle;
//        //            }
//        //        }
//        //    }
//        //    else
//        //    {
//        //        XtraMessageBox.Show("Please select a log to delete.", "Delete Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
//        //    }
//        //}
//        private void btnDeleteLog_Click(object sender, EventArgs e)
//        {
//            var view = gridControlLogs.MainView as GridView;
//            if (view == null) return;

//            // نحصل على الصف المحدد فقط
//            int[] selectedHandles = view.GetSelectedRows();
//            if (selectedHandles.Length == 0)
//            {
//                XtraMessageBox.Show("Please select a log to delete.", "Delete Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
//                return;
//            }

//            int handle = selectedHandles[0];
//            var selectedLog = view.GetRow(handle) as SessionLog;
//            if (selectedLog == null) return;

//            var result = XtraMessageBox.Show(
//                $"Are you sure you want to delete the log for {selectedLog.SessionDate}?",
//                "Delete Log",
//                MessageBoxButtons.YesNo,
//                MessageBoxIcon.Warning);

//            if (result == DialogResult.Yes)
//            {
//                sessionLogs.Remove(selectedLog);
//                saveSessionLogsToFile();

//                // إعادة التحميل
//                ReloadFilteredLogs();
//            }
//        }



//        private void ReloadFilteredLogs()
//        {
//            List<SessionLog> filteredLogs = new List<SessionLog>();
//            DateTime now = DateTime.Now;

//            foreach (var log in sessionLogs)
//            {
//                switch (currentFilter)
//                {
//                    case "All":
//                        filteredLogs.Add(log);
//                        break;
//                    case "Today":
//                        if (log.SessionDate.Date == now.Date)
//                            filteredLogs.Add(log);
//                        break;
//                    case "Last 7 Days":
//                        if ((now - log.SessionDate).TotalDays <= 7)
//                            filteredLogs.Add(log);
//                        break;
//                    case "This Month":
//                        if (log.SessionDate.Year == now.Year && log.SessionDate.Month == now.Month)
//                            filteredLogs.Add(log);
//                        break;
//                }
//            }

//            gridControlLogs.DataSource = null;
//            gridControlLogs.DataSource = filteredLogs;

//            UpdateStatistics(filteredLogs);
//            UpdateSummaryBar(filteredLogs);

//            // ✅ إصلاح سلوك DevExpress بعد الحذف
//            var view = gridControlLogs.MainView as GridView;
//            if (view != null)
//            {
//                view.FocusedRowHandle = GridControl.InvalidRowHandle;
//                view.ClearSelection();
//            }
//        }



//    }
//}

using DevExpress.XtraEditors;
using DevExpress.XtraGrid;
using DevExpress.XtraGrid.Views.Grid;
using System;
using System.Collections.Generic;
using System.ComponentModel; // BindingList
using System.Drawing;
using System.Windows.Forms;

namespace StudyZone
{
    public partial class SessionLogsForm : Form
    {
        private BindingList<SessionLog> sessionLogs;
        private readonly Action saveSessionLogsToFile;

        // ✅ متغير لتخزين الفلتر الحالي
        private string currentFilter = "All";

        public SessionLogsForm(List<SessionLog> logs, Action saveSessionLogsAction)
        {
            InitializeComponent();

            sessionLogs = new BindingList<SessionLog>(logs);
            sessionLogs.ListChanged += (s, e) => ApplyFilter();

            saveSessionLogsToFile = saveSessionLogsAction;

            comboFilter.Properties.Items.Clear();
            comboFilter.Properties.Items.AddRange(new[] { "All", "Today", "Last 7 Days", "This Month" });
            comboFilter.SelectedIndex = 0;

            btnApplyFilter.Click += btnApplyFilter_Click;
            btnDeleteLog.Click += btnDeleteLog_Click;

            gridControlLogs.DataSource = sessionLogs; // الربط مباشرةً
            ConfigureGrid();
            ApplyFilter();
        }

        // تكوين الشبكة مرة واحدة فقط بعد الربط
        private void ConfigureGrid()
        {
            var view = gridControlLogs.MainView as GridView;
            if (view == null) return;

            view.Columns["SessionName"].Caption = "Session Name";
            view.Columns["SessionName"].VisibleIndex = 0;

            view.Columns["SessionDate"].Caption = "Date";
            view.Columns["StudyDuration"].Caption = "Study Duration";
            view.Columns["BreakDuration"].Caption = "Break Duration";
            view.Columns["NumberOfBreaks"].Caption = "Breaks Taken";

            view.Columns["SessionDate"].DisplayFormat.FormatType = DevExpress.Utils.FormatType.DateTime;
            view.Columns["SessionDate"].DisplayFormat.FormatString = "g";
            view.Columns["SessionDate"].SortOrder = DevExpress.Data.ColumnSortOrder.Descending;

            view.OptionsBehavior.Editable = false;
            view.OptionsSelection.MultiSelect = false;
            view.OptionsSelection.EnableAppearanceFocusedRow = true;
            view.OptionsView.ShowGroupPanel = false;
            view.OptionsView.ShowAutoFilterRow = true;

            view.RowStyle += (s, e) =>
            {
                var gridView = s as GridView;
                var row = gridView.GetRow(e.RowHandle) as SessionLog;
                if (row != null && row.StudyDuration.TotalMinutes >= 90)
                {
                    e.Appearance.BackColor = Color.LightGreen;
                }
            };
        }

        private void ApplyFilter()
        {
            List<SessionLog> filteredLogs = new List<SessionLog>();
            DateTime now = DateTime.Now;

            foreach (var log in sessionLogs)
            {
                switch (comboFilter.SelectedItem?.ToString() ?? currentFilter)
                {
                    case "All":
                        filteredLogs.Add(log);
                        break;
                    case "Today":
                        if (log.SessionDate.Date == now.Date)
                            filteredLogs.Add(log);
                        break;
                    case "Last 7 Days":
                        if ((now - log.SessionDate).TotalDays <= 7)
                            filteredLogs.Add(log);
                        break;
                    case "This Month":
                        if (log.SessionDate.Year == now.Year && log.SessionDate.Month == now.Month)
                            filteredLogs.Add(log);
                        break;
                }
            }

            currentFilter = comboFilter.SelectedItem?.ToString() ?? currentFilter;
            gridControlLogs.DataSource = filteredLogs;

            UpdateStatistics(filteredLogs);
            //UpdateSummaryBar(filteredLogs);
        }

        private void UpdateStatistics(List<SessionLog> logs)
        {
            TimeSpan totalStudyTime = TimeSpan.Zero;
            TimeSpan totalBreakTime = TimeSpan.Zero;

            foreach (var log in logs)
            {
                totalStudyTime += log.StudyDuration;
                totalBreakTime += log.BreakDuration;
            }

            //lblTotalStudyTime.Text = $"Total Study Time: {totalStudyTime}";
            //lblTotalBreakTime.Text = $"Total Break Time: {totalBreakTime}";
            //lblTotalSessions.Text = $"Total Sessions: {logs.Count}";
            lblTotalStudyTime.Text = $"🕓 Total Study Time: {totalStudyTime}";
            //lblTotalBreakTime.Text = $"☕    Total Break Time: {totalBreakTime}";
            lblTotalBreakTime.Text = $"🍵 Total Break Time: {totalBreakTime}";
            lblTotalSessions.Text = $"📦 Total Sessions: {logs.Count}";
        }

        //private void UpdateSummaryBar(List<SessionLog> logs)
        //{
        //    TimeSpan totalStudy = TimeSpan.Zero;
        //    TimeSpan totalBreak = TimeSpan.Zero;

        //    foreach (var log in logs)
        //    {
        //        totalStudy += log.StudyDuration;
        //        totalBreak += log.BreakDuration;
        //    }

        //    lblSummaryStudy.Text = $"🕓 Study: {totalStudy}";
        //    lblSummaryBreak.Text = $"☕ Break: {totalBreak}";
        //    lblSummaryCount.Text = $"📦 Sessions: {logs.Count}";
        //}

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void btnDeleteLog_Click(object sender, EventArgs e)
        {
            var view = gridControlLogs.MainView as GridView;
            var selectedLog = view?.GetFocusedRow() as SessionLog;

            if (selectedLog == null)
            {
                XtraMessageBox.Show("اختر جلسة أولاً للحذف.", "حذف جلسة", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            var q = XtraMessageBox.Show(
                $"هل تريد حذف جلسة {selectedLog.SessionDate:g}؟",
                "تأكيد الحذف", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

            if (q == DialogResult.Yes)
            {
                sessionLogs.Remove(selectedLog); // BindingList سيتكفّل بتحديث الشبكة
                saveSessionLogsToFile();
            }
        }
    }
}
