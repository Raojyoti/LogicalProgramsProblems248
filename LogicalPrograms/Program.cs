using System.Globalization;

namespace LogicalPrograms
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to the Logical Programs\n------------------------------------");
            Console.WriteLine("Please select any option");
            Console.WriteLine("1.FindFibonacciSeries\n2.CheckPerfectNumber\n3.CheckPrimeNumber\n4.ReverseNumber\n5.TemperaturConversion\n6.GregorianCalendar\n7.FindMonthlyPayment\n8.FindElapsedTime\n9.SwapNibbles\n10.FindFewestNotes\n11.ComputeSqrtOfNonnegativeNumber\n12.DecimalToBinayRepresentation\n13.FindRandomNumNeedToGenerateCouponNumber\n14.Exit\n");
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
                case 9:
                    Console.Clear();
                    Binary.SwapNibbles();
                    break;
                case 10:
                    Console.Clear();
                    VendingMachine.FindFewestNotes();
                    break;
                case 11:
                    Console.Clear();
                   NewtonsMethod.Sqrt();
                    break;
                case 12:
                    Console.Clear();
                    BinaryRepresentation.DecToBinary();
                    break;
                case 13:
                    Console.Clear();
                    CouponNumbers.FindRandomNumNeedToGenerateCouponNumber();
                    break;
                case 14:
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