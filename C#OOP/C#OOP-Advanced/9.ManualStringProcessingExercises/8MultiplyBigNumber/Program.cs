namespace _8MultiplyBigNumber
{
    using System;
    using System.Numerics;

    public class Program
    {
        public static void Main()
        {
            BigInteger num1 = BigInteger.Parse(Console.ReadLine());
            BigInteger num2 = BigInteger.Parse(Console.ReadLine());

            var result = num1 * num2;

            Console.WriteLine(result);
        }
    }
}