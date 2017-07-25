using System.Collections.Generic;

public static class ArrayCreator
{
    public static T[] Create<T>(int lenght, T item)
    {
        var data = new T[lenght];

        for (int i = 0; i < lenght; i++)
        {
            data[i] = item;
        }

        return data;
    }
}

