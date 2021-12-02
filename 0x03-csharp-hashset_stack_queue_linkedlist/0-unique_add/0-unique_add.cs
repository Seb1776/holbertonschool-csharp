using System;
using System.Collections.Generic;

class List
{
    public static int Sum(List<int> myList)
    {
        int finalRet = 0;
        List<int> tmp = new List<int>();

        for (int i = 0; i < myList.Count; i++)
        {
            if (!tmp.Contains(myList[i]))
            {
                tmp.Add(myList[i]);
                finalRet += myList[i];
            }
        }

        return finalRet;
    }
}
