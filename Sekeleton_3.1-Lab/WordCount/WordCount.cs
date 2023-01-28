namespace WordCount
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    public class WordCount
    {
        static void Main()
        {
            string wordPath = @"..\..\..\Files\words.txt";
            string textPath = @"..\..\..\Files\text.txt";
            string outputPath = @"..\..\..\Files\output.txt";
            SortedDictionary<string, int> countCollector =
                new SortedDictionary<string, int>();

            CalculateWordCounts(wordPath, textPath, outputPath,countCollector);
        }

        public static void CalculateWordCounts(string wordsFilePath, string textFilePath, string outputFilePath, SortedDictionary<string, int> countCollector)
        {
            using(StreamReader reader = new StreamReader(textFilePath))
            {
                using(StreamReader reader2 = new StreamReader(wordsFilePath))
                {
                    string words = reader2.ReadToEnd();
                    string[] splitted = words.Split();
                    string text = reader.ReadLine();

                    while(text != null)
                    {
                        foreach (string word in splitted)
                        {
                            if (text.ToLower().Contains(word))
                            {

                                if (!countCollector.ContainsKey(word))
                                {
                                    countCollector.Add(word, 0);
                                
                                }
                                countCollector[word]++;

                            }
                        }
                        text = reader.ReadLine();
                    }
                    using(StreamWriter writer = new StreamWriter(outputFilePath))
                    {
                        foreach (var word in countCollector.OrderByDescending(v => v.Value))
                        {
                            writer.WriteLine($"{word.Key} - {word.Value}");
                        }
                    }
                                                       
                }
            }
        }
    }
}
