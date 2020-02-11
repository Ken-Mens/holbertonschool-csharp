using System;
using System.Collections.Generic;
class List
{
    public static List<int> Divide(List<int> list1, List<int> list2, int listLength)
    {
        List<int> newList = new List<int>();
        int num = 0;
        int i = 0;
            for (; i < listLength; i++)
            {
                num = 0;
                try
                {
                    num = list1[i] / list2[i];
                    newList.Add(num);
                }
                catch (DivideByZeroException)
                {
                    Console.WriteLine("Cannot divide by zero");
                    newList.Add(num);
                }
                catch (ArgumentOutOfRangeException)
                {
                    Console.WriteLine("Out of range");
                }
            }
        return (newList);
    }
}