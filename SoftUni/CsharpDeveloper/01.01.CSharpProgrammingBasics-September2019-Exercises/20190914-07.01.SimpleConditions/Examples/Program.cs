using System;

namespace Examples
{
    class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            double withdrawAmount = double.Parse(Console.ReadLine());

            bool canWithdraw = budget >= withdrawAmount;

            if (canWithdraw)
            {
                Console.WriteLine("Success!");
            }
            else
            {
                Console.WriteLine("Falls!");
            }
            Console.WriteLine("Good bye!");

            //int a = 5;
            //int b = 10;
            //Console.WriteLine(b == 2 * a);



            //var ocenka = double.Parse(Console.ReadLine());
            //if (ocenka >= 5.50)
            //{
            //    Console.WriteLine("Excellent!");
            //}
        }
    }
}
