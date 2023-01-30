using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LogicalPrograms
{
    public class TemperatureConversion
    {
        public static float F, C, fahrenheit, celsius;
        //5.Convert Celsius to Fahrenheit and Fahrenheit to Celsius
        public static void TemperaturConversionToFahrenheit()
        {
            Console.WriteLine("Enter value for Celsius: ");
            C = Convert.ToInt32(Console.ReadLine());
            fahrenheit = (C * 9 / 5) + 32;
            Console.WriteLine("Celsius to Fahrenheit values: {0} \n-------------------------------------", fahrenheit);
        }
        public static void TemperaturConversionToCelsius()
        {
            Console.WriteLine("Enter value for Fahrenheit: ");
            F = Convert.ToInt32(Console.ReadLine());
            celsius = (F - 32) * 5 / 9;
            Console.WriteLine("Fahrenheit to Celsius values: {0} \n--------------------------------------", celsius);
        }
    }
}
