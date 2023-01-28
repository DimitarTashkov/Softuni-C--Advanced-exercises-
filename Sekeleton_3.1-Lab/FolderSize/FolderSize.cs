namespace FolderSize
{
    using System;
    using System.IO;
    public class FolderSize
    {
        static void Main(string[] args)
        {
            string folderPath = @"..\..\..\Files\TestFolder";
            string outputPath = @"..\..\..\Files\output.txt";

            GetFolderSize(folderPath, outputPath);
        }

        public static void GetFolderSize(string folderPath, string outputFilePath)
        {
            
            long size = (GetFolderSizes(folderPath));
            File.WriteAllText(outputFilePath,$"{size / 1024} KB");
        }
        public static long GetFolderSizes(string path)
        {
            string[] filePaths = Directory.GetFiles(path);

            long size = 0;
            foreach (var filePath in filePaths)
            {
                FileInfo info = new FileInfo(filePath);
                size += info.Length;

            }
            foreach (var dirPaths in Directory.GetDirectories(path))
            {
                size += GetFolderSizes(dirPaths);
            }
            return size;
        }
    }
}
