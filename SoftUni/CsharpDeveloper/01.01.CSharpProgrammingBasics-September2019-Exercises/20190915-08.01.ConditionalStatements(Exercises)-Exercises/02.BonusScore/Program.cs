using System;

namespace _02.BonusScore
{
    class Program
    {
        static void Main(string[] args)
        {
            int score = int.Parse(Console.ReadLine());

            double bonusScore = 0d;

            if (score <= 100)
            {
                bonusScore += 5;
            }
            else if (score > 1000)
            {
                bonusScore = score * 0.1;
            }
            else
            {
                bonusScore = score * 0.2;
            }

            if (score % 2 == 0)
            {
                bonusScore += 1;
            }
            else if (score % 10 == 5)
            {
                bonusScore += 2;
            }

            Console.WriteLine(bonusScore);
            Console.WriteLine(bonusScore + score);



            //int score = int.Parse(Console.ReadLine());
            //double bonus = 0.0;
            //if (score <=100)
            //{
            //    bonus = 5;
            //}
            //else if (bonus > 1000)
            //{
            //    bonus = score * 0.1;
            //}
            //else
            //{
            //    bonus = score * 0.2;
            //}

            //if (score % 2 == 0 )
            //{
            //    bonus = bonus + 1;
            //}
            //else if (score % 10 == 5)
            //{
            //    bonus = bonus + 2;
            //}
            //Console.WriteLine(bonus);
            //Console.WriteLine(score + bonus);
        }
    }
}
