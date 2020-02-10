using System;
using System.Collections.Generic;
    class List
    {
        public static int Sum(List<int> myList)
        {
           int sum = 0;
           List <int> alist = myList;
           alist.Sort();
           int idx = 0;
           for (; idx < alist.Count; idx++)
            {
                if (idx == 0 || alist[idx]!= alist[idx - 1])
                    sum += alist[idx];
            }
            return (sum);
        }
    }
