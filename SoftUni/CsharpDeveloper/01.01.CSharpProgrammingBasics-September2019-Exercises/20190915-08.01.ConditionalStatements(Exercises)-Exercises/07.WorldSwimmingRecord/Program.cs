using System;

namespace _07.WorldSwimmingRecord
{
    class Program
    {
        static void Main(string[] args)
        {
            double recordSec = double.Parse(Console.ReadLine());
            double distanceMeters = double.Parse(Console.ReadLine());
            double timeSec = double.Parse(Console.ReadLine());
            double distanceSec = distanceMeters * timeSec;
            double bonusTime = Math.Floor(distanceMeters / 15) * 12.5;
            double allTime = distanceSec + bonusTime;
            if (recordSec > allTime)
            {
                double needTime = distanceSec + bonusTime;
                Console.WriteLine($"Yes, he succeeded! The new world record is {needTime:F2} seconds.");
            }
            else
            {
                double left = Math.Abs(allTime - recordSec);
                Console.WriteLine($"No, he failed! He was {left:F2} seconds slower.");
            }
        }
    }
}
