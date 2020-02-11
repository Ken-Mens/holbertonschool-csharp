using System;
using System.Collections.Generic;
class List
{
    public static int SafePrint(List<int> myList, int n)
    {
        int idx = 0;
        try
        {
            for (; idx < n; idx++)
                Console.WriteLine(myList[idx]);
        }
        catch (Exception)
        {
            return (idx);
        }
        return (idx);        
    }
}