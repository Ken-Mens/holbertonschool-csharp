using System;
using System.Collections.Generic;
class LList
{
    public static LinkedListNode<int> Insert(LinkedList<int> myLList, int n)
    {
        LinkedListNode<int> newNode = new LinkedListNode<int>(n);
        LinkedListNode<int> Nll = myLList.First;
        while (Nll.Next != null)
        {
            if (Nll.Next.Value >= n)
                break;
            Nll = Nll.Next;
        }
        myLList.AddAfter(Nll, newNode);
        return (newNode);
    }
}
