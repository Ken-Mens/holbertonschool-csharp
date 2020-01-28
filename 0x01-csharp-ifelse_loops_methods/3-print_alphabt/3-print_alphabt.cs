using System;

namespace _3_print_alphabt
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char ltr = 'a'; ltr <='z'; ltr++)
              {
                if (ltr != 'e' && ltr != 'q')
                    Console.Write("{0}", ltr);
              }
        }
    }
}