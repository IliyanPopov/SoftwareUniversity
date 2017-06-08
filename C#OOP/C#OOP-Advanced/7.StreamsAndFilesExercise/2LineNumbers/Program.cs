namespace _2LineNumbers
{
    using System.IO;

    public class Program
    {
        static void Main()
        {
            using (var reader = new StreamReader("sometext.txt"))
            {
                int lineNumber = 0;

                using (var writer = new StreamWriter("sometextWithLines.txt"))
                {
                    string line = reader.ReadLine();
                    while (line != null)
                    {
                        writer.Write($"{lineNumber} {line}");

                        writer.WriteLine();
                        line = reader.ReadLine();
                        lineNumber++;
                    }
                }
            }
        }
    }
}