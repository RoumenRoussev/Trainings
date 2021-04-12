using System;

namespace _06.SquareOfStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();
            for (int j = 0; j < n - 2; j++)
            {
                Console.Write("*");
                for (int i = 0; i < n - 2; i++)
                {
                    Console.Write(" ");
                }
                Console.WriteLine("*");
            }
            for (int i = 0; i < n; i++)
            {
                Console.Write("*");
            }
            Console.WriteLine();



            //var n = int.Parse(Console.ReadLine());
            //for (var k = 1; k <= n; k++)
            //{
            //for (var i = 1; i <= n; i++)
            //{
            //    if (((1 < k) && (k < n)) && ((1 < i) && (i < n)))
            //    {
            //        Console.Write(" ");
            //    }
            //    else
            //        Console.Write("*");
            //}
            //Console.WriteLine();




            //var n = int.Parse(Console.ReadLine());
            //string a = "";
            //string b = "";
            //for (int i = 0; i < n; i++)
            //{
            //    a = a + "*";
            //}
            //Console.WriteLine(a);
            //for (int k = 2; k <= n - 1; k++)
            //{
            //    b = b + " ";
            //}
            //for (int k = 2; k <= n - 1; k++)
            //{
            //    Console.WriteLine("*{0}*", b);
            //}
            //Console.WriteLine(a);
        }
        }
}
