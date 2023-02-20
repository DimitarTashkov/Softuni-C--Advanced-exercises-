using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DefiningClasses
{
    public class StartUp
    {
        private static void Main(string[] args)
        {
            Person peter = new Person();

            peter.Name = "Peter";
            peter.Age = 18;
            Console.WriteLine($"{peter.Name} is {peter.Age} years old");

            Person george = new Person();
            george.Name = "George";
            george.Age = 23;
            Console.WriteLine($"{george.Name} is {george.Age} years old");

        }
    }
}
