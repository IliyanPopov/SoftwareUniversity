using System;

internal class Engine : IRunnable
{
    private readonly CommandInterpreter _commandInterpreter;
    public Engine(CommandInterpreter commandInterpreter)
    {
        this._commandInterpreter = commandInterpreter;
    }

    public void Run()
    {
        string input = Console.ReadLine();

        while (this._commandInterpreter.IsRunning)
        {
            this._commandInterpreter.InterpredCommand(input);

            if (this._commandInterpreter.IsRunning)
            {
                input = Console.ReadLine();
            }
        }
    }
}