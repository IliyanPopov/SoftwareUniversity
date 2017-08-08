using System;
using System.Collections.Generic;
using _03BarracksFactory.Contracts;

public class CommandInterpreter
{
    private readonly IUnitFactory _unitFactory;
    private readonly IRepository _repository;

    public CommandInterpreter(IRepository repository, IUnitFactory unitFactory)
    {
        this._repository = repository;
        this.IsRunning = true;
        this._unitFactory = unitFactory;
    }

    public bool IsRunning { get; private set; }

    public void InterpredCommand(string input)
    {
        string[] data = input.Split();
        string commandName = data[0];

        try
        {
            ICommand command = ParseCommand(data, commandName);
            Console.WriteLine(command.Execute());
        }
        catch (Exception e)
        {
            Console.WriteLine(e.Message);
        }
    }

    private ICommand ParseCommand(string[] data, string commandName)
    {
        switch (commandName)
        {
            case "add":
                return new AddCommand(data, this._repository, this._unitFactory);
            case "report":
                return new ReportCommand(data, this._repository, this._unitFactory);
            case "retire":
                return new RetireCommand(data, this._repository, this._unitFactory);
            case "fight":
                this.IsRunning = false;
                return new FightCommand(data, this._repository, this._unitFactory);
            default:
                throw new NotImplementedException("Command not Implemented!");
        }
    }
}

