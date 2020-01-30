using System;
using System.Collections.Generic;

    class List
    {
        public static void DeleteAt(List<int> myList, int index)
        {
            var deadend =  myList.Count - 1;
            if (index < 0 || index > deadend)
                Console.WriteLine("Index is out of range");
                else
                myList.Remove(myList[index]);
        }
    }

