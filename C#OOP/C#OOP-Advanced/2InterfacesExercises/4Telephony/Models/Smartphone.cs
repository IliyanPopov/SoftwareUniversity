using System;
using System.Collections.Generic;
using System.Linq;

public class Smartphone : ICallable, IBrowsable
{
    public void Call(string number)
    {
        bool isValid = number.ToCharArray().All(char.IsDigit);
        if (isValid)
        {
            Console.WriteLine($"Calling... {number}");
        }
        else
        {
            Console.WriteLine("Invalid number!");
        }
    }

    public void Browse(string website)
    {
        bool isValid = website.ToCharArray().All(z => !char.IsDigit(z));

        if (isValid)
        {
            Console.WriteLine($"Browsing: {website}!");
        }
        else
        {
            Console.WriteLine("Invalid URL!");
        }
    }
}

