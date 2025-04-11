namespace SchedulerJavierVA.Interfaces
{
    public interface IDateValidator
    {
        bool IsValid(DateTime currentDate, DateTime? nextDate, DateTime startDate, DateTime? endDate);
        string ErrorMessage { get; }
    }
}
