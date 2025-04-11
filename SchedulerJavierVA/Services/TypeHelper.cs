using SchedulerJavierVA.Scheduler;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchedulerJavierVA.Services
{
    public class TypeHelper
    {
        public static ScheduleType GetType()
        {
            var validType = false;

            //default value
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
    }
}
