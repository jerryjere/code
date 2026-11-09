using System;

class Program
{
    static void Main()
    {
        int[] arr = { 2, 7, 11, 15 };
        int target = 9;

        for (int i = 0; i < arr.Length; i++)
        {
            for (int j = i + 1; j < arr.Length; j++)
            {
                if (arr[i] + arr[j] == target)
                {
                    Console.WriteLine(i + " " + j);
                    return;
                }
            }
        }

        Console.WriteLine("No Pair Found");
    }
}

---dynamic---



using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter array size: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] arr = new int[n];
        Console.WriteLine("Enter array elements:");
        for (int i = 0; i < n; i++)
            arr[i] = Convert.ToInt32(Console.ReadLine());
        Console.Write("Enter target: ");
        int target = Convert.ToInt32(Console.ReadLine());
        for (int i = 0; i < n; i++)
        {
            for (int j = i + 1; j < n; j++)
            {
                if (arr[i] + arr[j] == target)
                {
                    Console.WriteLine("Indices: " + i + ", " + j);
                    return;
                }
            }
        }
        Console.WriteLine("No pair found");
    }
}
