using System;
using System.Linq;
using System.Collections.Generic;

namespace The_Party_Reservation_Filter_Module
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> people = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries)
                .ToList();

            Dictionary<string, Predicate<string>> filters =
                new Dictionary<string, Predicate<string>>();

            string command = "";
            while ((command = Console.ReadLine()) != "Print")
            {
                string[] tokens = command.Split(";", StringSplitOptions.RemoveEmptyEntries);
                string action = tokens[0];
                string filter = tokens[1];
                string value = tokens[2];
                
                if(action == "Add filter")
                {
                    filters.Add(filter+value,GetPredicate(filter, value));
                }
                else
                {
                    filters.Remove(filter + value);
                }
            }
            foreach (var filter in filters)
            {
                people.RemoveAll(filter.Value);
            }
            static Predicate<string> GetPredicate(string filter, string value)
            {
                switch (filter)
                {
                    case "Starts With":
                        return s => s.StartsWith(value);
                    case "Ends With":
                        return s => s.EndsWith(value);
                    case "Contains":
                        return s => s.Contains(value);
                    case "Length":
                        return s => s.Length == int.Parse(value);
                    default:
                        return default;


                }

            }
            
                Console.WriteLine($"{string.Join(" ", people)} ");
            
        }
    }
}
