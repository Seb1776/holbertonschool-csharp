using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, int> MultiplyBy2(Dictionary<string, int> myDict)
    {
        Dictionary<string, int> retDict = new Dictionary<string, int>();

        foreach (KeyValuePair<string, int> entry in myDict)
            retDict.Add(entry.Key, entry.Value * 2);
        
        return retDict;
    }
}
