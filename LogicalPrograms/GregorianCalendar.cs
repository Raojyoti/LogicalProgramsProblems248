using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class GregorianCalendar
    {
        public static int date, month, year;
        //6.Pints the day of the week that date falls on.
        public static void DayOfWeek()
        {
            Console.Write("Please enter value for date: ");
            int date = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter value for month: ");
            int month = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter value for year: ");
            int year = Convert.ToInt32(Console.ReadLine());
            int m = month;
            int d = date;
            int y = year;
            int y0 = y - (14 - m) / 12;
            int x = y0 + y0 / 4 - y0 / 100 + y0 / 400;
            int m0 = m + 12 * ((14 - m) / 12) - 2;
            int d0 = (d + x + 31 * m0 / 12) % 7;
            d0 = d0 % 7;
            switch (d0)
            {
                case 0:
                    Console.WriteLine("Sunday");
                    break;
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thursday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
            }
        }
    }
}
