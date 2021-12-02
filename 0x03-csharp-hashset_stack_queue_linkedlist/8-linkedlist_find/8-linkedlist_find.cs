using System;
using System.Collections.Generic;

class LList
{
    public static int FindNode(LinkedList<int> myLList, int value)
    {
        List<int> tmp = new List<int>(myLList);

        if (tmp.Contains(value))
            for (int i = 0; i < tmp.Count; i++)
                if (tmp[i] == value)
                    return i;

        return -1;
    }
}
