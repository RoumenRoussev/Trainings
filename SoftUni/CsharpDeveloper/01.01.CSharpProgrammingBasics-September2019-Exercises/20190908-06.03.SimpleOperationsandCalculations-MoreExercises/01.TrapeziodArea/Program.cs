using System;

namespace _01.TrapeziodArea
{
    class Program
    {
        static void Main(string[] args)
        {
            double sideTrapezoidA = double.Parse(Console.ReadLine());
            double sideTrapezoidB = double.Parse(Console.ReadLine());
            double heightTrapezoid = double.Parse(Console.ReadLine());

            double trapezoidArea = ((sideTrapezoidA + sideTrapezoidB) / 2) * heightTrapezoid;
            Console.WriteLine($"{trapezoidArea:F2}");
        }
    }
}
