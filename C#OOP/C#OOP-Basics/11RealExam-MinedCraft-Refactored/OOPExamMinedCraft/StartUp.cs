namespace OOPExamMinedCraft
{
    using Common.Utilities;
    using Core;
    using Minedcraft.Data;

    public class StartUp
    {
        public static void Main()
        {
            MinedraftRepository minedraftRepository = new MinedraftRepository();
            OutputWriter outputWriter = new OutputWriter();
            Engine engine = new Engine(minedraftRepository, outputWriter);
            engine.Run();
        }
    }
}