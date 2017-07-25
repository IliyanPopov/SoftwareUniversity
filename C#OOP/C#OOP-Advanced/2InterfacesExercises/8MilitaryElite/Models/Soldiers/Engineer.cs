using System.Collections.Generic;
using System.Text;

public class Engineer : SpecialisedSoldier, IEngineer
{
    public Engineer(string id, string firstName, string lastName, decimal salary, Corps corps,IList<IRepair> repairs) : base(id, firstName,
        lastName, salary, corps)
    {
        this.Repairs = repairs;
    }

    public IList<IRepair> Repairs { get; set; }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.AppendLine($"{base.ToString()}");
        sb.AppendLine($"Corps: {this.Corps}");
        sb.AppendLine("Repairs:");

        foreach (var repair in this.Repairs)
        {
            sb.AppendLine(repair.ToString());
        }

        return sb.ToString().Trim();
    }

    public void AddRepair(IRepair repair)
    {
        this.Repairs.Add(repair);
    }
}