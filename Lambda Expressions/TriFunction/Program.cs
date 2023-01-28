using System;
using System.Linq;
using System.Collections.Generic;

namespace TriFunction
{
    class Program
    {
        static void Main(string[] args)
        {
            Func<string, int, bool> checkEqualOrLargerNames = (name, sum) =>
              {
                  int charSum = name.Sum(ch => ch);
                  return charSum >= sum;
              };

            Func<string[], int, Func<string, int, bool>, string> getFirstName =
                (names, sum, match) =>
                {
                    foreach (var name in names)
                    {
                        if (match(name, sum))
                        {
                            return name;
                        }
                    }
                    return null;
                };

            int sum = int.Parse(Console.ReadLine());

            string[] names = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            Console.WriteLine(getFirstName(names,sum,checkEqualOrLargerNames));


                
        }
    }
}
