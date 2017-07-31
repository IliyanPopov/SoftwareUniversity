using System;
using System.Collections;
using System.Collections.Generic;

public class Lake<T> : IEnumerable<T>
{
    private IList<T> _items;

    public Lake(List<T> items)
    {
        this._items = items;
    }


    public IEnumerator<T> GetEnumerator()
    {
        for (int i = 0; i < this._items.Count; i += 2)
        {
            yield return this._items[i];
        }

        if (this._items.Count % 2 == 1)
        {
            for (int i = this._items.Count - 2; i >= 0; i -= 2)
            {
                yield return this._items[i];
            }
        }
        else
        {
            for (int i = this._items.Count - 1; i >= 0; i -= 2)
            {
                yield return this._items[i];
            }
        }
        
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }
}

