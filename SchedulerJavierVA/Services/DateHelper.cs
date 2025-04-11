namespace SchedulerJavierVA.Services
{
    public class DateHelper
    {
        public static DateTime? GetDateFromUser(string prompt, bool optional = false)
        {
            DateTime inputDate;
            bool validDate;
            do
            {
                Console.WriteLine(prompt);
                var userInput = Console.ReadLine();
                if (userInput == "" && optional)
                    return null;
                validDate = DateTime.TryParse(userInput, out inputDate);

                if (!validDate)
                {
                    Console.WriteLine("Date format is not correct.");
                }
            } while (!validDate);
            return inputDate;
        }
    }
}
