using System;
using System.Collections.Generic;
using System.Text;

public class Box<T> : IBox<T> where T : IComparable<T>
{
    private readonly List<T> _items;
    private int greaterThanCounter = 0;

    public Box()
    {
        this._items = new List<T>();
    }

    public void Add(T t)
    {
        this._items.Add(t);
    }

    public void Swap(int index1, int index2)
    {
        T tmp = this._items[index1];
        this._items[index1] = this._items[index2];
        this._items[index2] = tmp;
    }


    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();

        foreach (var item in this._items)
        {
            sb.AppendLine($"{item.GetType()}: {item}");
        }

        return sb.ToString().Trim();
    }

    public int CompareWithEachElement(T t)
    {
        foreach (var item in this._items)
        {
            if (item.CompareTo(t) > 0)
            {
                this.greaterThanCounter++;
            }      
        }
        return this.greaterThanCounter;
    }
}