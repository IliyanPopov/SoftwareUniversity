using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class HarvestingFieldsTest
{
    public static void Main(string[] args)
    {
        string input = Console.ReadLine();

        while (input != "HARVEST")
        {
            switch (input)
            {
                case "private":
                    Console.WriteLine(ProcessPrivate());
                    break;
                case "protected":
                    Console.WriteLine(ProcessProtected());
                    break;
                case "public":
                    Console.WriteLine(ProcessPublic());
                    break;
                case "all":
                    Console.WriteLine(ProcessAll());
                    break;
            }
            input = Console.ReadLine();
        }
    }

    private static string ProcessPrivate()
    {
        StringBuilder sb = new StringBuilder();
        var type = Type.GetType(nameof(HarvestingFields));

        var fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (var fieldInfo in fields.Where(f => f.IsPrivate))
        {
            sb.AppendLine($"{fieldInfo.Attributes.ToString().ToLower()} {fieldInfo.FieldType.Name} {fieldInfo.Name}");
        }
        return sb.ToString().Trim();
    }

    private static string ProcessProtected()
    {
        StringBuilder sb = new StringBuilder();
        var type = Type.GetType(nameof(HarvestingFields));

        var fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic);

        foreach (var fieldInfo in fields.Where(f => f.IsFamily))
        {
            sb.AppendLine($"protected {fieldInfo.FieldType.Name} {fieldInfo.Name}");
        }
        return sb.ToString().Trim();
    }

    private static string ProcessPublic()
    {
        StringBuilder sb = new StringBuilder();
        var type = Type.GetType(nameof(HarvestingFields));

        var fields = type.GetFields(BindingFlags.Instance | BindingFlags.Public);

        foreach (var fieldInfo in fields.Where(f => f.IsPublic))
        {
            sb.AppendLine($"{fieldInfo.Attributes.ToString().ToLower()} {fieldInfo.FieldType.Name} {fieldInfo.Name}");
        }
        return sb.ToString().Trim();
    }


    private static string ProcessAll()
    {
        StringBuilder sb = new StringBuilder();
        var type = Type.GetType(nameof(HarvestingFields));

        var fields = type.GetFields(BindingFlags.Instance | BindingFlags.NonPublic | BindingFlags.Static |
                                    BindingFlags.Public);

        foreach (var fieldInfo in fields)
        {
            if (fieldInfo.IsPublic)
            {
                sb.AppendLine($"{fieldInfo.Attributes.ToString().ToLower()} {fieldInfo.FieldType.Name} {fieldInfo.Name}");
            }
            else if (fieldInfo.IsPrivate)
            {
                sb.AppendLine($"{fieldInfo.Attributes.ToString().ToLower()} {fieldInfo.FieldType.Name} {fieldInfo.Name}");
            }
            else if (fieldInfo.IsFamily)
            {
                sb.AppendLine($"protected {fieldInfo.FieldType.Name} {fieldInfo.Name}");
            }
        }
        return sb.ToString().Trim();
    }
}