using System;
class Array
{
    public static int elementAt(int[] array, int index)
    {
        var deadend = array.Length - 1;
        if (index < 0 || index > deadend)
        {
            Console.WriteLine("Index out of range");
            return(-1);
        }
        return array[index];
    }
}
