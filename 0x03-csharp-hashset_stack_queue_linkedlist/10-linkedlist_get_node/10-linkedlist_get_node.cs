﻿using System;
using System.Collections.Generic;

    class LList
    {
        public static int GetNode(LinkedList<int> myLList, int n)
        {
            int i = 0;
            int counter = myLList.Count;
        foreach (int num in myLList)
        {
            if (i == n)
                return (num);
            i++;
        }
        return (0);
       }
    }


   
