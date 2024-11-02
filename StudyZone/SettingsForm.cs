using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace StudyZone
{
    //public partial class SettingsForm : Form
    //{
    //    public SettingsForm()
    //    {
    //        InitializeComponent();
    //    }

    //    //private void chkEnablePauseReminders_CheckedChanged(object sender, EventArgs e)
    //    //{

    //    //}
    //    private void chkEnablePauseReminders_CheckedChanged(object sender, EventArgs e)
    //    {
    //        bool enabled = chkEnablePauseReminders.Checked;
    //        nudReminderThreshold.Enabled = enabled;
    //        nudReminderInterval.Enabled = enabled;
    //    }

    //    //private void btnSave_Click(object sender, EventArgs e)
    //    //{

    //    //}
    //    private void btnSave_Click(object sender, EventArgs e)
    //    {
    //        // Save the settings
    //        // We'll implement this later
    //    }

    //    //private void btnCancel_Click(object sender, EventArgs e)
    //    //{

    //    //}
    //    private void btnCancel_Click(object sender, EventArgs e)
    //    {
    //        this.Close();
    //    }

    //}
    public partial class SettingsForm : Form
    {
        private AppSettings appSettings;

        public SettingsForm()
        {
            InitializeComponent();

            // Load settings
            LoadSettings();
        }

        private void LoadSettings()
        {
            // Load settings from file
            appSettings = LoadAppSettings();

            // Set control values
            chkEnablePauseReminders.Checked = appSettings.EnablePauseReminders;
            nudReminderThreshold.Value = appSettings.PauseReminderThreshold;
            nudReminderInterval.Value = appSettings.PauseReminderInterval;

            // Enable or disable numeric up-down controls
            nudReminderThreshold.Enabled = chkEnablePauseReminders.Checked;
            nudReminderInterval.Enabled = chkEnablePauseReminders.Checked;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            // Update settings
            appSettings.EnablePauseReminders = chkEnablePauseReminders.Checked;
            appSettings.PauseReminderThreshold = (int)nudReminderThreshold.Value;
            appSettings.PauseReminderInterval = (int)nudReminderInterval.Value;

            // Save settings to file
            SaveAppSettings(appSettings);

            // Close the form
            this.Close();
        }

        // Methods to load and save settings
        private AppSettings LoadAppSettings()
        {
            string filePath = Path.Combine(Application.LocalUserAppDataPath, "settings.json");
            if (File.Exists(filePath))
            {
                string json = File.ReadAllText(filePath);
                return JsonConvert.DeserializeObject<AppSettings>(json);
            }
            else
            {
                // Return default settings
                return new AppSettings
                {
                    StartWithWindows = false,
                    EnablePauseReminders = true,
                    PauseReminderThreshold = 5,
                    PauseReminderInterval = 2
                };
            }
        }

        private void SaveAppSettings(AppSettings settings)
        {
            string filePath = Path.Combine(Application.LocalUserAppDataPath, "settings.json");
            Directory.CreateDirectory(Application.LocalUserAppDataPath);
            string json = JsonConvert.SerializeObject(settings, Formatting.Indented);
            File.WriteAllText(filePath, json);
        }

        private void chkEnablePauseReminders_CheckedChanged(object sender, EventArgs e)
        {
            bool enabled = chkEnablePauseReminders.Checked;
            nudReminderThreshold.Enabled = enabled;
            nudReminderInterval.Enabled = enabled;
        }
    }

}
