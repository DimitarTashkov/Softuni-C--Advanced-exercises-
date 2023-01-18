using System;
using System.Linq;
using System.Collections.Generic;

namespace SimpleCalculator
{
    class Program
    {
        static void Main(string[] args)
        {

            string[] input = Console.ReadLine().Split(" ");
            Stack<string> stack = new Stack<string>();
            for (int i = input.Length - 1; i >= 0; i--)
            {
                stack.Push(input[i]);
            }
            while(stack.Count > 1)
            {
                int firstNum = int.Parse(stack.Pop());
                char action = char.Parse(stack.Pop());
                int secondNum = int.Parse(stack.Pop());
                if(action == '+')
                {
                    firstNum += secondNum;
                }
                else if (action == '-')
                {
                    firstNum -= secondNum;
                }
                stack.Push(firstNum.ToString());
            }
            Console.WriteLine(stack.Pop());
        }
    }
}
