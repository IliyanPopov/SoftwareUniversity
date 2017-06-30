namespace _1StudentsResults
{
    using System;
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine($"{"Name",-10}|{"CAdv",7}|{"COOP",7}|{"AdvOOP",7}|{"Average",7}|");
            for (int i = 0; i < n; i++)
            {
                string result = Console.ReadLine();
                string[] data = result
                    .Split(new char[] { ' ', ',', '-' }, StringSplitOptions.RemoveEmptyEntries)
                    .ToArray();

                string name = data[0];
                float cAdv = float.Parse(data[1]);
                float cOOP = float.Parse(data[2]);
                float advOOP = float.Parse(data[3]);
                float average = (cAdv + cOOP + advOOP) / 3;
                Console.WriteLine($"{name,-10}|{cAdv,7:F2}|{cOOP,7:F2}|{advOOP,7:F2}|{average,7:F4}|");
            }
        }
    }
}