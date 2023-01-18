using System;
using System.Linq;
using System.Collections.Generic;

namespace Sum_Matrix_Elements
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int[] readInformation = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
            int[,] matrix = new int[readInformation[0], readInformation[1]];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] readInformation2 = Console.ReadLine()
                .Split(", ")
                .Select(int.Parse)
                .ToArray();
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = readInformation2[j];
                }

            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    sum += matrix[i, j];
                }

            }

            Console.WriteLine(readInformation[0]);
            Console.WriteLine(readInformation[1]);
            Console.WriteLine(sum);
        }
        public static void PrintMatrix(int[,] matrix)
        {
            for (int rows = 0; rows < matrix.GetLength(0); rows++)
            {
                for (int cols = 0; cols < matrix.GetLength(1); cols++)
                {
                    Console.WriteLine(matrix[rows,cols]+ " ");
                }
                Console.WriteLine();
            }
        }
    }
}
