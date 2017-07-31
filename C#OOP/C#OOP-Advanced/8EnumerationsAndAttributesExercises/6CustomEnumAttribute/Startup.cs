using System;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        var rank = Console.ReadLine();
        ;
        Type elementType = Type.GetType(rank);


        if (elementType.CustomAttributes.Any(n => n.AttributeType == typeof(TypeAttribute)))
        {
            var attributes = elementType.GetCustomAttributes(false);

            foreach (var typeAttribute in attributes)
            {
                Console.WriteLine($"{typeAttribute}");
            }
        }
    }
}