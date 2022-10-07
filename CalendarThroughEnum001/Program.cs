using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarThroughEnum001
{

    internal class Program
    {
        static void DetectDay(string _day)
        {
            if (_day != "saturday" & _day != "sunday")
            {
                Console.WriteLine($"This day {_day} is working day");
            }
            else
            {
                Console.WriteLine($"This day {_day} is holiday");
            }
        }
        static void DetectDay(DayOfWeek _day)
        {
            if (_day.ToString() != "saturday" & _day != DayOfWeek.Sunday)
            {
                Console.WriteLine($"This day {_day} is working day");
            }
            else
            {
                Console.WriteLine($"This day {_day} is holiday");
            }
        }
        static void Main(string[] args)
        {
            foreach (var item in Enum.GetValues(typeof(DayOfWeek)))
            {
                Console.WriteLine("Перечисление ч/з Enum.GetValues {0}", item);
            }
            foreach (var item in Enum.GetValues(typeof(DayOfWeek)))
            {
                DetectDay((DayOfWeek)item);
            }
            foreach (var item in Enum.GetValues(typeof(DayOfMonthRus)))
            {
                Console.WriteLine("В месяце {0} {1}", item.ToString(), DayOfMonthArr.month[(int)item]);
            }
        }
    }
}
