using System;

class Line
{
    public static void PrintDiagonal(int length)
    {
        int x = 0;
        for (; x < length; x++)
        {
            int y = 0;
            for (; y < x; y++)
                Console.Write(" ");
            Console.WriteLine("\\");
        }
        Console.WriteLine("");
    }
}