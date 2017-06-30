namespace _1DefineClassPerson
{
    using System;
    using System.Reflection;

    class Program
    {
        static void Main(string[] args)
        {
            Type personType = typeof(Person);
            FieldInfo[] fields = personType.GetFields(BindingFlags.Public | BindingFlags.Instance);
            Console.WriteLine(fields.Length);
        }

    }
}