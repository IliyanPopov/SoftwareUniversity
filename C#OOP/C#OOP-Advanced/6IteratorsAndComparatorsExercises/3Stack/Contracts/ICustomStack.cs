using System;
using System.Collections.Generic;

public interface ICustomStack<T> : IEnumerable<T>
{
    void Push(IEnumerable<T> items);
    T Pop();
}

