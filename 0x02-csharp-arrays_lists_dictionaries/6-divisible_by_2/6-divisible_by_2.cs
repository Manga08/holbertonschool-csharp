using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        int i;
        List<bool> new_List = new List<bool> ();
        for (i = 0; i < myList.Count; i++) {
            if (myList[i] % 2 == 0) {
                new_List.Add(true);
            }
            else {
                new_List.Add(false);
            }
        } 
        return new_List;
    }
}
