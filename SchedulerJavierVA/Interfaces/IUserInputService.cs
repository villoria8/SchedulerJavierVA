using SchedulerJavierVA.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerJavierVA.Interfaces
{
    public interface IUserInputService
    {
        (DateTime currentDate, ScheduleType scheduleType, DateTime? nextDate, DateTime startDate, DateTime? endDate) GetUserInput();
    }
}
