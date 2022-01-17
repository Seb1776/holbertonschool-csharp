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

        /*List<int> tmp = new List<int>(myLList);
        int insertAfterVal = 0;

        if (myLList.Count > 0)
        {
            if (myLList.Last.Value < n)
            {
                myLList.AddAfter(myLList.Last, n);
                return myLList.Find(n);
            }

            else if (n > 0)
            {
                for (int i = 0; i < tmp.Count; i++)
                {
                    if (tmp[i] > n)
                    {   
                        if (i != 0)
                            insertAfterVal = tmp[i - 1];
                        else
                            insertAfterVal = tmp[0];
                        
                        break;
                    }
                }

                myLList.AddAfter(myLList.Find(insertAfterVal), n);
                return myLList.Find(n);
            }

            else
            {
                myLList.AddBefore(myLList.First, n);
                return myLList.Find(n);
            }
        }

        else
        {
            myLList.AddFirst(n);
            return myLList.Find(n);
        }*/
    }
}
