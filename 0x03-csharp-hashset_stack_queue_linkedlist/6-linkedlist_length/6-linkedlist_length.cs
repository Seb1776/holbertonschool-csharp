using System;
using System.Collections.Generic;

class LList
{
    public static int Length(LinkedList<int> myLList)
    {
        int _count = 0;

        while(myLList.Last != null)
        {
            myLList.RemoveFirst();
            _count++;
        }

        return _count;
    }
}
