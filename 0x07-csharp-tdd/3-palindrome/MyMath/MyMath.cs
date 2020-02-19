using System;

namespace Text
{
    class Str
    {
        public static bool IsPalindrome(string s)
        {
            int length = s.Length;
            for (int idx = 0; idx < length / 2; idx++)
            {
                if (s[idx] != s[length - idx - 1])
                return false;
            }
            return true;
        }
    }
}
