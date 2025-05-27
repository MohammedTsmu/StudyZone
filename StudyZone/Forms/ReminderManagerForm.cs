using System;
using System.Collections.Generic;
using System.Drawing;
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

            // إعدادات القائمة
            listBoxReminders.ItemHeight = 24;
            listBoxReminders.DrawItem += listBoxReminders_DrawItem;



            LoadReminders();
        }

        private void LoadReminders()
        {
            listBoxReminders.Items.Clear();

            foreach (var reminder in reminders)
            {
                // نعرض الكائن نفسه لأننا نريد استخدامه لاحقًا (ToString() يشتغل تلقائيًا)
                listBoxReminders.Items.Add(reminder);
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
            if (listBoxReminders.SelectedItem is StudyReminder selectedReminder)
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
            if (listBoxReminders.SelectedItem is StudyReminder selectedReminder)
            {
                var result = MessageBox.Show(
                    $"Are you sure you want to delete the reminder '{selectedReminder.ReminderName}'?",
                    "Delete Reminder",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Warning);

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
            if (listBoxReminders.SelectedItem is StudyReminder selectedReminder)
            {
                selectedReminder.IsEnabled = !selectedReminder.IsEnabled;
                saveRemindersToFile();
                LoadReminders();

                string status = selectedReminder.IsEnabled ? "enabled" : "disabled";
                MessageBox.Show(
                    $"Reminder '{selectedReminder.ReminderName}' is now {status}.",
                    "Reminder Status",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Please select a reminder to enable or disable.", "Toggle Reminder", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }


        //دالة لرسم العناصر في ListBox باستخدام DevExpress
        private void listBoxReminders_DrawItem(object sender, DevExpress.XtraEditors.ListBoxDrawItemEventArgs e)
        {
            // 1. احصل على العنصر
            var list = sender as DevExpress.XtraEditors.ListBoxControl;
            var item = list.GetItem(e.Index) as StudyReminder;
            if (item == null) return;

            // 2. اكتشف ما إذا كان العنصر محدداً
            bool isSelected = (e.State & DrawItemState.Selected) == DrawItemState.Selected;

            // 3. اختر لون الخلفية
            Color backColor = isSelected
                ? SystemColors.Highlight
                : e.Appearance.BackColor;
            using (var backBrush = new SolidBrush(backColor))
                e.Cache.FillRectangle(backBrush, e.Bounds);

            // 4. رسم الأيقونة
            Image icon = Properties.Resources.Bell_Png_32;
            int iconSize = 16;
            int padding = 4;
            int iconX = e.Bounds.Left + padding;
            int iconY = e.Bounds.Top + (e.Bounds.Height - iconSize) / 2;
            e.Cache.Graphics.DrawImage(icon, iconX, iconY, iconSize, iconSize);

            // 5. رسم النص
            Color textColor = !item.IsEnabled
                ? Color.DarkGray
                : isSelected
                    ? SystemColors.HighlightText
                    : Color.Black;
            int textX = iconX + iconSize + padding;
            int textWidth = e.Bounds.Width - (textX - e.Bounds.Left) - padding;
            var textRect = new Rectangle(textX, e.Bounds.Top, textWidth, e.Bounds.Height);
            using (var textBrush = new SolidBrush(textColor))
                e.Cache.Graphics.DrawString(
                    item.ToString(),
                    e.Appearance.Font,
                    textBrush,
                    textRect);

            // 6. رسم مستطيل التركيز للعناصر المحددة
            if (isSelected)
                System.Windows.Forms.ControlPaint.DrawFocusRectangle(e.Cache.Graphics, e.Bounds);

            // أخبر DevExpress أنّنا تولّينا الرسم
            e.Handled = true;
        }
    }
}