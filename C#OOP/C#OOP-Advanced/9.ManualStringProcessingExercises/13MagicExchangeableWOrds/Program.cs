namespace _13MagicExchangeableWOrds
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries);
            string firstWord = input[0];
            string secondWord = input[1];
            var firstList = new List<char>();
            var secondList = new List<char>();
            foreach (char c in firstWord)
            {
                firstList.Add(c);
            }
            foreach (char c in secondWord)
            {
                secondList.Add(c);
            }
            var firstUniqueChars = firstList.Distinct();
            var secondUniquechars = secondList.Distinct();
            if (firstUniqueChars.Count() == secondUniquechars.Count())
            {

                Console.WriteLine("true");
            }
            else
            {
                Console.WriteLine("false");
            }
        }
    }
}