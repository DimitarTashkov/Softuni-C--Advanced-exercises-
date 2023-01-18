using System;
using System.Linq;
using System.Collections.Generic;

namespace Basic_Queue_Operations
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] elements = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int[] numbers = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .Select(int.Parse)
                .ToArray();

            int numbersToEnqueue = elements[0];
            int numbersToDequeue = elements[1];
            int numberToCheckFor = elements[2];

            Queue<int> queue = new Queue<int>();

            for (int i = 0; i < numbersToEnqueue; i++)
            {
                queue.Enqueue(numbers[i]);

            }
            for (int i = 0; i < numbersToDequeue; i++)
            {
                queue.Dequeue();
            }
            if (queue.Contains(numberToCheckFor))
            {
                Console.WriteLine("true");
            }
            else
            {
                if (queue.Any())
                {
                    Console.WriteLine(queue.Min());
                }
                else
                {
                    Console.WriteLine(0);
                }
            }
        }
    }
}
