using System;

namespace _08.SkiTrip_
{
    class Program
    {
        static void Main(string[] args)
        {
            int days = int.Parse(Console.ReadLine());
            string roomType = Console.ReadLine();
            string raiting = Console.ReadLine();

            int nights = days - 1;
            int discount = 0;
            double pricePerNight = 0;

            if (roomType == "apartment")
            {
                pricePerNight = 25;
                if (days >= 1 && days < 10)
                {
                    discount = 30;
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = 35;
                }
                else if (days > 15)
                {
                    discount = 50;
                }
            }
            else if (roomType == "president apartment")
            {
                pricePerNight = 35;
                if (days >= 1 && days < 10)
                {
                    discount = 10;
                }
                else if (days >= 10 && days <= 15)
                {
                    discount = 15;
                }
                else if (days > 15)
                {
                    discount = 20;
                }
            }
            else if (roomType == "room for one person")
            {
                pricePerNight = 18;
            }
            
            double priceWithoutDiscount = nights * pricePerNight;
            double totalPrice = priceWithoutDiscount - (priceWithoutDiscount * (discount / 100.0));


            if (raiting == "positive")
            {
                totalPrice = totalPrice * 1.25;
            }
            else if (raiting == "negative")
            {
                totalPrice = totalPrice * 0.9;
            }

            Console.WriteLine($"{totalPrice:F2}");
        }
    }
}
