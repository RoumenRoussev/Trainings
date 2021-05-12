using System;

namespace _06.GodzillaVSKong
{
    class Program
    {
        static void Main(string[] args)
        {
            double budzhet = double.Parse(Console.ReadLine());
            int brStatisti = int.Parse(Console.ReadLine());
            double cenaOblekloEdinStatist = double.Parse(Console.ReadLine());
            double dekor = 0.1 * budzhet;
            double drehi = cenaOblekloEdinStatist * brStatisti;
            //if (brStatisti > 150) drehi = drehi * 0.1;
            if (brStatisti > 150) drehi = drehi * (1 - 0.1); // drehi = drehi * 0.1

            if ((dekor + drehi) > budzhet)
            {
                Console.WriteLine("Not enough money!");
                Console.WriteLine("Wingard needs {0:f2} leva more.", ((drehi + dekor) - budzhet));
            }
            else
            {
                Console.WriteLine("Action!");
                Console.WriteLine("Wingard starts filming with {0:f2} leva left.", (budzhet - (drehi + dekor)));
            }
        }
    }
}
