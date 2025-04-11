using SchedulerJavierVA;
using SchedulerJavierVA.Validators;
using SchedulerJavierVA.Interfaces;
using SchedulerJavierVA.Scheduler;
using SchedulerJavierVA.Services;

class Program
{
    static void Main()
    {
        var validators = new List<IDateValidator>
        {
            new NextDateAfterCurrentDateValidator(),
            new NextDateInRangeValidator()
        };

        var validationService = new DateValidationService(validators);
        var inputService = new UserInputService();
        var scheduleBuilder = new ScheduleBuilderService(validationService, inputService);

        SchedulerConfig config = scheduleBuilder.GetValidatedScheduleConfig();

        Scheduler scheduler = new Scheduler();
        SchedulerExecution execution = scheduler.GetNextExecution(config);

        Console.WriteLine($"Next execution time: {execution.NextExecution}");
        Console.WriteLine($"Description: {execution.Description}");

    }
}
