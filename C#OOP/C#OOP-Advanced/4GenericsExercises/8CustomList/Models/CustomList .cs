using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;

public class CustomList<T> : ICustomList<T>, IEnumerable<T> where T : IComparable<T>
{
    private readonly IList<T> _items;

    public CustomList()
        : this(Enumerable.Empty<T>())
    {
        this._items = new List<T>();
    }

    public CustomList(IEnumerable<T> elements)
    {
        this._items = new List<T>(elements);
    }

    public void Add(T t)
    {
        this._items.Add(t);
    }

    public T Remove(int index)
    {
        T element = this._items[index];
        this._items.RemoveAt(index);

        return element;
    }

    public bool Contains(T element)
    {
        return this._items.Contains(element);
    }

    public void Swap(int index1, int index2)
    {
        T tmp = this._items[index1];
        this._items[index1] = this._items[index2];
        this._items[index2] = tmp;
    }


    public int CountGreaterThan(T element) =>
        this._items.Count(e => e.CompareTo(element) > 0);

    public T Max()
    {
        return this._items.Max();
    }

    public T Min()
    {
        return this._items.Min();
    }

    public IList<T> Elements => this._items;


    public IEnumerator<T> GetEnumerator()
    {
        return this._items.GetEnumerator();
    }
    IEnumerator IEnumerable.GetEnumerator()
    {
        return this.GetEnumerator();
    }
}