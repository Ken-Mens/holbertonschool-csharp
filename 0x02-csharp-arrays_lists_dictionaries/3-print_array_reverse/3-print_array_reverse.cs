using System;
class Array
{
    public static void Reverse(int[] array)
    {
        if (array != null)
         {
             var deadend = array.Length - 1;
             int idx = deadend;
             for (; idx >= 0; idx --)
            {
                if (idx != deadend)
                Console.Write(" ");
                Console.Write(array[idx]);
            }
         }
       Console.WriteLine("");
    }
}