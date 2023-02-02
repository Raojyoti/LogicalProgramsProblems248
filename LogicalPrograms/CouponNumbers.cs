using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class CouponNumbers
    {
        public static int number;
        //13.Find how many random numbers need to generate N distinct coupon number.
        public static void FindRandomNumNeedToGenerateCouponNumber()
        {
            int count = 0;
            int arrCount = 0;
            Console.WriteLine("Please enter number for coupan ");
            number = Convert.ToInt32(Console.ReadLine());
            bool[] coupan = new bool[number];
            Random random = new Random();
            Console.WriteLine("Random Number is : \n-----------------------");
            while (arrCount != coupan.Length)
            {
                int input = random.Next(number);
                count++;
                if (input < coupan.Length && !coupan[input])
                {
                    coupan[input] = true;
                    arrCount++;
                }
                Console.WriteLine(input);
            }
            Console.WriteLine("Random count:  " + count + " in order generate {0} distict number: ", number);
        }
    }
}
