using System;

namespace _06.CircleAreaAndPerimeter
{
    class Program
    {
        static void Main(string[] args)
        {
            double circleRadius = double.Parse(Console.ReadLine());

            double area = Math.PI * Math.Pow(circleRadius, 2);
            double perimeter = 2 * Math.PI * circleRadius;

            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perimeter:f2}");
        }
    }
}
