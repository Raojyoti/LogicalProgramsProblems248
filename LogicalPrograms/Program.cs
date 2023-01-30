using System.Globalization;

namespace LogicalPrograms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Logical Programs\n------------------------------------");
            Console.WriteLine("Please select any option");
            Console.WriteLine("1.FindFibonacciSeries\n13.Exit\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Clear();
                    FibonacciSeries.FindFibonacciSeries();
                    break;
                case 13:
                    Console.Clear();
                    break;
                default:
                    Console.Clear();
                    Console.WriteLine("Please select only given option");
                    break;
            }
            Console.ReadLine();
        }
    }
}