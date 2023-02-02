using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace LogicalPrograms
{
    public class BinaryRepresentation
    {
        public static int number;
        //12.To compute the binary representation of n number.
        public static void DecToBinary()
        {
            Console.WriteLine("Please enter number that you want to represent in Binary:");
            number = Convert.ToInt32(Console.ReadLine());
            int[] binaryNum = new int[32];
            int i = 0;
            while (number > 0)
            {
                binaryNum[i] = number % 2;
                number = number / 2;
                i++;
            }
            for (int j = i - 1; j >= 0; j--)
            {
                Console.Write(binaryNum[j]);
            }
        }
    }
}
