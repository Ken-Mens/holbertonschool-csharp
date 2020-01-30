using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        int[,] gridbox = new int[5,5];
        gridbox [2,2] = 1;
        int x = 0;
        for (; x < 5; x++)
        {
            int y = 0;
            for (; y < 5; y++)
            {
                if (y != 0)
                    Console.Write(" ");
                 Console.Write(gridbox[x,y]);             
            }
            Console.WriteLine("");
        }
    }
}
