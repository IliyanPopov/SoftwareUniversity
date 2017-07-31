using System;
using System.Collections.Generic;
using System.Linq;
public interface IListyIterator<T>
{
    bool Move();

    bool HasNext();

    void Print();
}


