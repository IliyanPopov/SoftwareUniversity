using System;
using System.Collections;
using System.Collections.Generic;

public class ListyIterator<T> : IListyIterator<T>
{
    private IList<T> _items;
    private int currentIndexCounter;

    public ListyIterator(IList<T> items)
    {
        this._items = items;
    }

    public bool Move() => ++this.currentIndexCounter < this._items.Count;


    public bool HasNext() => this.currentIndexCounter < this._items.Count - 1;


    public void Print()
    {
        if (this._items.Count == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }
        Console.WriteLine(this._items[this.currentIndexCounter]);
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this._items.Count; i++)
        {
            yield return this._items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}