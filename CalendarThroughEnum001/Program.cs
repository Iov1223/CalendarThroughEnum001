using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CalendarThroughEnum001
{
    public class myDate
    {
        private int year;
        public int Year
        {
            get { return year; }
            set 
            {
                if (value >= 1970)
                {
                    year = value;
                }
                else
                {
                    year = 1970;
                }
            }
        }
        private int month;
        public int Month
        {
            get { return month; }
            set
            {
                if (value > 0 | value <=12)
                {
                    month = value;
                }
                else
                {
                    month = 1;
                }
            }
        }
        private int day;
        public int Day
        {
            get { return day; }
            set
            {
                if (value > 0 | value <= DayOfMonthArr.month[this.month - 1])
                {
                    day = value;  
                }
                else
                {
                    day = 1;
                }
            }
        }
        public void PrintDayOfWeek(string args)
        {
            myDate date = new myDate();
            date.Year = int.Parse(args.Split('.')[0]);
            date.Month = int.Parse(args.Split('.')[1]);
            date.Day = int.Parse(args.Split('.')[2]);
            if (date.Month < 3)
            {
                --date.Year;
                date.Month += 10;
            }
            else
            {
                date.Month -= 2;
            }
            int day = (date.Day + 31 * date.Month / 12 + date.Year + date.Year / 4 - date.Year / 100 + date.Year / 400) % 7;
            string[] dayWeek = Enum.GetNames(typeof(DayOfWeekEnumRus));
            Console.WriteLine("Дата {0} - это {1}.", args, dayWeek[day - 1]);
        }
    }
    internal class Program
    {
        static void Main(string[] args)
        {
            myDate _date = new myDate();
            try
            {                
                _date.PrintDayOfWeek(args[0]);
            }
            catch
            {
                Console.WriteLine("Программа требует ввода аргумента комаендной строки.");
            }
        }
    }
}
