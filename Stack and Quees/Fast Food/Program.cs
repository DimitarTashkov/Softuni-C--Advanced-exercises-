using System;
using System.Linq;
using System.Collections.Generic;

namespace Fast_Food
{
    class Program
    {
        static void Main(string[] args)
        {
            int foodQuantity = int.Parse(Console.ReadLine());
            Queue<int> orders = new Queue<int>(
                Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
               );
            Console.WriteLine(orders.Max());
            while(orders.Any())
            {
                foodQuantity -= orders.Peek();
                if(foodQuantity < 0)
                {
                    break;
                }
                orders.Dequeue();
            }
            if(orders.Any())
            {
                Console.WriteLine($"Orders left: {string.Join(" ",orders)}");
            }
            else
            {
                Console.WriteLine("Orders complete");
            }
        }
    }
}
