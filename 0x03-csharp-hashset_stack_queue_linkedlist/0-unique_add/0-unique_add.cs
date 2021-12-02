using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        var unique = new HashSet<int>(myList);
        int finalRet = 0;

        foreach (int n in unique)
            finalRet += n;

        return finalRet;
    }
}
