using System;

namespace _01.TrainingLab
{
    class Program
    {
        static void Main(string[] args)
        {
            var a = Math.Floor((double.Parse(Console.ReadLine()) * 100) / 120);
            var b = Math.Floor((double.Parse(Console.ReadLine()) * 100 - 100) / 70);
            Console.WriteLine(a * b - 3);
        }
    }
}
