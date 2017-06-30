namespace _7DirectoryTraversal
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            var resultDictionary = TraverseDirectory("../../");
            Console.WriteLine();
        }
        // i need to put them in dictionary
        public static Dictionary<string, List<CustomFile>> TraverseDirectory(string path)
        {
            Dictionary<string, List<CustomFile>> dictionary = new Dictionary<string, List<CustomFile>>();
            foreach (var file in Directory.GetFiles(path))
            {
                string fileName = Path.GetFileName(file);
                string fileExtention = Path.GetExtension(file);
                // string extention = Path.GetExtension(file);
                float fileLenght = (float)new FileInfo(file).Length / 1000;

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

                Console.WriteLine($"--{fileName} - {fileLenght}kb ");
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