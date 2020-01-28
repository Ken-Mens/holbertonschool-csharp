using System;

namespace _2_print_alphabet_lower
{
    class Program
    {
        static void Main(string[] args)
        {
            for (char ltr = 'a'; ltr <='z'; ltr++)
                Console.Write("{0}", ltr);
        }
    }
}