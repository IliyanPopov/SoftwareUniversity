using System;
using System.Collections.Generic;

public class Startup
{
    public static void Main()
    {

        //  LinkedList<string> customLinkedList = new LinkedList<string>();
        System.Collections.Generic.LinkedList<string> customLinkedList = new System.Collections.Generic.LinkedList<string>();
        int n = int.Parse(Console.ReadLine());

        for (int i = 0; i < n; i++)
        {
            var data = Console.ReadLine().Split();

            switch (data[0])
            {
                case "Add":
                    customLinkedList.AddLast(data[1]);
                    break;
                case "Remove":
                    customLinkedList.Remove(data[1]);
                    break;
            }
        }
        Console.WriteLine(customLinkedList.Count);
        Console.WriteLine(string.Join(" ", customLinkedList));
    }
}

