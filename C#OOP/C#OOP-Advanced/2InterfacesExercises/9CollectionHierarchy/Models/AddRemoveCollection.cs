using System;
using System.Collections.Generic;
using System.Linq;

public class AddRemoveCollection<T> : IAddRemoveCollection<T>
{
    private readonly List<T> _items;

    public AddRemoveCollection()
    {
        this._items = new List<T>();
    }

    public int Add(T item)
    {
        this._items.Insert(0, item);
        return 0;
    }

    public T Remove()
    {
        var lastItem = this._items.LastOrDefault();
        this._items.Remove(lastItem);

        return lastItem;
    }
}