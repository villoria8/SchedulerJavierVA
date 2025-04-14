using SchedulerJavierVA.Interfaces;

namespace SchedulerJavierVA.Services
{
    public class DateValidationService : IDateErrorsValidationService
    {
        private readonly List<IDateValidationService> _validators;

        public DateValidationService(IEnumerable<IDateValidationService> validators)
        {
            _validators = validators.ToList();
        }

        public bool IsValid(DateTime currentDate, DateTime? nextDate, DateTime startDate, DateTime? endDate, out List<string> errors)
        {
            errors = new List<string>();

            foreach (var validator in _validators)
            {
                if (!validator.IsValid(currentDate, nextDate, startDate, endDate))
                {
                    errors.Add(validator.ErrorMessage);
                }
            }

            return errors.Count == 0;
        }
    }

}
