using System.Collections.Generic;
using System.Linq;

public class Box<T> : IBox<T>
{
    private readonly List<T> _items;

    public Box()
    {
        this._items = new List<T>();
    }

    public void Add(T t)
    {
        this._items.Add(t);
    }

    public T Remove()
    {
        var lastItem = this._items.LastOrDefault();
        this._items.RemoveAt(this._items.Count - 1);
        return lastItem;
    }

    public int Count => this._items.Count;

}