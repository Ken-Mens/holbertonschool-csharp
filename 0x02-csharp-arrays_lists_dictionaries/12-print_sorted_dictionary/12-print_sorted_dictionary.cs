using System;
using System.Collections.Generic;

    class Dictionary
    {
        public static void PrintSorted(Dictionary<string, string> myDict)
        {
          List<string> neoList = new List<string> ();
          foreach (string keys in myDict.Keys)
          neoList.Add(keys);
          neoList.Sort();
          foreach (string keys in neoList)
            Console.WriteLine("{0}: {1}", keys, myDict[keys]);
        }
    }
