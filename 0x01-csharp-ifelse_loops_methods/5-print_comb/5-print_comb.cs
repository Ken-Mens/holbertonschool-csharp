using System;

namespace _5_print_comb
{
    class Program
    {
        static void Main(string[] args)
        {
            int x = 0;
            for (; x < 100; x++)
            {
                if (x != 99)
                    Console.Write("{0:D2}, ", x);
                else
                    Console.Write("{0:D2}\n", x);
            }
        }
    }
}
