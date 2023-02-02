using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class NewtonsMethod
    {
        public static double c, t, epsilon = 1e-15;
        //11. Compute the square root of a nonnegative number.
        public static void Sqrt()
        {
            Console.WriteLine("Enter the value of c which you want to get the squre root");
            c = Convert.ToInt32(Console.ReadLine());
            t = c;
            while (Math.Abs(t - (c / t)) > epsilon * t)
            {
                t = ((c / t) + t) / 2;
            }
            Console.WriteLine("The squre root of c is " + t);
        }
    }
}
