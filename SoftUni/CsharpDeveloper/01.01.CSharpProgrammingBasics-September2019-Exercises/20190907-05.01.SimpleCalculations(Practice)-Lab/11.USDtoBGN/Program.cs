using System;

namespace _11.USDtoBGN
{
    class Program
    {
        static void Main(string[] args)
        {
            double USD = double.Parse(Console.ReadLine());
            double BGN = USD * 1.79549;
            Console.WriteLine(Math.Round(USD * 1.79549, 2));

            //Console.Write("USD = ");
            //double usd = double.Parse(Console.ReadLine());
            //double bgn = usd * 1.79549;
            //Console.WriteLine("BGN = " + Math.Round(bgn, 2));
        }
    }
}
