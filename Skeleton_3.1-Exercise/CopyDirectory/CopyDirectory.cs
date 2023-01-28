using System;
using System.Linq;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace CopyDirectory
{
    public class CopyDirectory
    {
        static void Main()
        {
            string inputPath =  @$"{Console.ReadLine()}";
            string outputPath = @$"{Console.ReadLine()}";

            CopyAllFiles(inputPath, outputPath);
        }

        public static void CopyAllFiles(string inputPath, string outputPath)
        {
            if(Directory.Exists(outputPath))
            {
                Directory.Delete(outputPath,true);
            }

            Directory.CreateDirectory(outputPath);

            string[] fileNames = Directory.GetFiles(inputPath);
            foreach (string fullFileName in fileNames)
            {
                string file = Path.GetFileName(fullFileName);
                string destination = Path.Combine(outputPath, file);
                File.Copy(fullFileName, destination);
            }
        }
    }
}
