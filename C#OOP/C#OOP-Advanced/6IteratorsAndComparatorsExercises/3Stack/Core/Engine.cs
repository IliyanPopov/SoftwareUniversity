using System;
using System.Collections.Generic;
using System.Linq;

public class Engine : IEngine
{
    private readonly ICustomStack<string> _customStack;

    public Engine()
    {
        this._customStack = new CustomStack<string>();
    }

    public void Run()
    {
        var data = Console.ReadLine().Split(new[] {' ', ','}, StringSplitOptions.RemoveEmptyEntries);

        while (data[0] != "END")
        {
            switch (data[0])
            {
                case "Push":
                    IEnumerable<string> items = data.Skip(1);
                    this._customStack.Push(items);
                    break;
                case "Pop":
                    try
                    {
                        this._customStack.Pop();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    break;
            }

            data = Console.ReadLine().Split();
        }

        foreach (var item in this._customStack)
        {
            Console.WriteLine(item);
        }

        foreach (var item in this._customStack)
        {
            Console.WriteLine(item);
        }
    }
}