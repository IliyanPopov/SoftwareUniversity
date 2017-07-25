using System;

public class Startup
{
    public static void Main()
    {
        string driver = Console.ReadLine();

        ICar ferrai = new Ferrari(driver);
        Console.WriteLine(ferrai.ToString());
    }
}

