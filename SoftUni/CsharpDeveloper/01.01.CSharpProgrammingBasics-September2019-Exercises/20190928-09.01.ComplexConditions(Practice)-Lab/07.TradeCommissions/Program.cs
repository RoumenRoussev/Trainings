using System;

namespace _07.TradeCommissions
{
    class Program
    {
        static void Main(string[] args)
        {
            string town = Console.ReadLine();
            decimal sales = decimal.Parse(Console.ReadLine());
            decimal comission = 0;

            if (town == "Sofia")
            {
                if (sales > 10000)
                {
                    comission = sales * 0.12m;
                }
                else if (sales > 1000)
                {
                    comission = sales * 0.08m;
                }
                else if (sales > 500)
                {
                    comission = sales * 0.07m;
                }
                else if (sales > 0)
                {
                    comission = sales * 0.05m;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else if (town == "Varna")
            {
                if (sales > 10000)
                {
                    comission = sales * 0.13m;
                }
                else if (sales > 1000)
                {
                    comission = sales * 0.1m;
                }
                else if (sales > 500)
                {
                    comission = sales * 0.075m;
                }
                else if (sales > 0)
                {
                    comission = sales * 0.045m;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }

            }
            else if (town == "Plovdiv")
            {
                if (sales > 10000)
                {
                    comission = sales * 0.145m;
                }
                else if (sales > 1000)
                {
                    comission = sales * 0.12m;
                }
                else if (sales > 500)
                {
                    comission = sales * 0.08m;
                }
                else if (sales > 0)
                {
                    comission = sales * 0.055m;
                }
                else
                {
                    Console.WriteLine("error");
                    return;
                }
            }
            else
            {
                Console.WriteLine("error");
                return;
            }

            Console.WriteLine($"{comission:f2}");




        //string city = Console.ReadLine();
        //decimal salesVolume = decimal.Parse(Console.ReadLine());

        //decimal salesCommission = 0;

        //if (city == "Sofia")
        //{
        //    if (salesVolume >= 0 && salesVolume <= 500)
        //    {
        //        salesCommission = 0.05m;
        //    }
        //    else if (salesVolume > 500 && salesVolume <= 1000)
        //    {
        //        salesCommission = 0.07m;
        //    }
        //    else if (salesVolume > 1000 && salesVolume <= 10000)
        //    {
        //        salesCommission = 0.08m;
        //    }
        //    else if (salesVolume > 10000)
        //    {
        //        salesCommission = 0.12m;
        //    }
        //    else
        //    {
        //        Console.WriteLine("error");
        //        return;
        //    }
        //}
        //else if (city == "Varna")
        //{
        //    if (salesVolume >= 0 && salesVolume <= 500)
        //    {
        //        salesCommission = 0.045m;
        //    }
        //    else if (salesVolume > 500 && salesVolume <= 1000)
        //    {
        //        salesCommission = 0.075m;
        //    }
        //    else if (salesVolume > 1000 && salesVolume <= 10000)
        //    {
        //        salesCommission = 0.10m;
        //    }
        //    else if (salesVolume > 10000)
        //    {
        //        salesCommission = 0.13m;
        //    }
        //    {
        //        Console.WriteLine("error");
        //        return;
        //    }
        //}
        //else if (city == "Plovdiv")
        //{
        //    if (salesVolume >= 0 && salesVolume <= 500)
        //    {
        //        salesCommission = 0.055m;
        //    }
        //    else if (salesVolume > 500 && salesVolume <= 1000)
        //    {
        //        salesCommission = 0.08m;
        //    }
        //    else if (salesVolume > 1000 && salesVolume <= 10000)
        //    {
        //        salesCommission = 0.12m;
        //    }
        //    else if (salesVolume > 10000)
        //    {
        //        salesCommission = 0.145m;
        //    }
        //    {
        //        Console.WriteLine("error");
        //        return;
        //    }
        //}
        //else
        //{
        //    Console.WriteLine("error");
        //    return; // If there is "break" the result will be "error" and on new line it will show "0.00"
        //}

        //decimal total = salesVolume * salesCommission;
        //Console.WriteLine($"{total:F2}");
        }
    }
}
