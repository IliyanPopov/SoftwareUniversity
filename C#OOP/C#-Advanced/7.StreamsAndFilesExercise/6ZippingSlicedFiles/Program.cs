namespace _6ZippingSlicedFiles
{
    using System;
    using System.Collections.Generic;
    using System.IO;
    using System.IO.Compression;

    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Enter the number of files you want your file to be splited to:");
            int n = int.Parse(Console.ReadLine());

            List<string> splittedFileNames = SplitFileCompressed("sample.pdf", "../../", n);
            Assemble(splittedFileNames, "../../");
            Console.WriteLine();
        }

        public static List<string> SplitFileCompressed(string sourceFile, string destinationDirectory, int parts)
        {
            List<string> splitedFileNames = new List<string>();
            try
            {
                using (FileStream inputSteam = new FileStream(sourceFile, FileMode.Open, FileAccess.Read))
                {
                    int sizeofEachFile = (int) Math.Ceiling((double) inputSteam.Length / parts);

                    for (int i = 0; i < parts; i++)
                    {
                        // string extension = Path.GetExtension(sourceFile);
                        string fullFileName = destinationDirectory + "Part-" + i + ".gz";

                        using (FileStream outputStream =
                            new FileStream(fullFileName, FileMode.Create, FileAccess.Write))
                        {
                            using (var compressionStream =
                                new GZipStream(outputStream, CompressionMode.Compress, false))
                            {
                                int bytesRead = 0;

                                byte[] buffer = new byte[sizeofEachFile];

                                if ((bytesRead = inputSteam.Read(buffer, 0, sizeofEachFile)) > 0)
                                {
                                    compressionStream.Write(buffer, 0, bytesRead);
                                }
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
                    using (var inputStream = new FileStream(fileName, FileMode.Open, FileAccess.Read))
                    {
                        using (var compressionStream = new GZipStream(inputStream, CompressionMode.Decompress, false))
                        {
                            string extension = Path.GetExtension(fileName);

                            using (var outputSteam = new FileStream(destinationDirectory + "assembled" + ".pdf",
                                FileMode.Append, FileAccess.Write))
                            {
                                byte[] buffer = new byte[1024];

                                var bytesRead = 0;
                                while ((bytesRead = compressionStream.Read(buffer, 0, 1024)) > 0)
                                    outputSteam.Write(buffer, 0, bytesRead);
                            }
                        }
                    }
                }
            }

            catch (Exception e)
            {
                Console.WriteLine(e.StackTrace);
            }
        }

        static void Decompress(string inputFile, string outputFile)
        {
            using (var inputStream = new FileStream(inputFile, FileMode.Open))
            {
                using (var compressionStream = new GZipStream(inputStream, CompressionMode.Decompress, false))
                {
                    using (var outputStream = new FileStream(outputFile, FileMode.Create))
                    {
                        byte[] buffer = new byte[4096];
                        while (true)
                        {
                            int readBytes = compressionStream.Read(buffer, 0, buffer.Length);
                            if (readBytes == 0)
                            {
                                break;
                            }

                            outputStream.Write(buffer, 0, readBytes);
                        }
                    }
                }
            }
        }
    }
}