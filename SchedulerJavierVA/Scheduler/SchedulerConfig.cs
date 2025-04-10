using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerJavierVA.Scheduler
{
    public class SchedulerConfig
    {
        public ScheduleType Type { get; set; }
        public DateTime CurrentDate { get; set; }
        public DateTime? NextDate { get; set; }
        public int? Every { get; set; }
        public DateTime? StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }

    public enum ScheduleType
    {
        [EnumMember(Value = "O")]
        Once,
        [EnumMember(Value = "R")]
        Recurring     
    }
}
