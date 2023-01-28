using System;
using System.Linq;
using System.Collections.Generic;


namespace Add_VAT
{
    class Program
    {
        static void Main(string[] args)
        {
            double[] numbers = Console.ReadLine()
                 .Split(new string[] { ", " },StringSplitOptions.RemoveEmptyEntries)
                 .Select(double.Parse)
                 .Select(n => n * 1.2)
                 .ToArray();

            foreach (var number in numbers)
            {
                Console.WriteLine($"{number:f2}");
            }
                 
        }
    }
}
