namespace _3NMS
{
    using System;
    using System.Collections.Generic;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            string input = Console.ReadLine();
            List<string> words = new List<string>();

            StringBuilder sb = new StringBuilder();

            while (input != "---NMS SEND---")
            {
                sb.Append(input);

                input = Console.ReadLine();
            }
            string detelimiter = Console.ReadLine();


            int lenght = 0;
            string text = sb.ToString();

            for (int i = 1; i < text.Length; i++)
            {
                char lower1 = char.ToLower(text[i]);
                char lower2 = char.ToLower(text[i - 1]);
                if (lower1 >= lower2)
                {
                    lenght++;
                }
              
                else
                {
                    string word = text.Substring(0, lenght + 1);
                    words.Add(word);

                    text = text.Substring(lenght + 1);
                    i = 0;
                    lenght = 0;
                }

                if (i == text.Length - 1 && lenght >= 0)
                {
                    string word = text.Substring(0, lenght + 1);
                    words.Add(word);
                }
            }


            Console.WriteLine(string.Join(detelimiter, words));
        }
    }
}