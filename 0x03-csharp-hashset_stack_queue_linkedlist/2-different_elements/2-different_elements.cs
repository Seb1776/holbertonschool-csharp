using System;
using System.Collections.Generic;

class List
{
    public static List<int> DifferentElements(List<int> list1, List<int> list2)
    {
        HashSet<int> hash1 = new HashSet<int>(list1);
        HashSet<int> hash2 = new HashSet<int>(list2);
        hash1.SymmetricExceptWith(hash2);
        List<int> newList = new List<int>(hash1);
        newList.Sort();

        return newList;
    }
}
