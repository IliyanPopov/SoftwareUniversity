using System;
using System.Text;

public class LinkedList<T>
{
    //This will have latest node
    private Node<T> _current;
    private readonly Node<T> _head;

    public LinkedList()
    {
        this._head = new Node<T>();
        this._current = this._head;
    }

    public int Count { get; private set; }

    public void AddAtLast(T data)
    {
        Node<T> newNode = new Node<T>();
        newNode.Value = data;
        this._current.Next = newNode;
        this._current = newNode;
        this.Count++;
    }

    public void RemoveFromStart(T value)
    {
        Node<T> curr = this._head.Next;
        while (curr.Next != null)
        {
            if (curr.Value.Equals(value))
            {
                curr.Value = default(T);
                break;
            }
            curr = curr.Next;

        }
    }

    public override string ToString()
    {
        StringBuilder sb = new StringBuilder();
        //Traverse from head

        Node<T> curr = this._head.Next;
        while (curr.Next != null)
        {
            curr = curr.Next;
            sb.Append(curr.Value.ToString() + " ");
        }

        return sb.ToString().Trim();
    }
}