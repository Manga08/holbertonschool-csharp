using System;
using System.Collections.Generic;
using System.Linq;

class Dictionary
{
    public static void PrintSorted(Dictionary<string, string> myDict)
    {
        List<string> new_List = new List<string> ();
        new_List = myDict.Keys.ToList();
        new_List.Sort();

        foreach (var key in new_List) {
            Console.WriteLine("{0}: {1}", key, myDict[key]);
        }
    }
}
