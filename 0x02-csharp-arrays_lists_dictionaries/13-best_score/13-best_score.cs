using System;
using System.Collections.Generic;

class Dictionary
{
    public static string BestScore(Dictionary<string, int> myList)
    {
        string result = "";
        int bestScore = -1;
        foreach (KeyValuePair<string, int> pair in myList)
        {
            if (pair.Value > bestScore)
            {
                bestScore = pair.Value;
                result = pair.Key;
            }
        }
        if (bestScore == -1)
            return "None";
        return result;
    }
}
