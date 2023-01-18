using System;
using System.Linq;
using System.Collections.Generic;


namespace MAtching_Brackets
{
    class Program
    {
        static void Main(string[] args)
        {
            string expression = Console.ReadLine();
            Stack<int> indexOfOpenBrackets = new Stack<int>();
            for (int i = 0; i < expression.Length; i++)
            {
                if(expression[i] == '(')
                {
                    indexOfOpenBrackets.Push(i);
                }
                if(expression[i] == ')')
                {
                    int openBreackets = indexOfOpenBrackets.Pop();
                    for (int j = openBreackets; j <= i; j++)
                    {
                        Console.Write(expression[j]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
