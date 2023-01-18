using System;
using System.Linq;
using System.Collections.Generic;

namespace Matrix_Shuffling
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] dimension = Console.ReadLine()
                 .Split(" ")
                 .Select(int.Parse)
                 .ToArray();
            int rows = dimension[0];
            int cols = dimension[1];
            string[,] matrix = new string[rows, cols];
            for (int row = 0; row < rows; row++)
            {
                string[] strings = Console.ReadLine()
                    .Split()
                    .ToArray();
                for (int col = 0; col < cols; col++)
                {
                    matrix[row, col] = strings[col];
                }
            }
            while(true)
            {
                string command = Console.ReadLine();
                if(command == "END")
                {
                    break;
                }
                string[] tokens = command.Split(" ");
                if(isValidCommands(rows,cols,tokens))
                {
                    string tempValue = matrix[int.Parse(tokens[1]), int.Parse(tokens[2])];
                    matrix[int.Parse(tokens[1]), int.Parse(tokens[2])] = matrix[int.Parse(tokens[3]), int.Parse(tokens[4])];
                    matrix[int.Parse(tokens[3]), int.Parse(tokens[4])] = tempValue;

                    PrintMatrix(rows, cols, matrix);
                }
                else
                {
                    Console.WriteLine("Invalid input!");
                }
            }
        }
        static bool isValidCommands(int rows, int cols,string[] tokens)
        {
            return 
                tokens[0] == "swap"
                && tokens.Length == 5 &&
                int.Parse(tokens[1])>= 0 && int.Parse(tokens[1])< rows
                && int.Parse(tokens[2]) >= 0 && int.Parse(tokens[2]) < cols
                && int.Parse(tokens[3]) >= 0 && int.Parse(tokens[3]) < rows
                && int.Parse(tokens[4]) >= 0 && int.Parse(tokens[4]) < cols;
        }
        static void PrintMatrix(int rows, int cols, string[,] matrix)
        {
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < cols; col++)
                {
                    Console.Write($"{matrix[row, col]} ");
                }

                Console.WriteLine();
            }
        }
    }
}
