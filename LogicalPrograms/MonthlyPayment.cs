using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class MonthlyPayment
    {
        public static double P, Y, R, payment, n, r;
        //3.Calculates Monthly Payment by using given formula.
        public static void FindMonthlyPayment()
        {
            Console.Write("Please enter value for Year: ");
            Y = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter value for interest rate: ");
            R = Convert.ToInt32(Console.ReadLine());
            Console.Write("Please enter value for loan amount : ");
            P = Convert.ToInt32(Console.ReadLine());

            n = 12 * Y;
            r = R / (12 * 100);
            payment = (P * r) / (1 - (Math.Pow((1 + r), -n)));
            Console.WriteLine("Monthly Payment is: " + payment);
        }
    }
}
