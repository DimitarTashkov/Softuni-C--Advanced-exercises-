using System;
using System.Linq;
using System.Collections.Generic;

namespace Balanced_Parenthesis
{
    class Program
    {
        static void Main(string[] args)
        {
            string parentheses = Console.ReadLine();
            Stack<char> stack = new Stack<char>();
            foreach (char parenthese in parentheses)
            {
                switch (parenthese)
                {
                    case '(':
                    case '[':
                    case '{':
                        stack.Push(parenthese);             
                        break;
                    case ')':
                        if(stack.Count == 0 || stack.Pop() != '(')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case ']':
                        if (stack.Count == 0 || stack.Pop() != '[')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;
                    case '}':
                        if (stack.Count == 0 || stack.Pop() != '{')
                        {
                            Console.WriteLine("NO");
                            return;
                        }
                        break;

                }
            }
            Console.WriteLine("YES");
        }
    }
}
