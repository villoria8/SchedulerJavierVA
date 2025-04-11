using SchedulerJavierVA.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerJavierVA.Services
{
    public class UserInputService
    {
        public (DateTime currentDate, ScheduleType scheduleType, DateTime? nextDate, DateTime startDate, DateTime? endDate)
        GetUserInput()
        {
            DateTime currentDate = (DateTime)DateHelper.GetDateFromUser("Introduce current date (dd/MM/yyyy HH:mm):");
            ScheduleType type = TypeHelper.GetType();
            DateTime? nextDate = DateHelper.GetDateFromUser("Introduce next date (dd/MM/yyyy HH:mm) to run:", true);
            DateTime startDate = (DateTime)DateHelper.GetDateFromUser("Introduce start date (dd/MM/yyyy HH:mm):");
            DateTime? endDate = DateHelper.GetDateFromUser("Introduce end date (dd/MM/yyyy HH:mm):", true);

            return (currentDate, type, nextDate, startDate, endDate);
        }
    }
}
