using System;
using System.Collections.Generic;
using System.Linq;

public class Startup
{
    public static void Main()
    {
        IAddCollection<string> addCollection = new AddCollection<string>();
        IAddRemoveCollection<string> addRemoveCollection = new AddRemoveCollection<string>();
        IMyList<string> myList = new MyList<string>();
        List<int> indexesAddCollection = new List<int>();
        List<int> indexesAddRemoveCollection = new List<int>();
        List<int> indexesMyListCollection = new List<int>();
        List<string> removedItemsAddRemoveCollection = new List<string>();
        List<string> removedItemsMyCollection = new List<string>();

        var data = Console.ReadLine().Split();

        foreach (var item in data)
        {
            indexesAddCollection.Add(addCollection.Add(item));
            indexesAddRemoveCollection.Add(addRemoveCollection.Add(item));
            indexesMyListCollection.Add(myList.Add(item));
        }

        int removeCount = int.Parse(Console.ReadLine());

        for (int i = 0; i < removeCount; i++)
        {
            removedItemsAddRemoveCollection.Add(addRemoveCollection.Remove());
            removedItemsMyCollection.Add(myList.Remove());
        }


        Console.WriteLine(string.Join(" ", indexesAddCollection));
        Console.WriteLine(string.Join(" ", indexesAddRemoveCollection));
        Console.WriteLine(string.Join(" ", indexesMyListCollection));
        Console.WriteLine(string.Join(" ", removedItemsAddRemoveCollection));
        Console.WriteLine(string.Join(" ", removedItemsMyCollection));
    }
}