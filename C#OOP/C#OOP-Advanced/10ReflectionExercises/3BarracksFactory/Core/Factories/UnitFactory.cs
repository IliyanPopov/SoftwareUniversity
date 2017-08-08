using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;

public class UnitFactory : IUnitFactory
{
    // private readonly IDictionary<string, Type> _registeredUnits = new Dictionary<string, Type>();
    private readonly IList<Type> _registeredUnits = new List<Type>();

    public UnitFactory()
    {
        RegisterUnitsInFactory();
    }

    public IUnit CreateUnit(string unitType)
    {
        Type type = this._registeredUnits.FirstOrDefault(u => u.Name == unitType);
        var result = Activator.CreateInstance(type);

        return (IUnit)result;
    }

    private void RegisterUnitsInFactory()
    {
        var types =
            Assembly.GetExecutingAssembly().GetTypes()
                .Where(m => m.IsClass && m.GetInterface(nameof(IUnit)) != null);

        foreach (var type in types)
        {
            this._registeredUnits.Add(type);
        }
    }
}