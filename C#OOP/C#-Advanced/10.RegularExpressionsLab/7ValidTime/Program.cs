﻿namespace _7ValidTime
{
    using System;
    using System.Text.RegularExpressions;

    public class Program
    {
        public static void Main()
        {
            Regex regex = new Regex(@"^([01][0-9]):([012345][0-9]):([012345][0-9]) [AP]M$");
            string input = Console.ReadLine();

            while (input != "END")
            {
                Match match = regex.Match(input);
                if (match.Success)
                {
                    if (IsValidTime(match))
                    {
                        Console.WriteLine("valid");
                    }

                    else
                    {
                        Console.WriteLine("invalid");
                    }
                }

                else
                {
                    Console.WriteLine("invalid");
                }

                input = Console.ReadLine();
            }
        }

        public static bool IsValidTime(Match clock)
        {
            int hours = int.Parse(clock.Groups[1].Value);
            int minutes = int.Parse(clock.Groups[2].Value);
            int seconds = int.Parse(clock.Groups[3].Value);
            if (hours >= 0 && hours <= 12)
            {
                if (minutes >= 0 && minutes < 60)
                {
                    if (seconds >= 0 && seconds < 60)
                    {
                        return true;
                    }
                }
            }

            return false;
        }
    }
}