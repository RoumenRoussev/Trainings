using System;

namespace _08.Scholarship_
{
    class Program
    {
        static void Main(string[] args)
        {
            double income = double.Parse(Console.ReadLine());
            double results = double.Parse(Console.ReadLine());
            double minSalary = double.Parse(Console.ReadLine());
            double scholarshipS = minSalary * 35 / 100;
            double scholarshipE = results * 25;
            if (results >= 5.5)
            {
                if (scholarshipE >= scholarshipS || income > minSalary)
                    Console.WriteLine("You get a scholarship for excellent results {0} BGN", Math.Floor(scholarshipE));
                else Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(scholarshipS));
            }
            else if (income < minSalary && results > 4.5)
            {
                Console.WriteLine("You get a Social scholarship {0} BGN", Math.Floor(scholarshipS));
            }

            else Console.WriteLine("You cannot get a scholarship!");



            //double income = double.Parse(Console.ReadLine());
            //double score = double.Parse(Console.ReadLine());
            //double minWage = double.Parse(Console.ReadLine());
            //double socialScolarship = Math.Floor(minWage * 0.35);
            //double resulstScolarship = Math.Floor(score * 25);

            //if (income < minWage & score >= 4.5)
            //{
            //    Console.WriteLine($"You get a Social scholarship {socialScolarship} BGN");
            //}
            //else if (income > minWage & score >= 5.5)
            //{
            //    Console.WriteLine($"You get a scholarship for excellent results {resulstScolarship} BGN");

            //}
            //else if (income < minWage & score >= 5.5)
            //{
            //    if (socialScolarship > resulstScolarship)
            //    {
            //        Console.WriteLine($"You get a Social scholarship {socialScolarship} BGN");
            //    }
            //    else if (resulstScolarship == socialScolarship)
            //    {
            //        Console.WriteLine($"You get a scholarship for excellent results {resulstScolarship} BGN");
            //    }
            //    else
            //    {
            //        Console.WriteLine($"You get a scholarship for excellent results {resulstScolarship} BGN");

            //    }
            //}

            //else
            //{
            //    Console.WriteLine("You cannot get a scholarship!");
            //}
            ////Влиза в първият if и дава социална стипендия без значение дали се полагага равна или по-голяма стипендия за успех.



            //double income = Double.Parse(Console.ReadLine());
            //double grade = Double.Parse(Console.ReadLine());
            //double salary = Double.Parse(Console.ReadLine());
            //double social = Math.Floor(salary * 35 / 100);
            //double excelent = Math.Floor(grade * 25);

            //if (grade > 4.50 && income < salary)
            //{
            //    if (grade < 5.50 || excelent < social)
            //    {
            //        Console.WriteLine("You get a Social scholarship {0} BGN", social);
            //    }
            //}


            //else if (grade >= 5.50)
            //{

            //    Console.WriteLine("You get a scholarship for excellent results {0}", excelent);

            //}
            //else
            //{
            //    Console.WriteLine("You cannot get a scholarship!");
            //}
            ////ако стипендията за успех по - висока от социалната стипендия програмта приключва без изход.
        }
    }
}
