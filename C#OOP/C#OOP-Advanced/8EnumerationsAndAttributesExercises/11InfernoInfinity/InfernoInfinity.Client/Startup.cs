namespace InfernoInfinity.Client
{
    using Contracts;
    using Contracts.Core;
    using Core;
    using Data.Repositories;
    using IO;
    using Models.Factories;

    public class Startup
    {
        public static void Main()
        {
            WeaponFactory weaponFactory = new WeaponFactory();
            InfernoInMemoryRepository repository = new InfernoInMemoryRepository();
            IReader consoleReader = new ConsoleReader();
            IWriter consoleWriter = new ConsoleWriter();
            CommandInterpreter commandInterpreter = new CommandInterpreter(repository, consoleWriter, weaponFactory);
            IEngine engine = new Engine(commandInterpreter, consoleReader);
            engine.Run();
        }
    }
}