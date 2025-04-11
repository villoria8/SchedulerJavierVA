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
            if (config.NextDate != null)
            {
                execution.NextExecution = (DateTime)config.NextDate;
            }
            else
            {
                if (config.CurrentDate >= config.StartDate)
                {
                    execution.NextExecution = config.CurrentDate;
                }
                else
                {
                    execution.NextExecution = config.StartDate;
                }
            }

            execution.Description = $"Occurs {config.Type}. Schedule will be used on {execution.NextExecution} starting on {config.StartDate}";

            return execution;
            /*if (config.Type == ScheduleType.Once)
            {
                execution.Description = "";
                return execution;
            }

            if (config.Type == ScheduleType.Recurring)
            {
                execution.Description = "";
                return execution;
            }*/

            //throw new InvalidOperationException();
        }
    }
}
