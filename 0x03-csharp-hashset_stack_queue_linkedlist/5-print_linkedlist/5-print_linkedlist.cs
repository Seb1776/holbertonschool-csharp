using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> retList = new LinkedList<int>();

        if (size >= 0)
        {
            for (int i = 0; i < size; i++)
            {
                retList.AddFirst(i);
                Console.WriteLine("{0}", i);
            }
        }

        return retList;
    }
}
