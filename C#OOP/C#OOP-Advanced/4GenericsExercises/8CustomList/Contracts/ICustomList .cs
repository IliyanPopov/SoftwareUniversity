using System;

public interface ICustomList<T> where T : IComparable<T>

{
    void Add(T t);

    T Remove(int index);

    bool Contains(T element);

    void Swap(int index1, int index2);

    int CountGreaterThan(T t);

    T Max();

    T Min();
}

