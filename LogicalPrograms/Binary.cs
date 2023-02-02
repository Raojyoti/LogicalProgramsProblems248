using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class Binary
    {
        public static int num;
        //9.(i).Swap nibbles and find the new number.
        public static void SwapNibbles()
        {
            Console.WriteLine("Please enter number for SwapNibbles");
            int num = Convert.ToInt32(Console.ReadLine());
            int right = (num & 0b00001111);

            right = (right << 4);
            int left = (num & 0b11110000);

            left = (left >> 4);
            int result = (right | left);
            Console.WriteLine("Original number: " + num + "  " + "Swapped number: " + result);

            //9.(ii). Find the resultant number is the number is a power of 2.
            if ((int)(Math.Ceiling((Math.Log(result) / Math.Log(2)))) == (int)(Math.Floor(((Math.Log(result) / Math.Log(2))))))
                Console.WriteLine("{0} is the power of two", result);
            else
                Console.WriteLine("{0} is not the power of two", result);
        }
    }
}
