namespace _1SecondNature
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            var secondNature = new List<int>();

            var flowers = Console.ReadLine().Split().Select(int.Parse).ToList();
            var buckets = Console.ReadLine().Split().Select(int.Parse).ToList();

            while (buckets.Count > 0 && flowers.Count > 0)
            {
                var waterLeft = buckets[buckets.Count - 1] - flowers[0];
                if (waterLeft == 0)
                {
                    secondNature.Add(flowers[0]);
                    flowers.RemoveAt(0);
                    buckets.RemoveAt(buckets.Count - 1);
                }
                else if (waterLeft > 0)
                {
                    flowers.RemoveAt(0);
                    if (buckets.Count > 1)
                    {
                        buckets.RemoveAt(buckets.Count - 1);
                        buckets[buckets.Count - 1] += waterLeft;
                    }
                    else
                    {
                        buckets[buckets.Count - 1] = waterLeft;
                    }
                }
                else if (waterLeft < 0)
                {
                    flowers[0] -= buckets[buckets.Count - 1];
                    buckets.RemoveAt(buckets.Count - 1);
                }
            }

            if (flowers.Count > buckets.Count)
            {
                Console.WriteLine(string.Join(" ", flowers));
            }
            else if (buckets.Count > flowers.Count)
            {
                Console.WriteLine(string.Join(" ", buckets.ToArray().Reverse()));
            }
            if (secondNature.Count > 0)
            {
                Console.WriteLine(string.Join(" ", secondNature));
            }
            else
            {
                Console.WriteLine("None");
            }
        }
    }
}