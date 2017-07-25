using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        var line1 = Console.ReadLine().Split();
        string fullName = line1[0] + " " + line1[1];
        string address = line1[2];
        string town = line1[3];
        Treeuple<string, string, string> nameAndAddress = new Treeuple<string, string, string>(fullName, address, town);

        var line2 = Console.ReadLine().Split();
        string name = line2[0];
        int beerAmount = int.Parse(line2[1]);
        bool isDrunk = line2[2] == "drunk";

        Treeuple<string, int, bool> nameAndBeer = new Treeuple<string, int, bool>(name, beerAmount, isDrunk);

        var line3 = Console.ReadLine().Split();
        string personName = line3[0];
        double accountBalance = double.Parse(line3[1]);
        string bankName = line3[2];

        Treeuple<string,double,string> nameAccountBalance = new Treeuple<string, double, string>(personName,accountBalance,bankName);
        Console.WriteLine($"{nameAndAddress}");
        Console.WriteLine($"{nameAndBeer}");
        Console.WriteLine($"{nameAccountBalance}");
    }
}