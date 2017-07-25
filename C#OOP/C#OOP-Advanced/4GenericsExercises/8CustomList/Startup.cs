public class Startup
{
    public static void Main()
    {
        CommandInterpreter commandInterpreter = new CommandInterpreter();
        commandInterpreter.StartReadingCommands();
    }
}

