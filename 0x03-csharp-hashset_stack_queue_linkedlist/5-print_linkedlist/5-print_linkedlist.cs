using System;
using System.Collections.Generic;

class LList
{
    public static LinkedList<int> CreatePrint(int size)
    {
        LinkedList<int> newlink = new LinkedList<int>();
        for (int idx = 0; idx < size; idx++)
        {
            newlink.AddLast(idx);
            Console.WriteLine(idx);
        }
        return (newlink);
    }
}
