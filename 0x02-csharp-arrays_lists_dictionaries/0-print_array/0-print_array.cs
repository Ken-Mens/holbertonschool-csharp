using System;

class Array
{
    public static int[] CreatePrint(int size)
    {
        if (size < 0)
        {
            Console.WriteLine("Size cannot be negative");
            return null;
        }
        int[] arr = new int[size];
        for (int idx = 0; idx < size; idx++)
        {
            arr[idx] = idx;
            if (idx != 0)
                Console.Write(" ");
            Console.Write(idx);
        }
        Console.WriteLine("");
        return arr;
    }
}
