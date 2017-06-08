namespace _9HandOfCards
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            Dictionary<string, HashSet<string>> dictionary = new Dictionary<string, HashSet<string>>();

            while (input != "JOKER")
            {
                string[] data = input.Trim()
                    .Split(':').ToArray();
                string name = data[0];

                string[] cards = data[1].Split(new char[] {','}, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                HashSet<string> cardsSet = new HashSet<string>();

                if (!dictionary.ContainsKey(name))
                {
                    foreach (var card in cards)
                    {
                        cardsSet.Add(card);
                    }

                    dictionary.Add(name, cardsSet);
                }
                else
                {
                    foreach (var card in cards)
                    {
                        dictionary[name].Add(card);
                    }
                }

                input = Console.ReadLine();
            }

            foreach (var pair in dictionary)
            {
                Console.WriteLine($"{pair.Key}: {ConvertToPoints(pair.Value)}");
            }
        }

        private static long ConvertToPoints(HashSet<string> cards)
        {
            long totalPoints = 0;

            foreach (var card in cards)
            {
                string firstPart = card.Substring(0, card.Length - 1);
                string secondPart = card.Substring(card.Length - 1);

                int firstNumber;
                if (int.TryParse(firstPart, out firstNumber))
                {
                }
                else
                {
                    firstNumber = (int) Enum.Parse(typeof(CardType), firstPart);
                }

                var secondNumber = (int) Enum.Parse(typeof(CardMultiplier), secondPart);

                totalPoints += (firstNumber * secondNumber);
            }

            return totalPoints;
        }

        private enum CardMultiplier
        {
            C = 1,
            D = 2,
            H = 3,
            S = 4
        }

        private enum CardType
        {
            J = 11,
            Q = 12,
            K = 13,
            A = 14
        }
    }
}