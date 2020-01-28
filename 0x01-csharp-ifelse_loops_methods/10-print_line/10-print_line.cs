using System;

class Line
{
    public static void PrintLine(int length)
    {
        int z = 0;
        for (; z < length; z++)
            Console.Write("_");
        Console.WriteLine("");
    }
}