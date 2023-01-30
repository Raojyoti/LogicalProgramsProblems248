using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class FibonacciSeries
    {
        public static int a = 0, b = 0, c = 1, number;
        //1.Find Fibonacci Series
        public static void FindFibonacciSeries()
        {
            Console.WriteLine("Please enter number as far you want find Fibonacci Series");
            number = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Fibonacci Series:--\n-----------------------");
            for (int i = 1; i <= number; i++)
            {
                a = b;
                b = c;
                c = a + b;
                Console.Write(a + "  ");
            }
            Console.ReadLine();
        }
    }
}
