namespace _12LittleJohn
{
    using System;
    using System.Linq;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            long smallArrowCounter = 0;
            long mediumArrowCounter = 0;
            long bigArrowCounter = 0;


            for (int i = 0; i < 4; i++)
            {
                string input = Console.ReadLine();

                Regex regex = new Regex(@"(>>>----->>|>>----->|>----->)(.*?)");
                MatchCollection matches = regex.Matches(input);

                foreach (Match match in matches)
                {
                    if (match.Value == ">>>----->>")
                    {
                        bigArrowCounter++;
                    }
                    else if (match.Value == ">>----->")
                    {
                        mediumArrowCounter++;
                    }
                    else if (match.Value == ">----->")
                    {
                        smallArrowCounter++;
                    }
                }
            }

            string numberConcat = smallArrowCounter.ToString() + mediumArrowCounter.ToString() +
                                  bigArrowCounter.ToString();

            long number = long.Parse(numberConcat);

            string binary = Convert.ToString(number, 2);
            var reversedBinary = binary.Reverse();
            string reversedBinaryString = string.Join("", reversedBinary);
            var resultString = binary + reversedBinaryString;
            var decimalNumber = Convert.ToInt64(resultString, 2);

            Console.WriteLine(decimalNumber);
        }
    }
}