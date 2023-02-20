using DefiningClasses;
using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OpinionPoll
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            SortedDictionary<string, int> collectNames =
                new SortedDictionary<string, int>();
            int count = int.Parse(Console.ReadLine());
            for (int i = 0; i < count; i++)
            {
                string[] readInformation = Console.ReadLine()
                    .Split(" ", StringSplitOptions.RemoveEmptyEntries);

                Person person = new Person(readInformation[0], int.Parse(readInformation[1]));
                    
                if (person.Age > 30)
                {
                    collectNames.Add(person.Name,person.Age);
                }
            }
            foreach (var name in collectNames)
            {
                Console.WriteLine($"{name.Key} - {name.Value}");
            }
        }

    }
}
