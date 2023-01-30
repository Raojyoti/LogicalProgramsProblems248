using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class PrimeNumber
    {
        public static int number, count = 0;

        //3.Check given number is Prime number or not.
        public static void CheckPrimeNumber()
        {
            Console.WriteLine("Please enter number for check Prime Number");
            number = Convert.ToInt32(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if (number % i == 0)
                {
                    count++;
                }
            }
            if (count == 2)
                Console.WriteLine("{0} is prime number", number);
            else
                Console.WriteLine("{0} is not prime number", number);
        }
    }
}
