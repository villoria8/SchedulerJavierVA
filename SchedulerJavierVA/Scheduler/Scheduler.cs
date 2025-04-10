using SchedulerJavierVA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerJavierVA.Scheduler
{
    public class Scheduler : IScheduler
    {
        public SchedulerExecution GetNextExecution(SchedulerConfig config)
        {
            SchedulerExecution execution = new SchedulerExecution();

            if (config.Type == ScheduleType.Once)
            {
                execution.NextExecution = config.CurrentDate;
                execution.Description = "";
                return execution;
            }

            if (config.Type == ScheduleType.Recurring)
            {

                return execution;
            }
            throw new InvalidOperationException();
        }
    }
}
