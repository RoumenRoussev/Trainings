using System;

namespace _13._1000DaysAfterBirth
{
    class Program
    {
        static void Main(string[] args)
        {
            string dateString = Console.ReadLine();
            string format = "dd-MM-yyyy";
            DateTime result = DateTime.ParseExact(dateString, format, System.Globalization.CultureInfo.InvariantCulture);
            System.Globalization.CultureInfo provider = System.Globalization.CultureInfo.InvariantCulture;
            DateTime output = Convert.ToDateTime(result).AddDays(1000);
            Console.WriteLine(output.ToString("dd-MM-yyyy"));



            //string BirthDate = Console.ReadLine();
            //string format = "dd-MM-yyyy";
            //DateTime time = DateTime.ParseExact(BirthDate, format, System.Globalization.CultureInfo.InvariantCulture);
            //Console.WriteLine(time.AddDays(999).ToString(format));



            //DateTime today = DateTime.Now;
            //DateTime date = System.DateTime.Parse(Console.ReadLine());
            //DateTime result = date.AddDays(1000);
            //Console.WriteLine("{0:dd-MM-yyyy}", result);
        }
    }
}
