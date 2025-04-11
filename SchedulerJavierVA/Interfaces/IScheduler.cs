using SchedulerJavierVA.Scheduler;

namespace SchedulerJavierVA.Interfaces
{
    public interface IScheduler
    {
        SchedulerExecution GetNextExecution(SchedulerConfig config);
    }
}
