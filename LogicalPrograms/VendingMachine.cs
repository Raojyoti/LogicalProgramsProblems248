using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class VendingMachine
    {
        public static int amount;
        public static void FindFewestNotes()
        {
            Console.WriteLine("Please enter amount you want to exchange with minimum notes:");
            amount = Convert.ToInt32(Console.ReadLine());
            int[] notes = new int[] { 1000, 500, 100, 50, 10, 5, 2, 1 };
            int[] noteCount = new int[8];
            for (int i = 0; i < noteCount.Length; i++) // Here we count notes 
            {
                if (amount >= notes[i])
                {
                    noteCount[i] = amount / notes[i];
                    amount = amount % notes[i];
                }
            }
            Console.WriteLine("Fewest notes are ->\n----------------------");
            Console.WriteLine("Notes  :  Number Of note ");
            for (int i = 0; i < noteCount.Length; i++)// Here we Print notes
            {
                if (noteCount[i] != 0)
                {
                    Console.WriteLine(notes[i] + "   :   " + noteCount[i]);
                }
            }
        }
    }
}
