using System;
using System.Collections.Generic;

class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        List<int> tmp = new List<int>(myLList);
        int insertAfterVal = 0;

        for (int i = 0; i < tmp.Count; i++)
        {
            if (tmp[i + 1] > n)
            {
                insertAfterVal = tmp[i];
                break;
            }
        }
        
        myLList.AddAfter(myLList.Find(insertAfterVal), n);
        return myLList.Find(insertAfterVal).Next;
    }
}
