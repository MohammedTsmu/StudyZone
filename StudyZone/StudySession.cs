using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudyZone
{
    public class StudySession
    {
        public string SessionName { get; set; }
        public int StudyMinutes { get; set; }
        public int StudySeconds { get; set; }
        public int BreakMinutes { get; set; }
        public int BreakSeconds { get; set; }

        public override string ToString()
        {
            return SessionName;
        }
    }

}