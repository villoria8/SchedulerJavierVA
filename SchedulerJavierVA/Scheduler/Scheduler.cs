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
            var execution = new SchedulerExecution
            {
                NextExecution = config.NextDate ??
                        (config.CurrentDate >= config.StartDate ? config.CurrentDate : config.StartDate)
            };

            execution.Description = BuildDescription(config, execution.NextExecution);

            return execution;
        }

        private string BuildDescription(SchedulerConfig config, DateTime nextExecution)
        {
            if (config.Type == ScheduleType.Once)
            {
                return $"Occurs once. Schedule will be used on {nextExecution} starting on {config.StartDate.ToShortDateString()}";
            }

            string frequencyDescription = config.Occurs switch
            {
                OccursType.Daily => "every day",
                OccursType.Weekly => "weekly",
                OccursType.Monthly => "monthly",
                _ => "with unknown frequency"
            };

            return $"Occurs {frequencyDescription}. Schedule will be used on {nextExecution} starting on {config.StartDate.ToShortDateString()}";

        }
    }
}
