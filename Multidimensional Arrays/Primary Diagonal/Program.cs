using System;
using System.Linq;

namespace Primary_Diagonal
{
    class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            int rows = int.Parse(Console.ReadLine());
            int[,] matrix = new int[rows,rows];
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                int[] readInformation = Console.ReadLine()
                .Split(" ")
                .Select(int.Parse)
                .ToArray(); 
                for (int j = 0; j < matrix.GetLength(1); j++)
                {
                    matrix[i, j] = readInformation[j];
                }
            }
            for (int i = 0; i < matrix.GetLength(0); i++)
            {
                sum += matrix[i, i];
            }
            Console.WriteLine(sum);
        }
    }
}
