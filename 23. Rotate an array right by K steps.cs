using System;
class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        int k = 2;
        k = k % arr.Length;
        int[] result = new int[arr.Length];
        for (int i = 0; i < arr.Length; i++)
        {
            result[(i + k) % arr.Length] = arr[i];
        }
        foreach (int n in result)
            Console.Write(n + " ");
    }
}

--dynamic--


using System;
class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 3, 4, 5 };
        Console.Write("Enter K: ");
        int k = Convert.ToInt32(Console.ReadLine());
        int n = arr.Length;
        k = k % n;
        int[] result = new int[n];
        for (int i = 0; i < n; i++)
        {
            result[(i + k) % n] = arr[i];
        }
        Console.WriteLine("Rotated Array:");
        foreach (int num in result)
            Console.Write(num + " ");
    }
}
