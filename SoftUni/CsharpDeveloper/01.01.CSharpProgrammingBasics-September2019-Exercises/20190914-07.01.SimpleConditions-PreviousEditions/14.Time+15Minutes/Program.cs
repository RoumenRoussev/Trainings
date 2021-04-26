using System;

namespace _14.Time_15Minutes
{
    class Program
    {
        static void Main(string[] args)
        {
            int hours = int.Parse(Console.ReadLine());
            int minutes = int.Parse(Console.ReadLine());

            int totalTime = (hours * 60) + minutes + 15;
            int hoursAfter = totalTime / 60;

            if (hoursAfter == 24)
            {
                hoursAfter = 00;
            }

            Console.Write(hoursAfter);

            if (totalTime % 60 < 9)
            {
                Console.Write(":0{0}", totalTime % 60);
            }
            else
            {
                Console.Write(":{0}", totalTime % 60);
            }
        }
    }
}
