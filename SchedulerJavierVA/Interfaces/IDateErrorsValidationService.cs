using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerJavierVA.Interfaces
{
    public interface IDateErrorsValidationService
    {
        bool IsValid(DateTime currentDate, DateTime? nextDate, DateTime startDate, DateTime? endDate, out List<string> errors);
    }
}
