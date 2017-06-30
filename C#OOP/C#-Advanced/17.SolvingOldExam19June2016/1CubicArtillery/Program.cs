namespace _1CubicArtillery
{
    using System;
    using System.Collections.Generic;

    public class Program
    {
        public static void Main()
        {
            int maxCapacity = int.Parse(Console.ReadLine());
            Queue<string> bunkers = new Queue<string>();
            Queue<int> weapons = new Queue<int>();
            int currentCapacity = maxCapacity;

            string input = Console.ReadLine();

            while (input != "Bunker Revision")
            {
                var data = input.Split(' ');

                foreach (var element in data)
                {
                    int weapon;

                    bool isNumber = int.TryParse(element, out weapon);
                    if (!isNumber)
                    {
                        bunkers.Enqueue(element);
                    }
                    else
                    {
                        var isSaved = false;
                        while (bunkers.Count > 1)
                        {
                            if (currentCapacity >= weapon)
                            {
                                weapons.Enqueue(weapon);
                                currentCapacity -= weapon;
                                isSaved = true;
                                break;
                            }

                            var removedBunker = bunkers.Dequeue();

                            if (weapons.Count == 0)
                            {
                                Console.WriteLine($"{removedBunker} -> Empty");
                            }
                            else
                            {
                                Console.WriteLine($"{removedBunker} -> {string.Join(", ", weapons)}");
                            }

                            weapons.Clear();
                            currentCapacity = maxCapacity;
                        }

                        if (!isSaved)
                        {
                            if (weapon <= maxCapacity)
                            {
                                while (currentCapacity < weapon)
                                {
                                    currentCapacity += weapons.Dequeue();
                                }

                                weapons.Enqueue(weapon);
                                currentCapacity -= weapon;
                            }
                        }
                    }
                }

                input = Console.ReadLine();
            }
        }
    }
}