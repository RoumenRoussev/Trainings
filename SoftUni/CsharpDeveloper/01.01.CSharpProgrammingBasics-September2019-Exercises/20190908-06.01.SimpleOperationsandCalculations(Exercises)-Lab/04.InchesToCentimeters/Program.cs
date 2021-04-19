using System;

namespace _04.InchesToCentimeters
{
    class Program
    {
        static void Main(string[] args)
        {
            double centimetre = double.Parse(Console.ReadLine());
            double inch = 2.54;
            Console.WriteLine($"{centimetre * inch:F2}");
        }
    }
}
