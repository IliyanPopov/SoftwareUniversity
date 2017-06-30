namespace _5ConvertFromBaseNToBase10
{
    using System;
    using System.Linq;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            var input = Console.ReadLine().Split().ToArray();

            int startBase = int.Parse(input[0]);
            string num = string.Join("", input[1].ToCharArray().Reverse());

            BigInteger numInBase10 = 0;

            int counter = -1;

            for (int i = 0; i < num.Length; i++)
            {
                numInBase10 += BigInteger.Pow(startBase, ++counter) * BigInteger.Parse(num[i].ToString());
            }

            Console.WriteLine(numInBase10);
        }
    }
}