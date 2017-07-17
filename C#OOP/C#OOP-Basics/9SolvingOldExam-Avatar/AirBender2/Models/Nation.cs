using System.Collections.Generic;
using System.Linq;
using System.Text;

public class Nation
{
    private readonly List<Bender> benders;
    private readonly List<Monument> monumets;

    public Nation()
    {
        this.benders = new List<Bender>();
        this.monumets = new List<Monument>();
    }

    public void AddBender(Bender bender)
    {
        this.benders.Add(bender);
    }

    public void AddMonument(Monument monument)
    {
        this.monumets.Add(monument);
    }

    public void DestroyBenders()
    {
        this.benders.Clear();
    }

    public void DestroyMonuments()
    {
        this.monumets.Clear();
    }

    public double GetTotalPowerPoints()
    {
        var benderPoints = this.benders.Sum(b => b.GetPowerPoints());
        var monumentPoints = this.monumets.Sum(m => m.GetAffinityPoints());

        var additionalPoints = benderPoints * monumentPoints / 100;

        return benderPoints + additionalPoints;
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        sb.Append("Benders:");
        if (this.benders.Count == 0)
        {
            sb.AppendLine(" None");
        }
        else
        {
            sb.AppendLine();
            foreach (var bender in this.benders)
            {
                sb.AppendLine($"###{bender}");
            }
        }

        sb.Append("Monuments:");
        if (this.monumets.Count == 0)
        {
            sb.AppendLine(" None");
        }
        else
        {
            sb.AppendLine();
            foreach (var monument in this.monumets)
            {
                sb.AppendLine($"###{monument}");
            }
        }

        return sb.ToString().Trim();
    }
}