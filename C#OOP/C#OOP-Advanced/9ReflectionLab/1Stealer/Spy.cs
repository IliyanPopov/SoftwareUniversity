using System;
using System.Linq;
using System.Reflection;
using System.Text;

public class Spy
{
    //public string StealFieldInfo(string investigatedClass, params string[] requestedFields)
    //{
    //    var classType = Type.GetType(investigatedClass);
    //    var fields = classType.GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);
    //    StringBuilder stringBuilder = new StringBuilder();

    //    object classInstance = Activator.CreateInstance(classType, new object[] { });

    //    stringBuilder.AppendLine($"Class under investigaton: {investigatedClass}");

    //    foreach (var field in fields.Where(f => requestedFields.Contains(f.Name)))
    //    {
    //        stringBuilder.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
    //    }

    //    return stringBuilder.ToString().Trim();
    //}

    public string StealFieldInfo(string nameOfClass, params string[] nameOfFields)
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"Class under investigation: {nameOfClass}");

        Type classType = Type.GetType(nameOfClass);
        FieldInfo[] fields = classType
            .GetFields(BindingFlags.Instance | BindingFlags.Static | BindingFlags.NonPublic | BindingFlags.Public);

        object classInstance = Activator.CreateInstance(classType, new object[] { });
        foreach (FieldInfo field in fields.Where(f => nameOfFields.Contains(f.Name)))
        {
            sb.AppendLine($"{field.Name} = {field.GetValue(classInstance)}");
        }

        return sb.ToString().Trim();
    }
}