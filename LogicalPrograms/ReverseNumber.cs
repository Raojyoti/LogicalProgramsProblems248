using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class ReverseNumber
    {
        public static int number, remainder, reverse;

        //4.Reverse the given number.
        public static void FindReverseNumber()
        {
            Console.WriteLine("Please enter number for find Reverse ");
            number = Convert.ToInt32(Console.ReadLine());
            while (number > 0)
            {
                remainder = number % 10;
                number /= 10;
                reverse = (reverse * 10) + remainder;
            }
            Console.WriteLine("Reverse number: {0}", reverse);
        }
    }
}
