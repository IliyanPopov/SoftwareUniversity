using System;
using System.Linq;
using System.Reflection;

public class Tracker
{
    public static void PrintMethodsByAuthor()
    {
        var type = typeof(Startup);
        var methods = type.GetMethods(BindingFlags.Instance |
                                      BindingFlags.Public | BindingFlags.Static);
        foreach (var mInfo in methods)
        {
            if (mInfo.CustomAttributes
                .Any(n => n.AttributeType == typeof(SoftUniAttribute)))
            {
                var attrs = mInfo.GetCustomAttributes(false);
                foreach (SoftUniAttribute attr in attrs)
                {
                    Console.WriteLine($"{mInfo.Name} is written by {attr.Name}");
                }
            }
        }
    }
}