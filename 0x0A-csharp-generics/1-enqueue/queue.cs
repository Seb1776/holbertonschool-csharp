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

    ///<summary>Count method</summary>
    ///<return>Returns how many nodes the queue has</return>
    public int Count()
    {
        return count;
    }

    ///<summary>Node class</summary>
    public class Node
    {
        T value;
        public Node next;

        ///<summary>Node constructor</summary>
        public Node (T value)
        {
            this.value = value;
        }
    }
}
