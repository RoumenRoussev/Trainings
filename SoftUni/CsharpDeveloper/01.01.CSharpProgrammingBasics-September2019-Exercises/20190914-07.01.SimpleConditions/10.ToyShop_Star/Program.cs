using System;

namespace _10.ToyShop_Star
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal vacantionPrice = decimal.Parse(Console.ReadLine());
            int puzels = int.Parse(Console.ReadLine());
            int dolls = int.Parse(Console.ReadLine());
            int bears = int.Parse(Console.ReadLine());
            int minions = int.Parse(Console.ReadLine());
            int trucks = int.Parse(Console.ReadLine());

            decimal puzelsPrice = 2.60M;
            decimal dollsPrice = 3.00M;
            decimal bearsPrice = 4.10M;
            decimal minionsPrice = 8.20M;
            decimal trucksPrice = 2.00M;

            decimal puzelsTotal = puzels * puzelsPrice;
            decimal dollsTotal = dolls * dollsPrice;
            decimal bearsTotal = bears * bearsPrice;
            decimal minionsTotal = minions * minionsPrice;
            decimal trucksTotal = trucks * trucksPrice;

            decimal totalToysPrice = puzelsTotal + dollsTotal + bearsTotal + minionsTotal + trucksTotal;
            decimal totalToysPcs = puzels + dolls + bears + minions + trucks;

            if (totalToysPcs >= 50)
            {
                decimal billOff = totalToysPrice - (totalToysPrice * 0.25M);
                decimal rent = billOff - (billOff * 0.10M);

                if (rent >= vacantionPrice)
                {
                    decimal total = rent - vacantionPrice;
                    Console.WriteLine($"Yes! {total:f2} lv left.");
                }
                else
                {
                    decimal total = vacantionPrice - rent;
                    Console.WriteLine($"Not enough money! {total:f2} lv needed.");
                }
            }
            else if (totalToysPcs < 50)
            {
                decimal rent = totalToysPrice - (totalToysPrice * 0.10M);
                if (rent >= vacantionPrice)
                {
                    decimal total = rent - vacantionPrice;
                    Console.WriteLine($"Yes! {total:f2} lv left.");
                }
                else
                {
                    decimal total = vacantionPrice - rent;
                    Console.WriteLine($"Not enough money! {total:f2} lv needed.");
                }
            }
        }
    }
}
