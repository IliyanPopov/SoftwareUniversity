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

    public bool Move()
    {
        if (this.currentIndexCounter + 1 < this._items.Count)
        {
            this.currentIndexCounter++;
            return true;
        }

        return false;
    }


    public bool HasNext() => this.currentIndexCounter < this._items.Count - 1;


    public void Print()
    {
        if (this._items.Count == 0)
        {
            throw new InvalidOperationException("Invalid Operation!");
        }
        Console.WriteLine(this._items[this.currentIndexCounter]);
    }

}