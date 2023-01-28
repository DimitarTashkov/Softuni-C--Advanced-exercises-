using System;

namespace Knights_of_Honor
{
    class Program
    {
        static void Main(string[] args)
        {
            Action<string[]> print = strings =>
            {
                foreach (string str in strings)
                {
                    Console.WriteLine($"Sir {str}");
                }

            };


            string[] strings = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            print(strings);
        }
    }
}
