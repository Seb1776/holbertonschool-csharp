using System;
using System.Collections.Generic;

class LList
{
    public static int Pop(LinkedList<int> myLList)
    {
        int firstIdx = 0;

        if (myLList.Count > 0)
        {
            firstIdx = myLList.First.Value;
            myLList.RemoveFirst();
        }

        return firstIdx;
    }
}
