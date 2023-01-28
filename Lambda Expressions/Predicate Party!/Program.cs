using System;
using System.Linq;
using System.Collections.Generic;


namespace Predicate_Party_
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            string command = "";
            while((command = Console.ReadLine())!= "Party!")
            {
                string[] tokens = command.Split(" ",StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                string filter = tokens[1];
                string value = tokens[2];

                if(action == "Remove")
                {
                    people.RemoveAll(GetPredicate(filter, value));
                }
                else
                {
                    List<string> peopleToDouble = people.FindAll(GetPredicate(filter, value));

                    foreach (string person in peopleToDouble)
                    {
                        int index = people.FindIndex(p=> p == person);
                        people.Insert(index, person);
                    }
                }
            }
            static Predicate<string> GetPredicate(string filter, string value)
            {
                switch (filter)
                {
                    case "StartsWith":
                        return s => s.StartsWith(value);
                    case "EndsWith":
                        return s => s.EndsWith(value);
                    case "Length":
                        return s => s.Length == int.Parse(value);
                    default:
                        return default;


                }

            }
            if (people.Any())
            {
                Console.WriteLine($"{string.Join(", ",people)} are going to the party!");
            }
            else
            {
                Console.WriteLine("Nobody is going to the party!");
            }
                
        }
    }
}
