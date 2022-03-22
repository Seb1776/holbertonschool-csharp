using System;

///<summary>Generic Queue class</summary>
class Queue<T>
{
    public Node head, tail;
    public int count;

    ///<summary>Returns the passed generic type</summary>
        ///<return>The string of the generic type</return>
    public Type CheckType()
    {
        return typeof(T);
    }

    ///<summary>Adds a new node to the queue</summary>
    public void Enqueue(T val)
    {
        Node _n = new Node(val);

        if (head == null)
        {
            head = _n;
            tail = _n;
        }

        else
        {
            tail.next = _n;
            tail = _n;
        }

        count++;
    }

    ///<summary>Removes and shows the first node in the queue</summary>
        ///<return>Returns the first value in the queue</return>
    public T Dequeue()
    {
        if (count > 0)
        {
            Node _hd = head;
            head = head.next;
            count--;
            return _hd.value;
        }

        Console.WriteLine("Queue is empty");
        return default(T);
    }

    ///<summary>Count method</summary>
        ///<return>Returns how many nodes the queue has</return>
    public int Count()
    {
        return count;
    }

    ///<summary>Node class</summary>
    public class Node
    {
        public T value;
        public Node next;

        ///<summary>Node constructor</summary>
        public Node (T value)
        {
            this.value = value;
        }
    }
}
