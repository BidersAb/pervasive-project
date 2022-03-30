using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjectForPervasive
{
    class DailySchedule
    {
        public string StartDateDisplay { get; set; }
        public string EndDateDisplay { get; set; }
        public string Title { get; set; }
        public DateTime StartTime { get; set; }
        public DateTime EndTime { get; set; }

    }
    class CalendarSchedule
    {
        public string StartDateDisplay { get; set; }
        public string EndDateDisplay { get; set; }
        public string Title { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }

    }
}
