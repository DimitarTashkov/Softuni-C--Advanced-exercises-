using System;
using System.Linq;
using System.Collections.Generic;

namespace Predicate_For_Names
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[],Predicate<string>> printNames = (names,match) =>
            {
                foreach (string name in names)
                {
                    if(match(name))
                    {
                        Console.WriteLine(name);
                    }
                }
            };



            int length = int.Parse(Console.ReadLine());
            Predicate<string> match = name => name.Length <= length;

            string[] names = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            printNames(names,match);


        }
    }
}
