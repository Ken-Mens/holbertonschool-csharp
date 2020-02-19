using System;
using System.Linq;
using System.Collections.Generic;

namespace Text
{
    ///<summary>operations on text string</summary>
    public class Str
    {
        ///<summary>Method to determine if palindrome or not.</summary>
        public static bool IsPalindrome(string s)
        {
            List<char> finder = new List<char>();
            foreach (char letter in s)
            {
                if (!Char.IsPunctuation(letter) && !Char.IsWhiteSpace(letter))
                {
                    finder.Add(Char.ToLower(letter));
                }
            }
            var ok = finder.Count;
            if (ok == 0)
                return (true);
            List<char> reversal = new List<char>(finder);
            reversal.Reverse();
            return (finder.SequenceEqual(reversal));
        }
    }
}