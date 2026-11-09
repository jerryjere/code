using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4 };
        int[] b = { 3, 4, 5, 6 };
        HashSet<int> set = new HashSet<int>(a);
        foreach (int n in b)
        {
            if (set.Contains(n))
            {
                Console.Write(n + " ");
                set.Remove(n);
            }
        }
    }
}



---dynamic---


using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int[] a = { 1, 2, 3, 4, 5 };
        int[] b = { 3, 4, 5, 6, 7 };
        HashSet<int> set = new HashSet<int>(b);
        Console.WriteLine("Common elements:");
        foreach (int num in a)
        {
            if (set.Remove(num))
                Console.Write(num + " ");
        }
    }
}
