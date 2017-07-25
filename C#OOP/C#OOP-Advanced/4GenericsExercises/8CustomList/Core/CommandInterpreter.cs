using System;

public class CommandInterpreter
{
    private CustomList<string> _items;

    public CommandInterpreter()
    {
        this._items = new CustomList<string>();
    }

    public void StartReadingCommands()
    {
        var data = Console.ReadLine().Split(' ');

        while (data[0] != "END")
        {
            switch (data[0])
            {
                case "Add":
                    this._items.Add(data[1]);
                    break;
                case "Remove":
                    this._items.Remove(int.Parse(data[1]));
                    break;
                case "Contains":
                    Console.WriteLine(this._items.Contains(data[1]));
                    break;
                case "Swap":
                    this._items.Swap(int.Parse(data[1]), int.Parse(data[2]));
                    break;
                case "Greater":
                    Console.WriteLine(this._items.CountGreaterThan(data[1]));
                    break;
                case "Max":
                    Console.WriteLine(this._items.Max());
                    break;
                case "Min":
                    Console.WriteLine(this._items.Min());
                    break;
                case "Sort":
                    this._items = Sorter.Sort(this._items);
                    break;
                case "Print":
                    foreach (var item in this._items)
                    {
                        Console.WriteLine(item);
                    }
                    break;              
            }

            data = Console.ReadLine().Split();
        }

    }
}

