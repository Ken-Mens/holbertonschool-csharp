using System;


/// <summary>Class that stores a queue of objects of same type.</summary>
class Queue<T>
{
    /// <summary> A public node class in the queue containing a single element of type  <typeparamref name="T"/>.</summary>
    public class Node
{
    /// <summary>The element stored in node.</summary>
    public T value;
    /// <summary>Pointer to the next node in our queue.</summary>
    public Node next = null;
       /// <summary>Creates a new node with given element as value for a new Node.</summary>
        /// <param name="value">Node's initial value.</param>
    public Node(T value) {
        this.value = value;
    }
}
/// <summary>Pointer to the head of the queue.</summary>
public Node head;
/// <summary>Pointer to the tail end of the queue.</summary>

public Node tail;
/// <summary>The number of nodes in queue.</summary>
public int count = 0;

    /// <summary>Returns type stored.</summary>
    /// <returns>Type of the T parameter.</returns>
    public Type CheckType() {
        return typeof(T);
    }

    /// <summary>Adds new element to the tail of the queue.</summary>
    /// <param name="value">New value to be implemented.</param>
       public void Enqueue(T value) {
        Node node;

        node = new Node(value);
        if (this.head == null)
            this.head = node;
        if (this.tail != null)
            this.tail.next = node;
        this.tail = node;
        this.count++;
    }
 /// <summary>Returns the number of nodes in the queue.</summary>
    /// <returns>Number of items in queue.</returns>
    public int Count() {
        return this.count;
    }
}
