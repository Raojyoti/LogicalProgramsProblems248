using System.Globalization;

namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Logical Programs\n------------------------------------");
            Console.WriteLine("Please select any option");
            Console.WriteLine("1.FindFibonacciSeries\n2.CheckPerfectNumber\n3.CheckPrimeNumber\n4.ReverseNumber\n5.TemperaturConversion\n6.GregorianCalendar\n7.FindMonthlyPayment\n8.FindElapsedTime\n13.Exit\n");
            int option = Convert.ToInt32(Console.ReadLine());
            switch (option)
            {
                case 1:
                    Console.Clear();
                    FibonacciSeries.FindFibonacciSeries();
                    break;
                case 2:
                    Console.Clear();
                    PerfectNumber.CheckPerfectNumber();
                    break;
                case 3:
                    Console.Clear();
                    PrimeNumber.CheckPrimeNumber();
                    break;
                case 4:
                    Console.Clear();
                    ReverseNumber.FindReverseNumber();
                    break;
                case 5:
                    Console.Clear();
                    TemperatureConversion.TemperaturConversionToFahrenheit();
                    TemperatureConversion.TemperaturConversionToCelsius();
                    break;
                case 6:
                    Console.Clear();
                    GregorianCalendar.DayOfWeek();
                    break;
                case 7:
                    Console.Clear();
                    MonthlyPayment.FindMonthlyPayment();
                    break;
                case 8:
                    Console.Clear();
                    Time.FindElapsedTime();
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