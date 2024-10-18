using System;

namespace StudyZone
{
    public class TaskItem
    {
        public string Title { get; set; }
        public string Description { get; set; }
        public DateTime? DueDate { get; set; }
        public bool IsCompleted { get; set; }
        public string SessionAssignment { get; set; } // Name of the assigned session, if any

        public override string ToString()
        {
            return Title;
        }
    }
}
