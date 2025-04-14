using System.Runtime.Serialization;

namespace SchedulerJavierVA.Scheduler
{
    public class SchedulerConfig
    {
        public ScheduleType Type { get; set; }
        public DateTime CurrentDate { get; set; }
        public DateTime? NextDate { get; set; }
        public OccursType Occurs { get; set; }
        public int? Every { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime? EndDate { get; set; }
    }

    public enum ScheduleType
    {
        [EnumMember(Value = "O")]
        Once,
        [EnumMember(Value = "R")]
        Recurring
    }

    public enum OccursType
    {
        [EnumMember(Value = "D")]
        Daily,
        [EnumMember(Value = "W")]
        Weekly,
        [EnumMember(Value = "M")]
        Monthly
    }
}
