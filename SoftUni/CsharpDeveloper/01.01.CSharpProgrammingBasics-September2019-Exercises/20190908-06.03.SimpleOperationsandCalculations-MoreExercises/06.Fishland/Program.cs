using System;

namespace _06.Fishland
{
    class Program
    {
        static void Main(string[] args)
        {
            double marcelPricePerKg = double.Parse(Console.ReadLine());
            double spratPricePerKg = double.Parse(Console.ReadLine());
            double beltedBonitoKg = double.Parse(Console.ReadLine());
            double scadKg = double.Parse(Console.ReadLine());
            double clamsKg = double.Parse(Console.ReadLine());

            double beltedBonitoPricePerKg = marcelPricePerKg + (marcelPricePerKg * 0.6);
            double beltedBonitoIncome = beltedBonitoPricePerKg * beltedBonitoKg;

            double scadPricePerKg = spratPricePerKg + (spratPricePerKg * 0.8);
            double scadIncome = scadPricePerKg * scadKg;

            double totalIncome = scadIncome + beltedBonitoIncome + (clamsKg * 7.50);

            Console.WriteLine($"{totalIncome:f2}");
        }
    }
}
