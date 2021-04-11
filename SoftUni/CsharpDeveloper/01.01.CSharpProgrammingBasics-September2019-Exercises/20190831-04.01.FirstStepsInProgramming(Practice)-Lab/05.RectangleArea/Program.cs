using System;

namespace _05.RectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("a=");
            double a = double.Parse(Console.ReadLine());
            Console.Write("b=");
            double b = double.Parse(Console.ReadLine());
            double area = a * b;
            Console.WriteLine("Area = " + area);
        }
    }
}
