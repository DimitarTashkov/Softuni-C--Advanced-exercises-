using System;
using System.Collections.Generic;

namespace Hot_potato
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] playersRead = Console.ReadLine()
                .Split(" ");
            Queue<string> players = new Queue<string>(playersRead);
            int n = int.Parse(Console.ReadLine());
            int tosses = 1;
            while(players.Count != 1)
            {
                string child = players.Dequeue();
                if(n>tosses)
                {
                    players.Enqueue(child);
                    tosses++;

                }
                else
                {
                    Console.WriteLine("Removed "+ child);
                    tosses = 1;
                }
            }
            Console.WriteLine($"Last is {players.Dequeue()}");
                
        }
    }
}
