using System;
using System.Collections.Generic;

class LList
{
    public static int Sum(LinkedList<int> myLList)
    {
        List<int> tmp = new List<int>(myLList);
        int retSum = 0;

        for (int i = 0; i < tmp.Count; i++)
            retSum += tmp[i];

        return retSum;
    }
}
