using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

public class MyList<T> : IMyList<T>
{
    private readonly List<T> _items;

    public MyList()
    {
        this._items = new List<T>(0);
    }

    public int Add(T item)
    {
        this._items.Insert(0, item);
        return 0;
    }

    public T Remove()
    {
        var firstItem = this._items.FirstOrDefault();
        this._items.Remove(firstItem);
        return firstItem;
    }

    public int Used => this._items.Count;
}