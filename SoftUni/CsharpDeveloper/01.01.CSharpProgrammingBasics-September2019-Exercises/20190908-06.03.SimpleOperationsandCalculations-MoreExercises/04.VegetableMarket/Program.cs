using System;

namespace _04.VegetableMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            double priceVeges = double.Parse(Console.ReadLine());
            double priceFruits = double.Parse(Console.ReadLine());

            double kgVeges = double.Parse(Console.ReadLine());
            double kgFruits = double.Parse(Console.ReadLine());

            double valEUR = 1.94;
            double total = ((priceVeges * kgVeges) + (priceFruits * kgFruits)) / valEUR;

            Console.WriteLine($"{total:F2}");
        }
    }
}
