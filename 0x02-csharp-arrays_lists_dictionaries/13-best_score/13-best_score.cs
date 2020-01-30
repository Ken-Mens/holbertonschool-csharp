using System;
using System.Collections.Generic;

    class Dictionary
    {
        public static string BestScore(Dictionary<string, int> myList)
        {
          List<int> neoList = new List<int> ();
          Dictionary<int, string> neoDict = new Dictionary<int, string>();
          foreach (KeyValuePair <string, int> mvp in myList)
          {
              neoDict[mvp.Value] = mvp.Key;
              neoList.Add(mvp.Value);
          }
          if (neoList.Count == 0)
                return ("None");
                neoList.Sort();
                var deadend = neoList.Count - 1;
                return(neoDict[neoList[deadend]]);
        }
    }
