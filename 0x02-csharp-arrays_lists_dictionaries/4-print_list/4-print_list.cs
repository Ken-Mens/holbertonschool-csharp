using System;
using System.Collections.Generic;

class List
{
    public static List<int> CreatePrint(int size)
    {
      if (size < 0)
      {
       Console.WriteLine("Size cannot be negative");
       return null;
      }
    List <int> ilist = new List <int> ();
    int x = 0;
    for (; x < size; x++)
    {
        ilist.Add(x);
        if (x != 0)

        Console.Write(" ");
        Console.Write(x);
    }
    Console.WriteLine(" ");
    return ilist;
    }
}