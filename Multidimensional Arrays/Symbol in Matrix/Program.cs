using System;
using System.Linq;
using System.Collections.Generic;

namespace Symbol_in_Matrix
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = int.Parse(Console.ReadLine());
            char[,] matrix = new char[size, size];

            for (int row = 0; row < size; row++)
            {
                string chars = Console.ReadLine();
                for (int col = 0; col < size; col++)
                {
                    matrix[row, col] = chars[col];
                }
            }
            char symbol = char.Parse(Console.ReadLine());
            bool isFound = false;

            for (int row = 0; row < size; row++)
            {

                for (int col = 0; col < size; col++)
                {
                   if(matrix[row,col] == symbol)
                    {
                        Console.WriteLine($"({row}, {col})");
                        return;
                    }
                }
            }
            if(isFound == false)
            {
                Console.WriteLine($"{symbol} does not occur in the matrix" );
            }

        }
    }
}
