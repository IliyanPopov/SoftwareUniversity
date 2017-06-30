namespace _3WordCount
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
            List<string> words = new List<string>();

            // read words from file
            using (StreamReader reader = new StreamReader("words.txt"))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    string[] wordsInText = line.Split(new char[] {' '}, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.ToLower())
                        .ToArray();

                    words.AddRange(wordsInText);
                    line = reader.ReadLine();
                }
            }

            //put words in dictionary
            Dictionary<string, int> dictionary = new Dictionary<string, int>();

            foreach (string word in words)
            {
                dictionary.Add(word, 0);
            }

            List<string> text = new List<string>();
            char[] dividers = {'-', '.', ',', ':', ';', '(', ')', '[', ']', '\\', '\"', '\'', '/', '!', '?', ' '};
            using (StreamReader reader = new StreamReader("text.txt"))
            {
                string line = reader.ReadLine();

                while (line != null)
                {
                    string[] wordsInText = line.Split(dividers, StringSplitOptions.RemoveEmptyEntries)
                        .Select(x => x.ToLower())
                        .ToArray();

                    text.AddRange(wordsInText);
                    line = reader.ReadLine();
                }


                foreach (string word in text)
                {
                    if (dictionary.ContainsKey(word))
                    {
                        dictionary[word]++;
                    }
                }
            }

            // combine results into 1 string
            StringBuilder sb = new StringBuilder();
            foreach (var pair in dictionary.OrderByDescending(x => x.Value))
            {
                sb.Append($"{pair.Key} - {pair.Value}");
                sb.Append(Environment.NewLine);
            }

            //write string to file
            var fileStream = new FileStream("result.txt", FileMode.Create);
            try
            {
                byte[] bytes = Encoding.UTF8.GetBytes(sb.ToString());
                fileStream.Write(bytes, 0, bytes.Length);
            }
            finally
            {
                fileStream.Close();
            }
        }
    }
}