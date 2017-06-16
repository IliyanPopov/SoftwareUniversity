namespace _7SumBigNumbers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Program
    {
        public static void Main()
        {
            var bigInt_1 = new BigInt(Console.ReadLine().TrimStart(new Char[] { '0' }));
            var bigInt_2 = new BigInt(Console.ReadLine().TrimStart(new Char[] { '0' }));

            var result = BigInt.Add(bigInt_1, bigInt_2);

            Console.WriteLine(result.ToString());
        }
    }

    class BigInt
    {
        public BigInt(string number)
        {
            this.Integer = this.CalculateBigInteger(number);
        }

        public BigInt(List<int> list)
        {
            this.Integer = list;
        }

        public List<int> Integer { get; set; }

        private List<int> CalculateBigInteger(string number)
        {
            return number.Reverse()
                .Select(chararcter => int.Parse(chararcter.ToString()))
                .ToList();
        }

        public static BigInt Add(BigInt int_1, BigInt int_2)
        {
            var result = new List<int>();

            int carryOver = 0;

            IEnumerator<int> enumerator_1 = int_1.Integer.GetEnumerator();
            IEnumerator<int> enumerator_2 = int_2.Integer.GetEnumerator();

            enumerator_1.MoveNext();
            enumerator_2.MoveNext();

            bool hasNext_1 = true;
            bool hasNext_2 = true;

            while (hasNext_1 || hasNext_2)
            {
                var value = NumberAdd(enumerator_1.Current, enumerator_2.Current, ref carryOver);
                result.Add(value);

                hasNext_1 = enumerator_1.MoveNext();
                hasNext_2 = enumerator_2.MoveNext();
            }

            if (carryOver != 0)
            {
                result.Add(carryOver);
            }

            return new BigInt(result);
        }

        private static int NumberAdd(int value_1, int value_2, ref int carryOver)
        {
            var addResult = value_1 + value_2 + carryOver;
            carryOver = addResult / 10;
            var addValue = addResult % 10;
            return addValue;
        }

        public string ToString()
        {
            StringBuilder sb = new StringBuilder();
            foreach (var number in this.Integer)
            {
                sb.Append(number.ToString());
            }

            var reverseString = sb.ToString().ToCharArray();
            Array.Reverse(reverseString);
            return new string(reverseString);
        }
    }
}