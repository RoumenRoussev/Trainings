using System;

namespace _05.DansingHall
{
    class Program
    {
        static void Main(string[] args)
        {
            double lengthHall = double.Parse(Console.ReadLine());
            double widthHall = double.Parse(Console.ReadLine());
            double wardrobeSide = double.Parse(Console.ReadLine());
            var hallArea = (lengthHall * 100) * (widthHall * 100);
            var wardrobe = (wardrobeSide * 100) * (wardrobeSide * 100);
            double bench = (hallArea / 10);
            double dancingfloor = hallArea - wardrobe - bench;
            double dancers = (dancingfloor / (40 + 7000));
            Console.WriteLine($"{Math.Floor(dancers)}");
        }
    }
}
