using System;

namespace _03._2DRectangleArea
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());


            var width = Math.Abs(x1 - x2);
            var height = Math.Abs(y1 - y2);
            var area = width * height;
            var perimeter = 2 * (width + height);
            Console.WriteLine($"{area:f2}");
            Console.WriteLine($"{perimeter:f2}");
        }
    }
}
