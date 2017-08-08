using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    public string StealFieldInfo(string className, params string[] fieldNames)
    {
        StringBuilder sb = new StringBuilder();
        var classType = Type.GetType(className);
        var fields = classType.GetFields(BindingFlags.Public | BindingFlags.NonPublic | BindingFlags.Instance |
                                         BindingFlags.Static);
        object classInstance = Activator.CreateInstance(classType, new object[] { });

        sb.AppendLine($"Class under investigaton: {className}");
        foreach (var field in fields.Where(f => fieldNames.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return sb.ToString().Trim();
    }

    public string AnalyzeAcessModifiers(string className)
    {
        Type classType = Type.GetType(className);

        var classFIelds = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.Public);

        var classPublicMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.Public);

        var classPrivateMethods = classType.GetMethods(BindingFlags.Instance | BindingFlags.NonPublic);

        StringBuilder sb = new StringBuilder();

        foreach (var field in classFIelds)
        {
            sb.AppendLine($"{field.Name} must be private!");
        }

        foreach (var method in classPrivateMethods.Where(m => m.Name.StartsWith("get")))
        {
            sb.AppendLine($"{method.Name} have to be public!");
        }

        foreach (var classPublicMethod in classPublicMethods.Where(m => m.Name.StartsWith("set")))
        {
            sb.AppendLine($"{classPublicMethod.Name} have to be private!");
        }

        return sb.ToString().Trim();
    }
}