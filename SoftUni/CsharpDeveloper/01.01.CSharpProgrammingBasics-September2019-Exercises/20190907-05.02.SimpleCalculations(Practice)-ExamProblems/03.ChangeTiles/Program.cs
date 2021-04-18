using System;

namespace _03.ChangeTiles
{
    class Program
    {
        static void Main(string[] args)
        {
            int lengthArea = int.Parse(Console.ReadLine());
            double widthTile = double.Parse(Console.ReadLine());
            double lengthTile = double.Parse(Console.ReadLine());
            int widthBench = int.Parse(Console.ReadLine());
            int lengthBench = int.Parse(Console.ReadLine());



            int areaToRepair = widthBench * lengthBench;

            double tiles = areaToRepair / (widthTile * lengthTile);
            double time = tiles * 0.2;
            Console.WriteLine(tiles);
            Console.WriteLine(time);



            //double area = widthFloor * lengthFloor;
            //double tileArea = sideTriangle * (heightTriangle / 2);
            //double tilesNeeded = Math.Ceiling(area / tileArea) + 5;
            //double totalCost = (tilesNeeded * pricePerTile) + workerPay;

            //if (money >= totalCost)
            //{
            //    Console.WriteLine("{0:F2} lv left.", money - totalCost);
            //}
            //else
            //{
            //    Console.WriteLine("You'll need {0:F2} lv more.", totalCost - money);
            //}



            //double moneyForTiles = double.Parse(Console.ReadLine());
            //double widthFloor = double.Parse(Console.ReadLine());
            //double heightFloor = double.Parse(Console.ReadLine());
            //double sizeTriangle = double.Parse(Console.ReadLine());
            //double highTriangle = double.Parse(Console.ReadLine());
            //double priceOneTiles = double.Parse(Console.ReadLine());
            //double priceForRepair = double.Parse(Console.ReadLine());

            //double areaFloor = widthFloor * heightFloor;
            //double areaTiles = (sizeTriangle * highTriangle) / 2;
            //double countTiles = Math.Ceiling((areaFloor / areaTiles)) + 5;
            //double allMoney = (countTiles * priceOneTiles) + priceForRepair;

            //if (allMoney > moneyForTiles)
            //{
            //    Console.WriteLine("You'll need {0:f2} lv more.", allMoney - moneyForTiles);
            //}
            //else
            //{
            //    Console.WriteLine("{0:f2} lv left.", moneyForTiles - allMoney);
            //}
        }
    }
}
