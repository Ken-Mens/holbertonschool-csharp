# 0x02. C# - Data Structures: Arrays, Lists, Dictionaries


## General

- How to create and use arrays
- What are Collections in C#
- How to create and use lists
- What is the difference between arrays and lists in C#
- When would you use an array vs a list
- How to create and use dictionaries
- What is the difference between dictionary and hashtables in C#
- When would you use a dictionary vs a hashtable
- How to use foreach

### 0. Print an array of integers
Write a method that creates and prints an array of integers of a given size.


### 1. Access an element in an array
Write a method that retrieves an element from an array.


### 2. Replace element
Write a method that replaces an element of an array at a given index.


### 3. Print an array of integers... in reverse!
Write a method that prints all integers of an array, in reverse order.


### 4. Print a list of integers 
Write a method that creates and prints a list of integers of a given size.


### 5. Find the max 
Write a method that finds the biggest integer of a list.


### 6. Only by 2
Write a method that finds all multiples of 2 in a list.


### 7. Delete at
Write a method that deletes the item at a specific position in a list.


### 8. Number of keys
Write a method that returns the number of keys in a dictionary.

### 9. Update dictionary 
Write a method that adds a key and value to a dictionary.

### 10. Delete from dictionary 
Write a method that deletes a key in a dictionary

### 11. Multiply by 2 
Write a method that returns a new dictionary with all values multiplied by 2.


### 12. Print sorted dictionary 
Write a method that prints a dictionary by ordered keys.
```
carrie@ubuntu:~/0x02/12-print_sorted_dictionary$ cat 12-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, string> myDict = new Dictionary<string, string>();

        myDict.Add("language", "C");
        myDict.Add("track", "low level");
        myDict.Add("school", "Holberton");
        myDict.Add("address", "972 Mission St.");
        myDict.Add("city", "San Francisco");

        Dictionary.PrintSorted(myDict);
    }
}
```
carrie@ubuntu:~/0x02/12-print_sorted_dictionary$ ls
12-main.cs                         bin
12-print_sorted_dictionary.cs      obj
12-print_sorted_dictionary.csproj
carrie@ubuntu:~/0x02/12-print_sorted_dictionary$ dotnet run
address: 972 Mission St.
city: San Francisco
language: C
school: Holberton
track: low level
```

### 13. Best score
Write a method that returns the key with the biggest integer value in a given dictionary.
```
carrie@ubuntu:~/0x02/13-best_score$ cat 13-main.cs 
using System;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        Dictionary<string, int> myDict = new Dictionary<string, int>();

        myDict.Add("John", 12);
        myDict.Add("Alex", 8);
        myDict.Add("Bob", 14);
        myDict.Add("Molly", 16);
        myDict.Add("Mary", 14);

        Console.WriteLine("Best Score: {0}", Dictionary.BestScore(myDict));
    }
}
carrie@ubuntu:~/0x02/13-best_score$ 
```

```c#
carrie@ubuntu:~/0x02/13-best_score$ ls
13-best_score.cs  13-best_score.csproj  13-main.cs  bin  obj
carrie@ubuntu:~/0x02/13-best_score$ dotnet run
Best Score: Molly
carrie@ubuntu:~/0x02/13-best_score$ 
```



### 14. Rectangular array
Write a program that creates and prints a 5 by 5 two-dimensional array and initialize index [2,2] to 1 and all other indices to 0.

```c#
carrie@ubuntu:~/0x02/14-rectangular_array$ ls
14-rectangular_array.cs  14-rectangular_array.csproj  bin  obj
carrie@ubuntu:~/0x02/14-rectangular_array$ dotnet run | cat -e
0 0 0 0 0$
0 0 0 0 0$
0 0 1 0 0$
0 0 0 0 0$
0 0 0 0 0$
```
### 15. Matrix squared 
Write a method that computes the square value of all integers of a matrix.

```c#
carrie@ubuntu:~/0x02/15-square_matrix$ ls
15-main.cs           15-square_matrix.csproj  obj
15-square_matrix.cs  bin
carrie@ubuntu:~/0x02/15-square_matrix$ dotnet run
0 1 4
9 16 25
36 49 64
```

### 16. Jaggay array 
Write a program that creates and prints a jagged array containing 3 arrays.

```c#
carrie@ubuntu:~/0x02/100-jagged_array$ dotnet run | cat -e
0 1 2 3$
0 1 2 3 4 5 6$
0 1$
```
