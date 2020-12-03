using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
        int i;
        List<int> new_List = new List<int> ();
        if (size < 0) {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        if (size == 0) {
            Console.WriteLine();
        }
        for (i = 0; i < size; i++) {
            new_List.Add(i);
            if (i < size - 1) {
                Console.Write(new_List[i] + " ");
            }
            else {
                Console.WriteLine(new_List[i]);
            }
        }
        return new_List;
    }
}
