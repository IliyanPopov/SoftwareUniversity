namespace _2StringLenght
{
    using System;

    public class Program
    {
        public static void Main()
        {
            const int textLenghtLimit = 20;
            char[] textArr = new char[20];

            string text = Console.ReadLine();

            if (text.Length < 20)
            {
                for (int i = 0; i < text.Length; i++)
                {
                    textArr[i] = text[i];
                }

                for (int i = text.Length; i < textLenghtLimit; i++)
                {
                    textArr[i] = '*';
                }
            }
            else
            {
                for (int i = 0; i < 20; i++)
                {
                    textArr[i] = text[i];
                }
            }

            Console.WriteLine(string.Join("", textArr));
        }
    }
}