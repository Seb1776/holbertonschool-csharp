using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        List<int> tmpL = new List<int>(myLList);
        tmpL.Add(n);
        tmpL.Sort();
        myLList.Clear();

        for (int i = 0; i < tmpL.Count; i++)
            myLList.AddLast(tmpL[i]);

        return myLList.Find(n);
    }
}
