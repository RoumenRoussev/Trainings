using System;

namespace _06.FruitShop
{
    class Program
    {
        static void Main(string[] args)
        {
            //string fruit = Console.ReadLine();
            //string day = Console.ReadLine();
            //double quantity = double.Parse(Console.ReadLine());

            //double price = 0.0;

            //if (day == "Monday" ||
            //    day == "Tuesday" ||
            //    day == "Wednesday" ||
            //    day == "Thursday" ||
            //    day == "Friday")
            //{
            //    if (fruit == "banana")
            //    {
            //        price = 2.50;
            //    }
            //    else if (fruit == "apple")
            //    {
            //        price = 1.20;
            //    }
            //    else if (fruit == "orange")
            //    {
            //        price = 0.85;
            //    }
            //    else if (fruit == "grapefruit")
            //    {
            //        price = 1.45;
            //    }
            //    else if (fruit == "kiwi")
            //    {
            //        price = 2.70;
            //    }
            //    else if (fruit == "pineapple")
            //    {
            //        price = 5.50;
            //    }
            //    else if (fruit == "grapes")
            //    {
            //        price = 3.85;
            //    }
            //    else
            //    {
            //        Console.WriteLine("error");
            //    }
            //}
            //else if (day == "Saturday" || day == "Sunday")
            //{
            //    if (fruit == "banana")
            //    {
            //        price = 2.70;
            //    }
            //    else if (fruit == "apple")
            //    {
            //        price = 1.25;
            //    }
            //    else if (fruit == "orange")
            //    {
            //        price = 0.90;
            //    }
            //    else if (fruit == "grapefruit")
            //    {
            //        price = 1.60;
            //    }
            //    else if (fruit == "kiwi")
            //    {
            //        price = 3.00;
            //    }
            //    else if (fruit == "pineapple")
            //    {
            //        price = 5.60;
            //    }
            //    else if (fruit == "grapes")
            //    {
            //        price = 4.20;
            //    }
            //    else
            //    {
            //        Console.WriteLine("error");
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("error");
            //}
            //double total = quantity * price;
            //Console.WriteLine($"{total:F2}");





            //"Monday" "Tuesday", "Wednesday", "Thursday", "Friday"




            string fruit = Console.ReadLine();
            string day = Console.ReadLine();
            decimal quantity = decimal.Parse(Console.ReadLine());

            decimal price = 0;

            if ((day == "Monday") ||
                (day == "Tuesday") ||
                (day == "Wednesday") ||
                (day == "Thursday") ||
                (day == "Friday"))
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.50m;
                        break;
                    case "apple":
                        price = 1.20m;
                        break;
                    case "orange":
                        price = 0.85m;
                        break;
                    case "grapefruit":
                        price = 1.45m;
                        break;
                    case "kiwi":
                        price = 2.70m;
                        break;
                    case "pineapple":
                        price = 5.50m;
                        break;
                    case "grapes":
                        price = 3.85m;
                        break;
                    default:
                        Console.WriteLine("error");
                        return;
                }
                decimal total = quantity * price;
                Console.WriteLine($"{total:F2}");
            }
            else if ((day == "Saturday") ||
                     (day == "Sunday"))
            {
                switch (fruit)
                {
                    case "banana":
                        price = 2.70m;
                        break;
                    case "apple":
                        price = 1.25m;
                        break;
                    case "orange":
                        price = 0.90m;
                        break;
                    case "grapefruit":
                        price = 1.60m;
                        break;
                    case "kiwi":
                        price = 3.00m;
                        break;
                    case "pineapple":
                        price = 5.60m;
                        break;
                    case "grapes":
                        price = 4.20m;
                        break;
                    default:
                        Console.WriteLine("error");
                        return; // If there is "break" the result will be "error" and on new line it will show "0.00"
                }
                decimal total = quantity * price;
                Console.WriteLine($"{total:F2}");
            }
            else
            {
                Console.WriteLine("error");
            }
        }
    }
}
