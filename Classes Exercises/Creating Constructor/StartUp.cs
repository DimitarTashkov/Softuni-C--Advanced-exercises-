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

            Console.WriteLine($"{peter.Name} is {peter.Age} years old");

        }

    }
}
