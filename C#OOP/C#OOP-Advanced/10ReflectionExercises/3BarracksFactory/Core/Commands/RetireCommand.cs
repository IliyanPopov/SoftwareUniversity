public class RetireCommand : Command
{
    public RetireCommand(string[] data, IRepository repository, IUnitFactory unitFactory) : base(data, repository, unitFactory)
    {
    }

    public override string Execute()
    {
        string unitToRetire = this.Data[1];
        if (this.Repository.RemoveUnit(unitToRetire))
        {
            return unitToRetire + " retired!";
        }
        else
        {
            return "No such units in repository.";
        }
    }
}

