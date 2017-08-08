using System.Collections.Generic;
using System.Text;

internal class UnitRepository : IRepository
{
    private readonly IDictionary<string, int> _amountOfUnits;

    public UnitRepository()
    {
        this._amountOfUnits = new SortedDictionary<string, int>();
    }

    public string Statistics
    {
        get
        {
            StringBuilder statBuilder = new StringBuilder();
            foreach (var entry in this._amountOfUnits)
            {
                string formatedEntry =
                    $"{entry.Key} -> {entry.Value}";
                statBuilder.AppendLine(formatedEntry);
            }

            return statBuilder.ToString().Trim();
        }
    }

    public void AddUnit(IUnit unit)
    {
        string unitType = unit.GetType().Name;
        if (!this._amountOfUnits.ContainsKey(unitType))
        {
            this._amountOfUnits.Add(unitType, 0);
        }

        this._amountOfUnits[unitType]++;
    }

    public bool RemoveUnit(string unitToRetire)
    {
        if (this._amountOfUnits.ContainsKey(unitToRetire))
        {
            if (this._amountOfUnits[unitToRetire] > 0)
            {
                this._amountOfUnits[unitToRetire]--;
                return true;
            }
        }
        return false;
    }
}