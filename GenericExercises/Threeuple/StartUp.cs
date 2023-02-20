using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threeuple
{
    public class StartUp
    {
        public static void Main(string[] args)
        {
            string[] personTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] drinkTokens = Console.ReadLine()
                .Split(" ", StringSplitOptions.RemoveEmptyEntries);
            string[] numbersTokens = Console.ReadLine()
                            .Split(" ", StringSplitOptions.RemoveEmptyEntries);

            CustomTuple<string, string,string> nameAdress = new($"{personTokens[0]} {personTokens[1]}", personTokens[2], string.Join(" ",personTokens[3]));
            CustomTuple<string, int,bool> nameBeer = new(drinkTokens[0], int.Parse(drinkTokens[1]), drinkTokens[2] == "drunk");
            CustomTuple<string, double,string> numbers = new(numbersTokens[0], double.Parse(numbersTokens[1]), numbersTokens[2]);

            Console.WriteLine(nameAdress);
            Console.WriteLine(nameBeer);
            Console.WriteLine(numbers);


        }
    }
}
