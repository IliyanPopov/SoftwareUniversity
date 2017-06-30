namespace _3OldestFamilyMember
{
    using System;

    public class Program
    {
        public static void Main()
        {
            int n = int.Parse(Console.ReadLine());
            Family family = new Family();

            for (int i = 0; i < n; i++)
            {
                var data = Console.ReadLine().Split(' ');

                Person person = new Person
                {
                    name = data[0],
                    age = Int32.Parse(data[1])
                };
                family.AddMember(person);
            }

            var oldestMember = family.GetOldestMember();
            Console.WriteLine($"{oldestMember.name} {oldestMember.age}");
        }
    }
}