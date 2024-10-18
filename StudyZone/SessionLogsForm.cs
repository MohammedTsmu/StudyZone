using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace StudyZone
{
    public partial class SessionLogsForm : Form
    {
        private List<SessionLog> sessionLogs;
        private Action saveSessionLogsToFile;

        public SessionLogsForm(List<SessionLog> logs, Action saveSessionLogsAction)
        {
            InitializeComponent();
            sessionLogs = logs;
            saveSessionLogsToFile = saveSessionLogsAction;

            // Attach the DataBindingComplete event handler
            dataGridViewLogs.DataBindingComplete += dataGridViewLogs_DataBindingComplete;

            LoadSessionLogs();

            // Initialize the filter ComboBox
            cmbFilter.Items.AddRange(new string[] { "All", "Today", "This Week", "This Month" });
            cmbFilter.SelectedIndex = 0; // Default to 'All'
        }

        private void LoadSessionLogs()
        {
            dataGridViewLogs.DataSource = null;
            dataGridViewLogs.DataSource = sessionLogs;

            // Calculate totals
            TimeSpan totalStudyTime = TimeSpan.Zero;
            TimeSpan totalBreakTime = TimeSpan.Zero;
            int totalSessions = sessionLogs.Count;

            foreach (var log in sessionLogs)
            {
                totalStudyTime += log.StudyDuration;
                totalBreakTime += log.BreakDuration;
            }

            // Display totals
            lblTotalStudyTime.Text = $"Total Study Time: {totalStudyTime}";
            lblTotalBreakTime.Text = $"Total Break Time: {totalBreakTime}";
            lblTotalSessions.Text = $"Total Sessions: {totalSessions}";
        }

        private void ApplyFilter()
        {
            List<SessionLog> filteredLogs = new List<SessionLog>();
            DateTime now = DateTime.Now;

            foreach (var log in sessionLogs)
            {
                switch (cmbFilter.SelectedItem.ToString())
                {
                    case "All":
                        filteredLogs.Add(log);
                        break;
                    case "Today":
                        if (log.SessionDate.Date == now.Date)
                            filteredLogs.Add(log);
                        break;
                    case "This Week":
                        var calendar = System.Globalization.DateTimeFormatInfo.CurrentInfo.Calendar;
                        var d1 = log.SessionDate.Date.AddDays(-1 * (int)calendar.GetDayOfWeek(log.SessionDate));
                        var d2 = now.Date.AddDays(-1 * (int)calendar.GetDayOfWeek(now));
                        if (d1 == d2)
                            filteredLogs.Add(log);
                        break;
                    case "This Month":
                        if (log.SessionDate.Year == now.Year && log.SessionDate.Month == now.Month)
                            filteredLogs.Add(log);
                        break;
                }
            }

            dataGridViewLogs.DataSource = null;
            dataGridViewLogs.DataSource = filteredLogs;
        }

        private void btnApplyFilter_Click(object sender, EventArgs e)
        {
            ApplyFilter();
        }

        private void btnDeleteLog_Click(object sender, EventArgs e)
        {
            if (dataGridViewLogs.CurrentRow != null)
            {
                var selectedLog = dataGridViewLogs.CurrentRow.DataBoundItem as SessionLog;
                if (selectedLog != null)
                {
                    var result = MessageBox.Show("Are you sure you want to delete this log?", "Delete Log", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (result == DialogResult.Yes)
                    {
                        sessionLogs.Remove(selectedLog);
                        saveSessionLogsToFile(); // Call the delegate to save the logs
                        ApplyFilter(); // Refresh the grid
                    }
                }
            }
            else
            {
                MessageBox.Show("Please select a log to delete.", "Delete Log", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }

        private void dataGridViewLogs_DataBindingComplete(object sender, DataGridViewBindingCompleteEventArgs e)
        {
            // Adjust column headers
            dataGridViewLogs.Columns["SessionDate"].HeaderText = "Date";
            dataGridViewLogs.Columns["StudyDuration"].HeaderText = "Study Duration";
            dataGridViewLogs.Columns["BreakDuration"].HeaderText = "Break Duration";
            dataGridViewLogs.Columns["NumberOfBreaks"].HeaderText = "Breaks Taken";

            // Format the date column
            dataGridViewLogs.Columns["SessionDate"].DefaultCellStyle.Format = "g"; // General date and time pattern
        }
    }
}
