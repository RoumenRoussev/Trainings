using System;

namespace _03.CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Enter the Temperature in Celsius(°C) : ");
            // Console.WriteLine();
            double celsius = double.Parse(Console.ReadLine());
            double fahrenheit = (celsius * 9) / 5 + 32;
            Console.WriteLine($"{fahrenheit:F2}");
            //Console.WriteLine($"Temperature in Fahrenheit is(°F) : {faren:F2}");
        }
    }
}
