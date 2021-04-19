using System;

namespace _07.PetShop
{
    class Program
    {
        static void Main(string[] args)
        {
            double foodDogs = 2.50;
            double foodRestDogs = 4.00;
            int numDogs = int.Parse(Console.ReadLine());
            int numRestDogs = int.Parse(Console.ReadLine());
            double totalDogs = foodDogs * numDogs;
            double totalRestDogs = foodRestDogs * numRestDogs;
            double total = totalDogs + totalRestDogs;
            Console.WriteLine($"{total:F2} lv.");
        }
    }
}
