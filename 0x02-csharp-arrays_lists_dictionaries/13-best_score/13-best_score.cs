using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        List<string> highs = myList.Keys.ToList();

        if (highs.Count > 0)
        {
            highs.Sort();
            return highs[highs.Count - 1];
        }

        return "None";
    }
}
