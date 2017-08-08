public class FightCommand : Command
{
    public FightCommand(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
    {
    }

    public override string Execute()
    {
        //add ending text here
        return "";
    }
}

