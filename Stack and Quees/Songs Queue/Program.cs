using System;
using System.Linq;
using System.Collections.Generic;

namespace Songs_Queue
{
    class Program
    {
        static void Main(string[] args)
        {
            Queue<string> songs = new Queue<string>(Console.ReadLine()
                .Split(", ",StringSplitOptions.RemoveEmptyEntries)
               );
            while(songs.Count > 0)
            {
                string[] commands = Console.ReadLine().Split(" ",StringSplitOptions.RemoveEmptyEntries);

                string command = commands[0];

                if(command == "Play")
                {
                    songs.Dequeue();

                }
                else if (command == "Add")
                {

                    string song = string.Join(" ",commands.Skip(1));

                    if(songs.Contains(song))
                    {
                        Console.WriteLine($"{song} is already contained!");
                    }
                    else
                    {
                        songs.Enqueue(song);
                    }
                }
                else if (command == "Show")
                {
                    Console.WriteLine(string.Join(", ",songs));
                }

            }

            Console.WriteLine("No more songs!");
            
            

        }
    }
}
