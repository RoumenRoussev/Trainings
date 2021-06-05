using System;

namespace _02.SmallShop_switch_case
{
    class Program
    {
        static void Main(string[] args)
        {
            string product = Console.ReadLine();
            string city = Console.ReadLine();
            double qantity = double.Parse(Console.ReadLine());
            double productPrice = 0;

            switch (city)
            {
                case "Sofia":
                    switch (product)
                    {
                        case "coffee":
                            productPrice = 0.50;
                            break;
                        case "water":
                            productPrice = 0.80;
                            break;
                        case "beer":
                            productPrice = 1.20;
                            break;
                        case "sweets":
                            productPrice = 1.45;
                            break;
                        case "peanuts":
                            productPrice = 1.60;
                            break;
                    }

                    break;
                case "Plovdiv":
                    switch (product)
                    {
                        case "coffee":
                            productPrice = 0.40;
                            break;
                        case "water":
                            productPrice = 0.70;
                            break;
                        case "beer":
                            productPrice = 1.15;
                            break;
                        case "sweets":
                            productPrice = 1.30;
                            break;
                        case "peanuts":
                            productPrice = 1.50;
                            break;
                    }

                    break;
                case "Varna":
                    switch (product)
                    {
                        case "coffee":
                            productPrice = 0.45;
                            break;
                        case "water":
                            productPrice = 0.70;
                            break;
                        case "beer":
                            productPrice = 1.10;
                            break;
                        case "sweets":
                            productPrice = 1.35;
                            break;
                        case "peanuts":
                            productPrice = 1.55;
                            break;
                    }

                    break;
            }

            double totalPrice = productPrice * qantity;
            Console.WriteLine(totalPrice);
        }
    }
}
