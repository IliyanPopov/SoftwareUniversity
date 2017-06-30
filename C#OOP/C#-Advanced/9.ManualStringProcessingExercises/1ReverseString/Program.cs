namespace _1ReverseString
{
    using System;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            string text = Console.ReadLine();

            var result = ReverseString(text);

            Console.WriteLine(result);
        }

        private static string ReverseString(string text)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = text.Length - 1; i >= 0; i--)
            {
                sb.Append(text[i]);
            }
            return sb.ToString();
        }
    }
}