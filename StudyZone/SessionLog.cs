using System;

namespace StudyZone
{
    public class SessionLog
    {
        public DateTime SessionDate { get; set; }
        public TimeSpan StudyDuration { get; set; }
        public TimeSpan BreakDuration { get; set; }
        public int NumberOfBreaks { get; set; }

        public SessionLog()
        {
            SessionDate = DateTime.Now;
            StudyDuration = TimeSpan.Zero;
            BreakDuration = TimeSpan.Zero;
            NumberOfBreaks = 0;
        }

        // ✅ جديد
        public string SessionName { get; set; }
    }
}