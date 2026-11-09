using System;
class Program
{
    static void Main()
    {
        int[] arr = { 1, 2, 4, 5 };
        int n = 5;
        int total = n * (n + 1) / 2;
        int sum = 0;
        foreach (int num in arr)
        {
            sum += num;
        }
        Console.WriteLine("Missing Number: " + (total - sum));
    }
}


---dynamic---


using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter N: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n - 1];
        int sum = 0;
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n - 1; i++)
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
            sum += arr[i];
        }
        int total = n * (n + 1) / 2;
        Console.WriteLine("Missing number: " + (total - sum));
    }
}
