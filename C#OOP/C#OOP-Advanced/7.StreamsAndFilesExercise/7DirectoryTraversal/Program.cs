namespace _7DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            var resultDictionary = TraverseDirectory("../../");

            string result = GetFileStringFromDictionary(resultDictionary);

            WriteStringToFile(result, "result.txt");
        }

        public static void WriteStringToFile(string stringToWrite, string fileName)
        {
            string filePath = Path.Combine(
                Environment.GetFolderPath(Environment.SpecialFolder.Desktop), fileName);

            using (var writer = new StreamWriter($"{filePath}"))
            {
                writer.Write($"{stringToWrite}");
            }
        }

        public static string GetFileStringFromDictionary(Dictionary<string, List<CustomFile>> dictionary)
        {
            StringBuilder sb = new StringBuilder();
            foreach (var pair in dictionary.OrderByDescending(x => x.Value.Count).ThenBy(x => x.Key))
            {
                sb.Append(pair.Key);
                sb.Append(Environment.NewLine);

                foreach (var customFile in pair.Value.OrderBy(x => x.SizeKB))
                {
                    sb.Append($"--{customFile.Name} - {customFile.SizeKB}kb ");
                    sb.Append(Environment.NewLine);
                }
            }

            return sb.ToString();
        }

        public static Dictionary<string, List<CustomFile>> TraverseDirectory(string path)
        {
            Dictionary<string, List<CustomFile>> dictionary = new Dictionary<string, List<CustomFile>>();
            foreach (var file in Directory.GetFiles(path))
            {
                string fileName = Path.GetFileName(file);
                string fileExtention = Path.GetExtension(file);
                // string extention = Path.GetExtension(file);
                float fileLenght = (float) new FileInfo(file).Length / 1000;

                CustomFile customFile = new CustomFile
                {
                    Extention = fileExtention,
                    Name = fileName,
                    SizeKB = fileLenght
                };
                List<CustomFile> customFiles = new List<CustomFile>();
                customFiles.Add(customFile);

                if (!dictionary.ContainsKey(fileExtention))
                {
                    dictionary.Add(fileExtention, customFiles);
                }

                else
                {
                    dictionary[fileExtention].AddRange(customFiles);
                }

                // Console.WriteLine($"--{fileName} - {fileLenght}kb ");
            }

            return dictionary;
        }
    }

    public class CustomFile
    {
        public string Extention { get; set; }

        public string Name { get; set; }

        public float SizeKB { get; set; }
    }
}