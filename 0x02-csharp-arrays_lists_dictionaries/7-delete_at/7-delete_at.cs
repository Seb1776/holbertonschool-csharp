using System;
using System.Collections.Generic;

class List
{
    public static List<int> DeleteAt(List<int> myList, int index)
    {
        if (index > myList.Count - 1 || index < 0)
        {
            Console.WriteLine("Index is out of range");
            return myList;
        }

        List<int> newList = myList;
        newList.Remove(myList[index]);
        return newList;
    }
}
