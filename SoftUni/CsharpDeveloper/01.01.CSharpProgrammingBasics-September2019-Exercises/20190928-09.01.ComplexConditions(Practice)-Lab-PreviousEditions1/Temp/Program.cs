using System;

namespace Temp
{
    class Program
    {
        static void Main(string[] args)
        {
            string city = Console.ReadLine(); 
            string product = Console.ReadLine();
            double qantity = double.Parse(Console.ReadLine());
            double productPrice = 0;

            if (city == "Sofia")
            {
                if (product == "coffee")
                {
                    productPrice = 0.50;
                }
                else if (product == "water")
                {
                    productPrice = 0.80;
                }
                else if (product == "beer")
                {
                    productPrice = 1.20;
                }
                else if (product == "sweets")
                {
                    productPrice = 1.45;
                }
                else if (product == "peanuts")
                {
                    productPrice = 1.60;
                }
            }
            else if (city == "Plovdiv")
            {
                if (product == "coffee")
                {
                    productPrice = 0.40;
                }
                else if (product == "water")
                {
                    productPrice = 0.70;
                }
                else if (product == "beer")
                {
                    productPrice = 1.15;
                }
                else if (product == "sweets")
                {
                    productPrice = 1.30;
                }
                else if (product == "peanuts")
                {
                    productPrice = 1.50;
                }
            }
            else if (city == "Varna")
            {
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
            }

            double totalPrice = productPrice * qantity;
            Console.WriteLine(totalPrice);

            //else if (city == "Varna")
            //{
            //    if (product == "coffee")
            //    {
            //        Console.WriteLine(qantity * 0.45);
            //    }
            //    else if (product == "water")
            //    {
            //        Console.WriteLine(qantity * 0.70);
            //    }
            //    else if (product == "beer")
            //    {
            //        Console.WriteLine(qantity * 1.10);
            //    }
            //    else if (product == "sweets")
            //    {
            //        Console.WriteLine(qantity * 1.35);
            //    }
            //    else if (product == "peanuts")
            //    {
            //        Console.WriteLine(qantity * 1.55);
            //    }
            //}
        }
    }
}
