using System;

namespace _08.YardGreening_YardsLandscaping_
{
    class Program
    {
        static void Main(string[] args)
        {
            double squareMetre = double.Parse(Console.ReadLine());
            double priceSquareMetre = 7.61;
            double sumPrice = squareMetre * priceSquareMetre;
            double discount = sumPrice * 0.18;
            double finalPrice = sumPrice - discount;

            Console.WriteLine($"The final price is: {finalPrice:F2} lv.");
            Console.WriteLine($"The discount is: {discount:F2} lv.");
        }
    }
}
