﻿using System;

namespace _10.RadiansToDegrees
{
    class Program
    {
        static void Main(string[] args)
        {
            var radians = double.Parse(Console.ReadLine());
            Console.WriteLine(Math.Floor(180 / Math.PI * radians));
        }
    }
}
