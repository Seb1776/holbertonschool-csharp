using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        List<int> newList = new List<int>();

        if (size >= 0)
        {   
            if (size > 0)
            {
                for (int i = 0; i < size; i++)
                {
                    newList.Add(i);

                    if (i == size - 1)
                        Console.WriteLine("{0}", i);
                    else
                        Console.Write("{0} ", i);
                }
            }

            else
                Console.Write("\n");
        }

        else
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }

        return newList;
    }
}
