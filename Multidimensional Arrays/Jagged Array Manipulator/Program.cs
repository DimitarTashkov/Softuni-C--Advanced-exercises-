using System;
using System.Linq;

namespace Jagged_Array_Manipulator
{
    class Program
    {
        static void Main(string[] args)
        {
            int rows = int.Parse(Console.ReadLine());
            int[][] jaggedArray = new int[rows][];

            for (int row = 0; row < rows; row++)
            {
                int[] cols = Console.ReadLine()
                    .Split(" ")
                    .Select(int.Parse)
                    .ToArray();
                jaggedArray[row] = cols;
                
            }
            for (int row = 0; row < rows-1; row++)
            {
                if(jaggedArray[row].Length == jaggedArray[row+1].Length)
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] *= 2;
                        jaggedArray[row + 1][col] *= 2;
                    }
                }
                else
                {
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row][col] /= 2;
                    }
                    for (int col = 0; col < jaggedArray[row].Length; col++)
                    {
                        jaggedArray[row + 1][col] /= 2;
                    }
                }
            }
            while (true)
            {
                string command = Console.ReadLine();

                if(command == "End")
                {
                    break;
                }

                string[] tokens = command.Split(" ");

                if(tokens[0] == "Add")
                {
                    int row = int.Parse(tokens[1]);
                    int col = int.Parse(tokens[2]);
                    int value = int.Parse(tokens[3]);
                    if(isInTheArray(jaggedArray, row, col))
                    {
                        jaggedArray[row][col] += value;
                    }
                }
                else
                {
                    int row = int.Parse(tokens[1]);
                    int col = int.Parse(tokens[2]);
                    int value = int.Parse(tokens[3]);
                    if (isInTheArray(jaggedArray, row, col))
                    {
                        jaggedArray[row][col] -= value;
                    }
                }
            }
            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < jaggedArray[row].Length; col++)
                {
                    Console.Write($"{jaggedArray[row][col]} ");
                }
                Console.WriteLine();
            }

        }

         static bool isInTheArray(int[][] jaggedArray, int row, int col)
        {
            return row >= 0 && row < jaggedArray.Length
                        && col >= 0 && col < jaggedArray[row].Length;
        }
    }
}
