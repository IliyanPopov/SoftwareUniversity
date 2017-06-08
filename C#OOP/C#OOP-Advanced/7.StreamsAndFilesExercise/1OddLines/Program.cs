namespace _1OddLines
{
    using System;
    using System.IO;

    public class Program
    {
        public static void Main()
        {
            using (StreamReader reader = new StreamReader("somefile.txt"))
            {
                int lineNumber = 0;
                string line = reader.ReadLine();
                while (line != null)
                {
                    lineNumber++;
                    if (lineNumber % 2 == 1)
                    {
                        Console.WriteLine("Line {0}: {1}", lineNumber, line);
                    }

                    line = reader.ReadLine();
                }
            }
        }
    }
}