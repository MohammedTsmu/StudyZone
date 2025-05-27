using System;

namespace StudyZone
{
    public class StudyReminder
    {
        public string ReminderName { get; set; }
        public DateTime ReminderTime { get; set; }
        public bool IsRecurring { get; set; } // Indicates if the reminder is daily recurring
        public bool IsEnabled { get; set; } // Indicates if the reminder is active
        public DateTime? LastTriggeredDate { get; set; } // Add this property

        public override string ToString()
        {
            string status = IsEnabled ? "Enabled" : "Disabled";
            return $"{ReminderName} at {ReminderTime.ToShortTimeString()} {(IsRecurring ? "(Daily)" : "")} - {status}";
        }
    }
}