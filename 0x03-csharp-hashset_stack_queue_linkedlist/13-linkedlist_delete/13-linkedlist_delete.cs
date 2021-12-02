using System;
using System.Collections.Generic;

class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        List<int> tmp = new List<int>(myLList);
        int removeVal = 0;

        for (int i = 0; i < tmp.Count; i++)
        {
            if (i == index)
            {
                removeVal = tmp[i];
                break;
            }
        }

        myLList.Remove(removeVal);
    }
}
