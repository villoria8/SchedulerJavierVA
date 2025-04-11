using SchedulerJavierVA.Interfaces;

namespace SchedulerJavierVA.Validators
{
    public class NextDateInRangeValidator : IDateValidator
    {
        public string ErrorMessage => "Date must be between start and end dates.";

        public bool IsValid(DateTime currentDate, DateTime? nextDate, DateTime startDate, DateTime? endDate)
        {
            if (nextDate != null && endDate == null)
            {
                return nextDate >= startDate;
            }
            else if (nextDate != null && endDate != null)
            {
                return nextDate >= startDate && nextDate <= endDate;
            }
            else if (endDate != null)
                return currentDate <= endDate;
            return true;
        }
    }
}
