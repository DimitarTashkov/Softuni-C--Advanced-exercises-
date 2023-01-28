using System;

namespace Action_Point
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> print = strings => Console.WriteLine(string.Join(Environment.NewLine, strings));


            string[] strings = Console.ReadLine()
                .Split(" ",StringSplitOptions.RemoveEmptyEntries);

            print(strings);

        }
    }
}
