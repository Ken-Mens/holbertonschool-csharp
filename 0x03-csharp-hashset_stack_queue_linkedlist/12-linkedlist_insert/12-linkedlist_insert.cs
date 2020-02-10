using System;
using System.Collections.Generic;
class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNod = new LinkedListNode<int>(n);
        LinkedListNode<int> newLL = myLList.First;
        if (newLL == null)
        {
            myLList.AddFirst(newNod);
            return (newNod);
        }
        int ok = newLL.Value;
        if (ok > n)
        {
            myLList.AddBefore(newLL, newNod);
            return (newNod);
        }
        while (newLL.Next != null)
        {  
            if (newLL.Next.Value >= n)
                break;
            newLL = newLL.Next;
        }
        myLList.AddAfter(newLL, newNod);
        return (newNod);
    }
}
