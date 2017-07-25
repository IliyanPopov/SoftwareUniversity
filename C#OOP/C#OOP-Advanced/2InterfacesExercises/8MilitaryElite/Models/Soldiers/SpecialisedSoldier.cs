public abstract class SpecialisedSoldier : Private, ISpecialisedSoldier
{
    public Corps Corps { get; set; }

    protected SpecialisedSoldier(string id, string firstName, string lastName, decimal salary, Corps corps) : base(id, firstName, lastName, salary)
    {
        this.Corps = corps;
    }
}
public enum Corps
{
    Airforces,
    Marines
}