using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;

public class Startup
{
    public static void Main()
    {
        IList<IEntity> entities = new List<IEntity>();

        string input = Console.ReadLine();

        while (input != "End")
        {
            var data = input.Split(' ').ToList();
            if (data.Count == 2)
            {
                var model = data[0];
                var id = data[1];

                IEntity robot = new Robot(model, id);
                entities.Add(robot);
            }

            else if (data.Count == 3)
            {
                var name = data[0];
                int age = int.Parse(data[1]);
                var id = data[2];

                IEntity citizen = new Citizen(name,age,id);
                entities.Add(citizen);
            }
            input = Console.ReadLine();
        }

        string detainedEndingsOfIds = Console.ReadLine();

        foreach (var entity in entities)
        {
            if (entity.Id.EndsWith(detainedEndingsOfIds))
            {
                Console.WriteLine(entity.Id);
            }
        }

    }
}

