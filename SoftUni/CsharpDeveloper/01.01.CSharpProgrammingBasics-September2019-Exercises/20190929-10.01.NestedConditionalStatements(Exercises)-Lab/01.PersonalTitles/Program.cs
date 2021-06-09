using System;

namespace _01.PersonalTitles
{
    class Program
    {
        static void Main(string[] args)
        {
            double age = double.Parse(Console.ReadLine());
            char gender = char.Parse(Console.ReadLine());

            if (gender == 'f')
            {
                if (age < 16)
                {
                    Console.WriteLine("Miss");
                }
                else
                {
                    Console.WriteLine("Ms.");
                }
            }
            else if (gender == 'm')
            {
                if (age < 16)
                {
                    Console.WriteLine("Master");
                }
                else
                {
                    Console.WriteLine("Mr.");
                }
            }



            //if (gender == 'f' && age < 16)
            //{
            //    Console.WriteLine("Miss");
            //}
            //else if (gender == 'f' && age >= 16)
            //{
            //    Console.WriteLine("Ms.");
            //}
            //else if (gender == 'm' && age >= 16)
            //{
            //    Console.WriteLine("Master");
            //}
            //else if (gender == 'm' && age >= 16)
            //{
            //    Console.WriteLine("Mr.");
            //}
        }
    }
}
