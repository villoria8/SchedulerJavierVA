using SchedulerJavierVA.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerJavierVA
{
    public class DateValidationService
    {
        private readonly List<IDateValidator> _validators;

        public DateValidationService(IEnumerable<IDateValidator> validators)
        {
            _validators = validators.ToList();
        }

        public bool Validate(DateTime currentDate, DateTime nextDate, DateTime startDate, DateTime endDate, out List<string> errors)
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
