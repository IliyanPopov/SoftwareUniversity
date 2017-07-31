using System;
using System.Collections;
using System.Collections.Generic;

public class CustomStack<T> : ICustomStack<T>
{
    private readonly List<T> _items;

    public CustomStack()
    {
        this._items = new List<T>();
    }

    public void Push(IEnumerable<T> items)
    {
        this._items.AddRange(items);
    }

    public T Pop()
    {
        if (this._items.Count > 0)
        {
            var lastElement = this._items[this._items.Count - 1];
            this._items.Remove(lastElement);
            return lastElement;
        }

        throw new ArgumentException("No elements");
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (int i = this._items.Count - 1; i >= 0; i--)
        {
            yield return this._items[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}