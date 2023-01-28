using System;
using System.Linq;

namespace Count_Uppercase_Words
{
    class Program
    {
        static void Main(string[] args)
        {
            Predicate<string> filterByUpperCase = s => s[0] == char.ToUpper(s[0]);
            string[] read = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries)
                .Where(x => filterByUpperCase(x))
                .ToArray();

            foreach (var item in read)
            {
                Console.WriteLine(item);
            }


                
        }
    }
}
