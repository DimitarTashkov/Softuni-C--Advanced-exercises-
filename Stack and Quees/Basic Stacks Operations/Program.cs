using System;
using System.Linq;
using System.Collections.Generic;

namespace Basic_Stacks_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numbersToPush = elements[0];
            int numbersToPop = elements[1];
            int numberToCheckFor = elements[2];

            Stack<int> stack = new Stack<int>();

            for (int i = 0; i < numbersToPush; i++)
            {
                stack.Push(numbers[i]);

            }
            for (int i = 0; i < numbersToPop; i++)
            {
                stack.Pop();
            }
            if(stack.Contains(numberToCheckFor))
            {
                Console.WriteLine("true");
            }
            else
            {
               if(stack.Any())
                {
                    Console.WriteLine(stack.Min());
                }
               else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
