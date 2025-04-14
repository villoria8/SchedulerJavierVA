namespace SchedulerJavierVA.Interfaces
{
    public interface IDateValidationService
    {
        bool IsValid(DateTime currentDate, DateTime? nextDate, DateTime startDate, DateTime? endDate);
        string ErrorMessage { get; }
    }
}
