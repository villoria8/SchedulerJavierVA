using SchedulerJavierVA.Interfaces;
using SchedulerJavierVA.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerJavierVA.Services
{
    public class ScheduleBuilderService
    {
        private readonly IDateErrorsValidationService validationService;
        private readonly IUserInputService inputService;

        public ScheduleBuilderService(IDateErrorsValidationService validationService, IUserInputService inputService)
        {
            this.validationService = validationService;
            this.inputService = inputService;
        }

        public SchedulerConfig GetValidatedScheduleConfig()
        {
            while (true)
            {
                var (currentDate, type, nextDate, startDate, endDate) = inputService.GetUserInput();

                bool isValid = validationService.IsValid(currentDate, nextDate, startDate, endDate, out var errors);

                if (isValid)
                {
                    return new SchedulerConfig
                    {
                        CurrentDate = currentDate,
                        Type = type,
                        NextDate = nextDate,
                        StartDate = startDate,
                        EndDate = endDate
                    };
                }

                Console.WriteLine("Dates are invalid:");
                errors.ForEach(Console.WriteLine);
            }
        }
    }
}
