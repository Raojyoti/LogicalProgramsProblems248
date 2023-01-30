using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PerfectNumber
    {
        public static int number, sum = 0;
        //2.Check number is Perfect number or not.
        public static void CheckPerfectNumber()
        {
            Console.WriteLine("Enter number for check Perfect Number");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum = sum + i;
                }
            }
            if (number == sum)
                Console.WriteLine("{0} is perfect number", number);
            else
                Console.WriteLine("{0} is not perfect number", number);
        }
    }
}
