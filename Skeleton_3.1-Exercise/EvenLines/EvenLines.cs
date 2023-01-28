namespace EvenLines
{
    using System;
    using System.IO;
    using System.Text;
    using System.Linq;
    public class EvenLines
    {
        static void Main()
        {
            string inputFilePath = @"..\..\..\text.txt";

            Console.WriteLine(ProcessLines(inputFilePath));
        }

        public static string ProcessLines(string inputFilePath)
        {
            StringBuilder sb = new StringBuilder();
            using (StreamReader reader = new StreamReader(inputFilePath))
            {
                string line = string.Empty;


                int count = 0;

                while (line  != null)
                {

                    line = reader.ReadLine();

                    if(count% 2 == 0)
                    {
                        string replaceSymbols = ReplaceSymbols(line);
                       string reverse = ReverseInput(replaceSymbols);
                        sb.AppendLine(reverse);
                    }
                    count++;
                }
                return sb.ToString();
            }


        }

        private static string ReverseInput(string line)
        {
            string[] reversedWords = ReplaceSymbols(line)
                .Split(" ")
                .Reverse()
                .ToArray();

            return string.Join(" ", reversedWords);
        }

        private static string ReplaceSymbols(string line)
        {
            StringBuilder sb = new StringBuilder();

            string[] symbolsToReplace = {"-" , "," , "." , "!" , "?" };

            foreach (var symbol in symbolsToReplace)
            {
                sb = sb.Replace(symbol, "@");
            }

            return sb.ToString();

        }
    }
}
