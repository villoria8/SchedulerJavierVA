using SchedulerJavierVA.Interfaces;

namespace SchedulerJavierVA.Validators
{
    public class NextDateAfterCurrentDateValidator : IDateValidator
    {
        public string ErrorMessage => "Next date must be greater than current date.";

        public bool IsValid(DateTime currentDate, DateTime? nextDate, DateTime startDate, DateTime? endDate)
        {
            if (nextDate != null)
            {
                return nextDate > currentDate;
            }
            return true;
        }
    }
}