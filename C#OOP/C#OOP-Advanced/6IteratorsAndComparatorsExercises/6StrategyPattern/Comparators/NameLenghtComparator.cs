using System;
using System.Collections.Generic;
public class NameLenghtComparator : IComparer<Person>
{
    public int Compare(Person x, Person y)
    {
        int result = x.Name.Length.CompareTo(y.Name.Length);

        if (result == 0)
        {
            result = String.Compare(x.Name[0].ToString().ToLower(), y.Name[0].ToString().ToLower(), StringComparison.Ordinal);
        }

        return result;
    }
}

