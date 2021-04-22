using System;

namespace _09.WeatherForecast_Part2
{
    class Program
    {
        static void Main(string[] args)
        {
            double degree = double.Parse(Console.ReadLine());
            if (degree >= 26.00 && degree <= 35.00)
            {
                Console.WriteLine("Hot");
            }
            if (degree >= 20.1 && degree <= 25.9)
            {
                Console.WriteLine("Warm");
            }
            if (degree >= 15.00 && degree <= 20.00)
            {
                Console.WriteLine("Mild");
            }
            if (degree >= 12.00 && degree <= 14.9)
            {
                Console.WriteLine("Cool");
            }
            if (degree >= 5.00 && degree <= 11.9)
            {
                Console.WriteLine("Cold");
            }
            if (degree < 5.00 || degree > 35.00)

            {
                Console.WriteLine("unknown");
            }
        }
    }
}
