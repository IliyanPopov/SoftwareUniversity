using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {
        List<TrafficLight> trafficLights = new List<TrafficLight>();

        var colorTypes = Console.ReadLine().Split();

        foreach (var colortype in colorTypes)
        {
            TrafficLight trafficLight = new TrafficLight(colortype);
            trafficLights.Add(trafficLight);
        }

        int n = int.Parse(Console.ReadLine());


        for (int i = 0; i < n; i++)
        {
            foreach (var trafficLight in trafficLights)
            {
                trafficLight.ChangeColor();
                Console.Write(trafficLight + " ");
            }
            Console.WriteLine();
        }
    }
}