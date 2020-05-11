using System;


/// <summary>Class that stores a queue of objects of same type.</summary>
class Queue<T>
{
    /// <summary>Returns type stored.</summary>
    /// <returns>Type of the T parameter.</returns>
    public Type CheckType() {
        return typeof(T);
    }
}
