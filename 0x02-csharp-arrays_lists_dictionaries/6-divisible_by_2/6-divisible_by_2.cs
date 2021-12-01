using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> retBool = new List<bool>();

        if (myList.Count > 0)
        {
            List<int> divisors = new List<int> { 0, 2, 4, 6, 8 };

            for (int i = 0; i < myList.Count; i++)
            {
                if (divisors.Contains(Math.Abs(myList[i]) % 10))
                    retBool.Add(true);

                else
                    retBool.Add(false);
            }
        }

        return retBool;
    }
}
