using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        List<string> numbers = Console.ReadLine().Split(' ').ToList();
        List<string> websites = Console.ReadLine().Split(' ').ToList();

        ICallable smartphone = new Smartphone();
        IBrowsable smartphoneBrowsable = new Smartphone();

        foreach (var number in numbers)
        {
            smartphone.Call(number);
        }

        foreach (var website in websites)
        {
            smartphoneBrowsable.Browse(website);
        }
    }
}

