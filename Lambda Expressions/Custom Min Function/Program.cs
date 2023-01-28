using System;
using System.Linq;
using System.Collections.Generic;

namespace Custom_Min_Function
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<HashSet<int>, int> min = numbers =>
             {
                 int min = int.MaxValue;
                 foreach (int number in numbers)
                 {
                     if(min>number)
                     {
                         min = number;
                     }
                 }
                 return min;


             };

            HashSet<int> numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(s => int.Parse(s))
                .ToHashSet();

            Console.WriteLine(min(numbers));
        }
    }
}
