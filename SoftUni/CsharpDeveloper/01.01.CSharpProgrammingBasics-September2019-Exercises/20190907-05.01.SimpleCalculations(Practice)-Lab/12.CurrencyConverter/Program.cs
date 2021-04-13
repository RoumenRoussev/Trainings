using System;

namespace _12.CurrencyConverter
{
    class Program
    {
        static void Main(string[] args)
        {
            var amount = double.Parse(Console.ReadLine());
            var currencyFrom = Console.ReadLine();
            var currencyTo = Console.ReadLine();
            if (currencyFrom == "BGN" && currencyTo == "USD") Console.WriteLine(Math.Round((amount / 1.79549), 2));
            if (currencyFrom == "BGN" && currencyTo == "EUR") Console.WriteLine(Math.Round((amount / 1.95583), 2));
            if (currencyFrom == "BGN" && currencyTo == "GBP") Console.WriteLine(Math.Round((amount / 2.53405), 2));
            if (currencyFrom == "USD" && currencyTo == "BGN") Console.WriteLine(Math.Round((amount * 1.79549), 2));
            if (currencyFrom == "USD" && currencyTo == "EUR") Console.WriteLine(Math.Round(((amount * 1.79549) / 1.95583), 2));
            if (currencyFrom == "USD" && currencyTo == "GBP") Console.WriteLine(Math.Round(((amount * 1.79549) / 2.53405), 2));
            if (currencyFrom == "EUR" && currencyTo == "USD") Console.WriteLine(Math.Round(((amount * 1.95583) / 1.79549), 2));
            if (currencyFrom == "EUR" && currencyTo == "BGN") Console.WriteLine(Math.Round((amount * 1.95583), 2));
            if (currencyFrom == "EUR" && currencyTo == "GBP") Console.WriteLine(Math.Round(((amount * 1.95583) / 2.53405), 2));
            if (currencyFrom == "GBP" && currencyTo == "USD") Console.WriteLine(Math.Round(((amount * 2.53405) / 1.79549), 2));
            if (currencyFrom == "GBP" && currencyTo == "EUR") Console.WriteLine(Math.Round(((amount * 2.53405) / 1.95583), 2));
            if (currencyFrom == "GBP" && currencyTo == "BGN") Console.WriteLine(Math.Round((amount * 2.53405), 2));



            //double sum = double.Parse(Console.ReadLine());
            //var valutaVhod = Console.ReadLine();
            //var valutaIzhod = Console.ReadLine();
            //double valUSD = 1.79549;
            //double valEUR = 1.95583;
            //double valGBP = 2.53405;
            //double valBGN = 1;
            //var valutaUSD = "USD";
            //var valutaEUR = "EUR";
            //var valutaGBP = "GBP";
            //var valutaBGN = "BGN";
            //double promenliva1 = 1;
            //double promenliva2 = 2;
            //string promenliva3 = null;

            //if (valutaVhod == valutaUSD) { promenliva1 = valUSD; }
            //if (valutaVhod == valutaEUR) { promenliva1 = valEUR; }
            //if (valutaVhod == valutaGBP) { promenliva1 = valGBP; }
            //if (valutaVhod == valutaBGN) { promenliva1 = valBGN; }

            //if (valutaIzhod == valutaUSD) { promenliva2 = valUSD; }
            //if (valutaIzhod == valutaEUR) { promenliva2 = valEUR; }
            //if (valutaIzhod == valutaGBP) { promenliva2 = valGBP; }
            //if (valutaIzhod == valutaBGN) { promenliva2 = valBGN; }

            //if (valutaIzhod == valutaUSD) { promenliva3 = valutaUSD; }
            //if (valutaIzhod == valutaEUR) { promenliva3 = valutaEUR; }
            //if (valutaIzhod == valutaGBP) { promenliva3 = valutaGBP; }
            //if (valutaIzhod == valutaBGN) { promenliva3 = valutaBGN; }

            //var result = sum * promenliva1 / promenliva2;
            //Console.WriteLine(Math.Round(result, 2) + " " + promenliva3);



            //var value = double.Parse(Console.ReadLine());
            //var input = Console.ReadLine().ToUpper();
            //var output = Console.ReadLine().ToUpper();
            //if (input == "USD") value *= 1.79549;
            //else if (input == "EUR") value *= 1.95583;
            //else if (input == "GBP") value *= 2.53405;
            //else if (input == "BGN") value *= 1;

            //if (output == "USD") value /= 1.79549;
            //else if (output == "EUR") value /= 1.95583;
            //else if (output == "GBP") value /= 2.53405;
            //else if (output == "BGN") value /= 1;

            //Console.WriteLine(Math.Round(value, 2) + " " + output);
        }
    }
}
