using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> AddKeyValue(Dictionary<string, string> myDict, string key, string value)
    {
        Dictionary<string, string> retDict = myDict;

        try
        {
            retDict.Add(key, value);
        }

        catch (ArgumentException)
        {
            retDict[key] = value;
        }

        return retDict;
    }
}
