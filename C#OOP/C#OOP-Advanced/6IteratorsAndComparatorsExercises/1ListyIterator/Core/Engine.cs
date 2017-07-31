using System;
using System.Collections.Generic;
using System.Linq;

public class Engine : IEngine
{
    private IListyIterator<string> _listyIterator;

    public Engine()
    {
    }

    public void Run()
    {
        var data = Console.ReadLine().Split();

        while (data[0] != "END")
        {
            switch (data[0])
            {
                case "Create":
                    try
                    {
                        List<string> items = data.Skip(1).ToList();
                        this._listyIterator = new ListyIterator<string>(items);
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
                case "Move":
                    try
                    {
                        Console.WriteLine(this._listyIterator.Move());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    break;
                case "HasNext":
                    try
                    {
                        Console.WriteLine(this._listyIterator.HasNext());
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }

                    break;
                case "Print":
                    try
                    {
                      this._listyIterator.Print();
                    }
                    catch (Exception e)
                    {
                        Console.WriteLine(e.Message);
                    }
                    break;
            }
            data = Console.ReadLine().Split();
        }
    }
}

