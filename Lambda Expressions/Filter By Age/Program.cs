using System;
using System.Linq;
using System.Collections.Generic;

namespace Filter_By_Age
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();

            int n = int.Parse(Console.ReadLine());

            List<Person> people = new List<Person>();

            for (int i = 0; i < n; i++)
            {
                string[] input = Console.ReadLine().Split(", ");

                people.Add(new Person() { name = input[0], age = int.Parse(input[1]) });
            }

            string filterType = Console.ReadLine();
            int filtersType = int.Parse(Console.ReadLine());

          
            Func<Person, int, bool> filter = GetFilter(filterType);

            people = people.Where(p => filter(p, filtersType)).ToList();

            Action<Person> formatter = GetFormatType(Console.ReadLine());

            foreach (var persons in people)
            {
                formatter(persons);
            }



            Func<Person,int,bool> GetFilter (string filterType)
            {
                if(filterType == "younger")
                {
                    return (p, value) => p.age <= value;
                }
                else
                {
                    return (Person p, int value) => p.age >= value;
                }
            }

            Action<Person> GetFormatType (string formatType)
            {
                if (formatType == "name age")
                {
                    return p => Console.WriteLine($"{p.name} - {p.age}");
                }
                else if (formatType == "name")
                {
                    return p => Console.WriteLine($"{p.name}");
                }
                else if (formatType == "age")
                {
                    return p => Console.WriteLine($"{p.age}");
                }
                return null;
                
            }
        }
    }
    class Person
    {
       public string name;
       public int age;
             
    }

}
