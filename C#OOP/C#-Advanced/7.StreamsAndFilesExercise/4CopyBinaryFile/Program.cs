namespace _4CopyBinaryFile
{
    using System;
    using System.IO;

    public class Program
    {
        const string HaircutImage = "GoodHaircut.jpg";
        const string DestinationPath = "result.jpg";

        public static void Main()
        {
            using (var source = new FileStream(HaircutImage, FileMode.Open))
            {
                using (var destination = new FileStream(DestinationPath, FileMode.Create))
                {
                    double fileLength = source.Length;
                    byte[] buffer = new byte[4096];
                    while (true)
                    {
                        int readBytes = source.Read(buffer, 0, buffer.Length);
                        if (readBytes == 0)
                        {
                            break;
                        }

                        destination.Write(buffer, 0, readBytes);

                        Console.WriteLine("{0:P}", Math.Min(source.Position / fileLength, 1));
                    }
                }
            }
        }
    }
}