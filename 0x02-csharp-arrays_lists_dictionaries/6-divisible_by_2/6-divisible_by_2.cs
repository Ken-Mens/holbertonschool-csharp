using System;
using System.Collections.Generic;

class List
{
    public static List<bool> DivisibleBy2(List<int> myList)
    {
        List<bool> aList = new List<bool>();
        foreach (int x in myList)
        {
            if (x % 2 == 0)
                aList.Add(true);
            else
                aList.Add(false);
        }
        return (aList);
    }
}
