using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        List<int> scores = new List<int>();
        List<string> names = new List<string>();

        scores.AddRange(myList.Values);
        names.AddRange(myList.Keys);
        
        if (scores.Count > 0)
        {
            int tmpHigh = scores[0];
            int nameIdx = 0;

            for (int i = 0; i < scores.Count; i++)
            {
                if (scores[i] >  tmpHigh)
                {
                    tmpHigh = scores[i];
                    nameIdx = i;
                }
            }

            return names[nameIdx];
        }

        return "None";
    }
}
