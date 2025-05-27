namespace StudyZone
{

    public class StudySession
    {
        public string SessionName { get; set; }
        public int StudyMinutes { get; set; }
        public int StudySeconds { get; set; }
        public int BreakMinutes { get; set; }
        public int BreakSeconds { get; set; }
        public bool IsDefault { get; set; } // New property

        public override string ToString()
        {
            return SessionName;
        }
    }


}