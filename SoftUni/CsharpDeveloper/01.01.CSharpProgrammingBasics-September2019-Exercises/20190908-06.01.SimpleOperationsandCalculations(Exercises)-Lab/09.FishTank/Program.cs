using System;

namespace _09.FishTank
{
    class Program
    {
        static void Main(string[] args)
        {
            int length = int.Parse(Console.ReadLine());
            int width = int.Parse(Console.ReadLine());
            int height = int.Parse(Console.ReadLine());
            double percentage = double.Parse(Console.ReadLine());
            double persentageCount = percentage * 0.01;
            double litre = 1.0 / 1000.0;
            int volume = length * width * height;
            double litresSum = volume * litre;
            double litresVolume = litresSum * (1 - persentageCount);
            Console.WriteLine($"{litresVolume:f3}");
        }
    }
}
