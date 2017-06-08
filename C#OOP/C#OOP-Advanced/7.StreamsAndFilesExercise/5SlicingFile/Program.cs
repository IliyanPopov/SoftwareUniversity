namespace _5SlicingFile
{
    using System;
    using System.Collections.Generic;
    using System.IO;

    public class Program
    {
        public static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            List<string> splittedFileNames = SplitFile("DragonMovie.avi", "../../", n);
            Assemble(splittedFileNames, "../../");
            Console.WriteLine();
        }

        public static List<string> SplitFile(string sourceFile, string destinationDirectory, int parts)
        {
            List<string> splitedFileNames = new List<string>();
            try
            {
                using (FileStream inputSteam = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                {
                    int sizeofEachFile = (int)Math.Ceiling((double)inputSteam.Length / parts);
                    for (int i = 0; i < parts; i++)
                    {
                        string extension = Path.GetExtension(sourceFile);
                        string fullFileName = destinationDirectory + "Part-" + i + extension;

                        using (FileStream outputSteam = new FileStream(fullFileName, FileMode.Create, FileAccess.Write))
                        {
                            int bytesRead = 0;
                            //using buffer makes thigs much faster
                            byte[] buffer = new byte[sizeofEachFile];
                            if ((bytesRead = inputSteam.Read(buffer, 0, sizeofEachFile)) > 0)
                            {
                                outputSteam.Write(buffer, 0, bytesRead);
                            }

                            splitedFileNames.Add(fullFileName);
                        }
                    }
                }
            }
            catch (Exception Ex)
            {
                throw new ArgumentException(Ex.Message);
            }

            return splitedFileNames;
        }


        public static void Assemble(List<string> files, string destinationDirectory)
        {
            try
            {
                foreach (string fileName in files)
                {
                    string extension = Path.GetExtension(fileName);

                    using (var outputFile = new FileStream(destinationDirectory + "assembled" + extension,
                        FileMode.Append, FileAccess.Write))
                    {
                        byte[] buffer = new byte[1024];
                        using (var inputTempFile = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                        {
                            var bytesRead = 0;
                            while ((bytesRead = inputTempFile.Read(buffer, 0, 1024)) > 0)
                                outputFile.Write(buffer, 0, bytesRead);
                        }
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }
    }
}