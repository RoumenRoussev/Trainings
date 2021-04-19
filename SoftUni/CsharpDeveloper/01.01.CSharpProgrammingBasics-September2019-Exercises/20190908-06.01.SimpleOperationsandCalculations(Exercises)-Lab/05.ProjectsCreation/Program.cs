using System;

namespace _05.ProjectsCreation
{
    class Program
    {
        static void Main(string[] args)
        {
            string archName = Console.ReadLine();
            int numHours = 3;
            int numProject = int.Parse(Console.ReadLine());
            int sumHours = numHours * numProject;
            Console.WriteLine($"The architect {archName} will need {sumHours} hours to complete {numProject} project/s.");
        }
    }
}
