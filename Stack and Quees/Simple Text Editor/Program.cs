using System;
using System.Linq;
using System.Collections.Generic;

namespace Simple_Text_Editor
{
    class Program
    {
        static void Main(string[] args)
        {
            int operation = int.Parse(Console.ReadLine());

            Stack<string> changes = new Stack<string>();
            string text = string.Empty;

            for (int i = 0; i < operation; i++)
            {
                string[] commands = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                int commandType = int.Parse(commands[0]);

                if (commandType == 1)
                {
                    text = text + commands[1];
                    changes.Push(text);
                }
                else if (commandType == 2)
                {                   
                    int count = int.Parse(commands[1]);
                    text = text.Remove(text.Length-count);
                    changes.Push(text);
                }
                else if (commandType == 3)
                {
                    int index = int.Parse(commands[1]);
                    Console.WriteLine(text[index-1]);
                }
                else if (commandType == 4)
                {
                    text = changes.Pop();
                    if(changes.Count == 0)
                    {
                        text = "";
                        continue;
                    }
                    text = changes.Peek();
                }
            }
        }
    }
}
