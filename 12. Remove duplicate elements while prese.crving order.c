using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 2, 3, 4, 3, 5 };
        List<int> result = new List<int>();
        foreach (int n in arr)
        {
            if (!result.Contains(n))
                result.Add(n);
        }
        foreach (int n in result)
        {
            Console.Write(n + " ");
        }
    }
}


---dynamic----



using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        HashSet<int> set = new HashSet<int>();
        Console.WriteLine("Enter elements:");
        for (int i = 0; i < n; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Array without duplicates:");
        foreach (int num in arr)
        {
            if (set.Add(num))
                Console.Write(num + " ");
        }
    }
}
