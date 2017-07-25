namespace BashSoft
{
    using Contracts;
    using Contracts.Judge;
    using Contracts.Repository;

    public class Startup
    {
        public static void Main()
        {
            IContentComparer tester = new Tester();
            IDirecoryManager ioManager = new IOManager();
            IDatabase repo = new StudentsRepository(new RepositorySorter(), new RepositoryFilter());

            IInterpreter currentInterpreter = new CommandInterpreter(tester, repo, ioManager);
            IReader reader = new InputReader(currentInterpreter);

            reader.StartReadingCommands();
        }
    }
}