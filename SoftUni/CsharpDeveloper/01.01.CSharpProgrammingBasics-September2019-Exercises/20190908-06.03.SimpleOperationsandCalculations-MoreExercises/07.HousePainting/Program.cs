using System;

namespace _07.HousePainting
{
    class Program
    {
        static void Main(string[] args)
        {
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());
            var h = double.Parse(Console.ReadLine());

            if (x >= 2 && x <= 100 && y >= 2 && y <= 100 && h >= 2 && h <= 100)
            {
                var wallArea = ((x * x - 1.2 * 2) + x * x + 2 * (x * y - 1.5 * 1.5));
                var roofArea = 2 * x * y + 2 * x * h / 2;

                var green = wallArea / 3.4;
                var red = roofArea / 4.3;

                Console.WriteLine($"{green:f2}");
                Console.WriteLine($"{red:f2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
