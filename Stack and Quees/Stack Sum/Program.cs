using System;
using System.Linq;
using System.Collections.Generic;
namespace Stack_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> input = Console.ReadLine()
                .Split()
                .Select(int.Parse)
                .ToList();
            Stack<int> stack = new Stack<int>(input);

            string command = Console.ReadLine().ToLower();
            while(command !="end")
            {
                string[] commandSplit = command.Split(" ");
                if(commandSplit[0] == "add")
                {
                    int first = int.Parse(commandSplit[1]);
                    int second = int.Parse(commandSplit[2]);
                    stack.Push(first);
                    stack.Push(second);
                }
                if (commandSplit[0] == "remove")
                {
                    int n = int.Parse(commandSplit[1]);
                    if(n<= stack.Count)
                    {
                        for (int i = 0; i < n; i++)
                        {
                            stack.Pop();
                        }
                    }
                  
                }
                command = Console.ReadLine();

            }
            Console.WriteLine("Sum: "+stack.Sum());
        }
    }
}
