using System;
using System.Collections.Generic;

class LList
{
    public static int GetNode(LinkedList<int> myLList, int n)
    {
        List<int> tmp = new List<int>(myLList);
        int retIdx = 0;

        for (int i = 0; i < tmp.Count; i++)
            if (i == n)
                retIdx = tmp[i];

        return retIdx;
    }
}
