using System;

namespace _07.AreaOfFigures
{
    class Program
    {
        static void Main(string[] args)
        {
            string figure = Console.ReadLine().ToLower();
            double area = 0;

            if (figure.Equals("square"))
            {
                double side = double.Parse(Console.ReadLine());
                area = side * side;

            }
            else if (figure.Equals("rectangle"))
            {
                double a = double.Parse(Console.ReadLine());
                double b = double.Parse(Console.ReadLine());
                area = a * b;
            }
            else if (figure.Equals("circle"))
            {
                double radius = double.Parse(Console.ReadLine());
                area = Math.PI * radius * radius;
            }
            else if (figure.Equals("triangle"))
            {
                double side = double.Parse(Console.ReadLine());
                double h = double.Parse(Console.ReadLine());
                area = (side * h) / 2;
            }

            Console.WriteLine($"{area:F3}");
        }
    }
}
