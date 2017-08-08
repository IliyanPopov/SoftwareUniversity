public interface IRepository
{
    void AddUnit(IUnit unit);
    string Statistics { get; }
    bool RemoveUnit(string unitToRetire);
}
