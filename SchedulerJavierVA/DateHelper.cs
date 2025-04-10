using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerJavierVA
{
    public class DateHelper
    {
        public static DateTime GetDateFromUser(string prompt)
        {
            DateTime inputDate;
            bool validDate;

            do
            {
                Console.WriteLine(prompt);
                var userInput = Console.ReadLine();
                validDate = DateTime.TryParse(userInput, out inputDate);

                if (!validDate)
                {
                    Console.WriteLine("Date format is not correct.");
                }
            } while (!validDate);

            return inputDate;
        }

        internal static void ValidDates(DateTime currentDate, DateTime nextDate, DateTime startDate, DateTime endDate)
        {
            
        }
    }
}
