using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        var line1 = Console.ReadLine().Split();
        string fullName = line1[0] + " " + line1[1];
        string address = line1[2];
        CustomTuple<string, string> nameAndAddress = new CustomTuple<string, string>(fullName, address);

        var line2 = Console.ReadLine().Split();
        string name = line2[0];
        int beerAmount = int.Parse(line2[1]);
        CustomTuple<string, int> nameAndBeer = new CustomTuple<string, int>(name, beerAmount);

        var line3 = Console.ReadLine().Split();
        int numberInt = int.Parse(line3[0]);
        double numberDouble = double.Parse(line3[1]);
        CustomTuple<int, double> twoNumbers = new CustomTuple<int, double>(numberInt, numberDouble);
        Console.WriteLine($"{nameAndAddress}");
        Console.WriteLine($"{nameAndBeer}");
        Console.WriteLine($"{twoNumbers}");
    }
}