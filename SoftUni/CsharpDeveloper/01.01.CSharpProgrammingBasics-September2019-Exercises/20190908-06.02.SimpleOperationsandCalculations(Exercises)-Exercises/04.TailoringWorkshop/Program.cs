using System;

namespace _04.TailoringWorkshop
{
    class Program
    {
        static void Main(string[] args)
        {
            //var tables = double.Parse(Console.ReadLine());
            //var weightTables = double.Parse(Console.ReadLine());
            //var widhtTables = double.Parse(Console.ReadLine());

            //var all = tables * (weightTables + 2 * 0.30) * (widhtTables + 2 * 0.30);
            //var centre = tables * (weightTables / 2) * (weightTables / 2);

            //var allofall1 = all * 7 + centre * 9;
            //var allofall2 = allofall1 * 1.85;

            //Console.WriteLine("{0:f2} USD", allofall1);
            //Console.WriteLine("{0:f2} BGN", allofall2);



            var tables = int.Parse(Console.ReadLine());
            var weightTables = double.Parse(Console.ReadLine());
            var widhtTables = double.Parse(Console.ReadLine());
                       
            var pokrivka = tables * (weightTables + 2 * 0.30) * (widhtTables + 2 * 0.30);
            var kareta = tables * (weightTables / 2) * (weightTables / 2);

            var dolars = pokrivka * 7 + kareta * 9;
            var leva = dolars * 1.85;

            Console.WriteLine("{0:f2} USD", dolars);
            Console.WriteLine("{0:f2} BGN", leva);
        }
    }
}
