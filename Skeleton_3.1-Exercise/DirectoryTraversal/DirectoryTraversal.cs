using System;
using System.Linq;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace DirectoryTraversal
{
    public class DirectoryTraversal
    {
        static void Main()
        {
            string path = Console.ReadLine();
            string reportFileName = @"\report.txt";

            string reportContent = TraverseDirectory(path);
            Console.WriteLine(reportContent);

            WriteReportToDesktop(reportContent, reportFileName);
        }

        public static string TraverseDirectory(string inputFolderPath)
        {
            SortedDictionary<string, List<FileInfo>> extensionFile =
                new SortedDictionary<string, List<FileInfo>>();

          string[] filesName = Directory.GetFiles(inputFolderPath);

            foreach (var file in filesName)
            {
                FileInfo fileInfo = new FileInfo(file);

                if(!extensionFile.ContainsKey(fileInfo.Extension))
                {
                    extensionFile.Add(fileInfo.Extension, new List<FileInfo>());
                }
                extensionFile[fileInfo.Extension].Add(fileInfo);
            }

            StringBuilder sb = new StringBuilder();
            foreach (var extensionOfFile in extensionFile.OrderByDescending(k=>k.Value.Count))
            {
                sb.AppendLine(extensionOfFile.Key);
                foreach (var file in extensionOfFile.Value.OrderBy(f => f.Length))
                {
                    sb.AppendLine($"--{file.Name} - {(double)file.Length/1024:f3}kb");
                }
            }
            return sb.ToString();
        }

        public static void WriteReportToDesktop(string textContent, string reportFileName)
        {
            string filePath = Environment.GetFolderPath(Environment.SpecialFolder.Desktop) + reportFileName;

            File.WriteAllText(filePath, textContent);
        }
    }
}
