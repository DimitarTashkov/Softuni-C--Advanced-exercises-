using System.IO;
using System;
using System.Text;
using System.Linq;

namespace LineNumbers
{
    public class LineNumbers
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";
            string outputFilePath = @"..\..\..\output.txt";

            ProcessLines(inputFilePath, outputFilePath);
        }

        public static void ProcessLines(string inputFilePath, string outputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            string[] lines = File.ReadAllLines(inputFilePath);
            for (int i = 0; i < lines.Length; i++)
            {
                int lettersCount = lines[i].Count(char.IsLetter);
                int symbolCount = lines[i].Count(char.IsPunctuation);

                sb.AppendLine($"Line {i+1}: {lines[i]} ({lettersCount}) ({symbolCount})");
            }

            File.WriteAllText(outputFilePath, sb.ToString());
        }
    }
}
