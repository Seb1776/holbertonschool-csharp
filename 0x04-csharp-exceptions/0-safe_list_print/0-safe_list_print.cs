using System;
using System.Collections.Generic;

class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int c = 0;

        try
        {
            for (int i = 0; i < n; i++, c++)
                Console.WriteLine("{0}", myList[i]);
        }

        catch(Exception){}

        return c;
    }
}
