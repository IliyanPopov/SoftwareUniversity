using System.Collections.Generic;
using System.Net.NetworkInformation;

public class AddCollection<T> : IAddCollection<T>
{
    private readonly List<T> _items;

    public AddCollection()
    {
        this._items = new List<T>();
    }

    public int Add(T item)
    {
        this._items.Add(item);
        return this._items.Count - 1;
    }
}

