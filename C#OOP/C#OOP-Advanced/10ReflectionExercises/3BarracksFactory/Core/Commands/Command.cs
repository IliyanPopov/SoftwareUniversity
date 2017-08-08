using _03BarracksFactory.Contracts;

public abstract class Command : ICommand
{
    private string[] _data;
    private IRepository _repository;
    private IUnitFactory _unitFactory;

    protected Command(string[] data, IRepository repository, IUnitFactory unitFactory)
    {
        this.Data = data;
        this.Repository = repository;
        this.UnitFactory = unitFactory;
    }

    protected string[] Data
    {
        get { return this._data; }
        private set { this._data = value; }
    }

    protected IRepository Repository
    {
        get { return this._repository; }
        private set { this._repository = value; }
    }

    protected IUnitFactory UnitFactory
    {
        get { return this._unitFactory; }
        private set { this._unitFactory = value; }
    }


    public abstract string Execute();

}