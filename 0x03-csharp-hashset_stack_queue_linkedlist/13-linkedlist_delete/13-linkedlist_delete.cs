using System;
using System.Collections.Generic;
class LList
{
    public static void Delete(LinkedList<int> myLList, int index)
    {
        LinkedListNode<int> newL = myLList.First;
        int i = 0;
        for (; i < index && newL.Next != null; i++)
            newL = newL.Next;
        if (i == index)
            myLList.Remove(newL);
    }
}