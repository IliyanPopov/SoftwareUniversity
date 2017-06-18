namespace _13TriFunction
{
    using System;
    using System.Linq;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            var names = Console.ReadLine()
                .Split(new string[] {" "}, StringSplitOptions.RemoveEmptyEntries)
                .ToArray();

            var comparisonFunc = ComparisonFunc();

            var name = GetValue(names, comparisonFunc, n);

            var printer = Printer();
            printer.Invoke(name);
        }

        private static Action<string> Printer()
        {
            Action<string> printer = x => Console.WriteLine(x);
            return printer;
        }

        private static Func<string, int, bool> ComparisonFunc()
        {
            Func<string, int, bool> comparisonFunc = (x, y) => x.Sum(z => z) >= y;
            return comparisonFunc;
        }

        private static string GetValue(string[] names, Func<string, int, bool> comparisonFunc, int n)
        {
            for (int i = 0; i < names.Length; i++)
            {
                if (comparisonFunc(names[i], n))
                {
                    return names[i];
                }
            }
            return string.Empty;
        }
    }
}