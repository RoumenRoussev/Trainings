using System;

namespace _09.CelsiusToFahrenheit
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter the Temperature in Celsius(°C) : ");
            double celsius = double.Parse(Console.ReadLine());
            double faren = (celsius * 9) / 5 + 32;
            Console.WriteLine($"0Temperature in Fahrenheit is(°F) : {faren:F2}");
        }
    }
}
