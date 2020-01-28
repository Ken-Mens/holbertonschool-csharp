using System;

namespace _6_print_comb2
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            for (; x < 10; x++)
            {
                int y = x + 1; 
                for (; y < 10; y++)
                {
                    if (x == 8 && y == 9)
                        Console.WriteLine("{0}{1}", x, y);
                    else
                        Console.Write("{0}{1}, ", x, y);
                }
            }
        }
    }
}