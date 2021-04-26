﻿using System;

namespace Debug
{
    public class DebugMe
    {
        public static void Main(string[] args)
        {
			double budget = double.Parse(Console.ReadLine());
            int nightCnt = int.Parse(Console.ReadLine());
            double nightPrice = double.Parse(Console.ReadLine());
            int percent = int.Parse(Console.ReadLine());

            if (nightCnt >= 7)
            {
                nightPrice = nightPrice - nightPrice * 0.05;
            }

            double totalNightPrice = nightCnt * nightPrice;
            double additionalCosts = budget * (percent / 100);

            double totalPrice = totalNightPrice + additionalCosts;
            if (totalPrice < budget)
            {
                double moneyNeed = totalPrice - budget;
                Console.WriteLine($"{moneyNeed:F2} leva needed.");
            }
            else
            {
                double moneyLeft = budget - totalPrice;
                Console.WriteLine($"Ivanovi will be left with {moneyLeft:F2} leva after vacation.");
            }
        }
    }
}