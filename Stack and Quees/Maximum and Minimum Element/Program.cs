using System;
using System.Linq;
using System.Collections.Generic;

namespace Maximum_and_Minimum_Element
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            Stack<int> numbers = new Stack<int>();
            for (int i = 0; i < n; i++)
            {
                int[] number = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                if(number[0] == 1)
                {
                    numbers.Push(number[1]);
                }
                else if (number[0] == 2)
                {
                    numbers.Pop();
                }
                else if (number[0] == 3)
                {
                    if(numbers.Count != 0)
                    {
                        Console.WriteLine(numbers.Max());
                    }
                }
                else if (number[0] == 4)
                {
                    if (numbers.Count != 0)
                    {
                        Console.WriteLine(numbers.Min());
                    }
                }
            }
            while(numbers.Count >1)
            {
                Console.Write($"{numbers.Pop()}, ");
            }
            Console.Write(numbers.Pop());
        }
    }
}
