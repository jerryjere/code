using System;
class Program
{
    static void Main()
    {
        int[] arr = { -2, 1, -3, 4, -1, 2, 1, -5, 4 };
        int maxSum = arr[0];
        int currentSum = arr[0];
        for (int i = 1; i < arr.Length; i++)
        {
            currentSum = Math.Max(arr[i], currentSum + arr[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }
        Console.WriteLine("Maximum Sum: " + maxSum);
    }
}


--dynamic--


using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());
        int maxSum = arr[0];
        int currentSum = arr[0];
        for (int i = 1; i < n; i++)
        {
            currentSum = Math.Max(arr[i], currentSum + arr[i]);
            maxSum = Math.Max(maxSum, currentSum);
        }
        Console.WriteLine("Maximum subarray sum: " + maxSum);
    }
}
