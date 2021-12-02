using System;
using System.Collections.Generic;

class MyQueue
{
    public static Queue<string> Info(Queue<string> aQueue, string newItem, string search)
    {
        Console.WriteLine("Number of items: {0}", aQueue.Count);

        if (aQueue.Count > 0)
            Console.WriteLine("First item: {0}", aQueue.Peek());
        
        else
            Console.WriteLine("Queue is empty");
        
        Console.WriteLine("Queue contains \"{0}\": {1}", search, aQueue.Contains(search));

        if (aQueue.Contains(search))
        {
            int numToDelete = 0;

            foreach (String str in aQueue)
            {
                if (str != search)
                    numToDelete++;
                        
                if (str == search)
                {
                    numToDelete++;
                    break;
                }
            }

            for (int i = 0; i < numToDelete; i++)
                aQueue.Dequeue();
        }

        aQueue.Enqueue(newItem);

        return aQueue;
    }
}
