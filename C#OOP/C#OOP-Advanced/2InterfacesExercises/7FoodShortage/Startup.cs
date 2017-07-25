using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        IList<IBuyer> buyers = new List<IBuyer>();

        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var data = Console.ReadLine().Split(' ').ToList();

            if (data.Count == 3)
            {
                string name = data[0];
                int age = int.Parse(data[1]);
                string group = data[2];
                IBuyer rebel = new Rebel(name, age, group);
                buyers.Add(rebel);
            }

            else if (data.Count == 4)
            {
                string name = data[0];
                int age = int.Parse(data[1]);
                string id = data[2];
                string birthday = data[3];
                IBuyer citizen = new Citizen(name, age, id, birthday);
                buyers.Add(citizen);
            }
        }

        string input = Console.ReadLine();

        while (input != "End")
        {
            foreach (var buyer in buyers)
            {
                if (buyer.Name == input)
                {
                    buyer.BuyFood();
                }
            }

            input = Console.ReadLine();
        }

        Console.WriteLine(buyers.Sum(b => b.Food));
    }
}

