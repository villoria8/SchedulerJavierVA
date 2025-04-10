using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchedulerJavierVA.Scheduler;

namespace SchedulerJavierVA.Interfaces
{
    public interface IScheduler
    {
        SchedulerExecution GetNextExecution(SchedulerConfig config);
    }
}
