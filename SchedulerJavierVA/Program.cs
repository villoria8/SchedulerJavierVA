using SchedulerJavierVA;
using SchedulerJavierVA.Scheduler;
using System.Globalization;
using System.Runtime.CompilerServices;
using System.Xml.Linq;

class Program
{
    static void Main(string[] args)
    {
        var typeTask = GetType();
        Console.WriteLine(typeTask);

        var currentDate = DateHelper.GetDateFromUser("Introduce current date (dd/MM/yyyy HH:mm):");
        Console.WriteLine(currentDate);

        var nextDate = DateHelper.GetDateFromUser("Introduce next date (dd/MM/yyyy HH:mm) to run:");
        Console.WriteLine(nextDate);

        var startDate = DateHelper.GetDateFromUser("Introduce start date (dd/MM/yyyy HH:mm):");
        Console.WriteLine(startDate);

        var endDate = DateHelper.GetDateFromUser("Introduce end date (dd/MM/yyyy HH:mm):");
        Console.WriteLine(endDate);

        DateHelper.ValidDates(currentDate, nextDate, startDate, endDate);

        SchedulerConfig configSchedule = ConfigSchedule(currentDate, typeTask, nextDate, startDate, endDate);

        Scheduler schedule = new Scheduler();
        SchedulerExecution execution = schedule.GetNextExecution(configSchedule);

        Console.WriteLine($"{execution.Description} {execution.NextExecution}");
    }
    
    public static ScheduleType GetType()
    {
        var validType = false;

        //valor por defecto
        ScheduleType typeConfig = ScheduleType.Once;

        do
        {
            Console.WriteLine("Introduce task type (O = Once / R = Recurring)");
            var typeTask = Console.ReadLine();
            if (typeTask != null)
            {
                if (typeTask.Trim().ToUpper() == ScheduleType.Once.GetEnumMemberValue())
                {
                    validType = true;
                    typeConfig = ScheduleType.Once;
                }
                else if (typeTask.Trim().ToUpper() == ScheduleType.Recurring.GetEnumMemberValue())
                {
                    validType = true;
                    typeConfig = ScheduleType.Recurring;
                }
                else
                {
                    Console.WriteLine($"Type {typeTask} does not exist. Introduce (O = Once / R = Recurring)");
                }
            }
        }
        while (validType == false);

        return typeConfig;
    }

    private static SchedulerConfig ConfigSchedule(DateTime currentDate, ScheduleType typeTask, DateTime nextDate, DateTime startDate, DateTime endDate)
    {
        SchedulerConfig config = new SchedulerConfig();
        config.CurrentDate = currentDate;
        config.Type = typeTask;
        config.NextDate = nextDate;
        config.StartDate = startDate;
        config.EndDate = endDate;
        return config;
    }
}
