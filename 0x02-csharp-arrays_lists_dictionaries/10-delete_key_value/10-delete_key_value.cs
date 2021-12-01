using System;
using System.Collections.Generic;

class Dictionary
{
    public static Dictionary<string, string> DeleteKeyValue(Dictionary<string, string> myDict, string key)
    {
        Dictionary<string, string> retDict = myDict;
        retDict.Remove(key);
        return retDict;
    }
}

