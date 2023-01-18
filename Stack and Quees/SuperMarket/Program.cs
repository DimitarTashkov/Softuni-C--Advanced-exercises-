using System;
using System.Collections.Generic;

namespace SuperMarket
{
    class Program
    {
        static void Main(string[] args)
        {
            string input;
            Queue<string> collectMembers = new Queue<string>();
            while((input = Console.ReadLine()) != "End")
            {
                if(input == "Paid")
                {
                    while(collectMembers.Count != 0)
                    {
                        Console.WriteLine(collectMembers.Dequeue());
                    }
                }
                else
                {
                    collectMembers.Enqueue(input);
                }
            }
            Console.WriteLine($"{collectMembers.Count} people remaining.");
        }
    }
}
