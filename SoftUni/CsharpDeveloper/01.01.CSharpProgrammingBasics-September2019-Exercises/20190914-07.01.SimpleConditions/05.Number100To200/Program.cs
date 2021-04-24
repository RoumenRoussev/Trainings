using System;

namespace _05.Number100To200
{
    class Program
    {
        static void Main(string[] args)
        {
            int inputNum = int.Parse(Console.ReadLine());

            if (inputNum < 100)
            {
                Console.WriteLine("Less than 100");
            }
            else if (inputNum >= 100 && inputNum <= 200)
            {
                Console.WriteLine("Between 100 and 200");
            }
            else
            {
                Console.WriteLine("Greater than 200");
            }
        }
    }
}
