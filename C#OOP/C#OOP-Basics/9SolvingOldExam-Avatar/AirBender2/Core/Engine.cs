using System;
using System.Collections.Generic;
using System.Linq;

public class Engine
{
    private readonly NationsBuilder nationsBuilder;
    private bool isRunning = true;

    public Engine()
    {
        this.nationsBuilder = new NationsBuilder();
    }

    public void Run()
    {
        string input = Console.ReadLine();

        while (this.isRunning)
        {
            List<string> commandArgs = input.Split(' ').ToList();
            string commandType = commandArgs[0];
            commandArgs.Remove(commandType);

            switch (commandType)
            {
                case "Bender":
                    this.nationsBuilder.AssignBender(commandArgs);
                    break;
                case "Monument":
                    this.nationsBuilder.AssignMonument(commandArgs);
                    break;
                case "Status":
                    string nationType = commandArgs[0];
                    Console.WriteLine(this.nationsBuilder.GetStatus(nationType));
                    break;
                case "War":
                    this.nationsBuilder.IssueWar(commandArgs[0]);
                    break;
                case "Quit":
                    var result = this.nationsBuilder.GetWarsRecord();
                    Console.WriteLine(result);
                    this.isRunning = false;
                    break;
            }
            input = Console.ReadLine();
        }
    }
}