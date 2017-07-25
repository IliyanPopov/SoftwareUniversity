using System;
public interface IBox<T> where T : IComparable<T>

{
    void Add(T t);

    void Swap(int index1, int index2);

    int CompareWithEachElement(T t);
}

