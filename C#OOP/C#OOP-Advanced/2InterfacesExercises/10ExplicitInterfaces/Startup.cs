using System;

public class Startup
{
    public static void Main()
    {
        string input = Console.ReadLine();

        while (input != "End")
        {
            var data = input.Split();

            ICitizen dude = new Citizen(data[0], data[1], int.Parse(data[2]));

            var person = (IPerson) dude;
            Console.WriteLine(person.GetName());

            var resident = (IResident) dude;
            Console.WriteLine(resident.GetName());

            input = Console.ReadLine();
        }
    }
}