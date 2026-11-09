using System;
class Program
{
    static void Main()
    {
        int[] arr = { 10, 25, 5, 40, 30 };
        int first = int.MinValue;
        int second = int.MinValue;
        foreach (int n in arr)
        {
            if (n > first)
            {
                second = first;
                first = n;
            }
            else if (n > second && n != first)
            {
                second = n;
            }
        }
        Console.WriteLine("Second Largest: " + second);
    }
}



---dyanmic---


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
        {
            arr[i] = Convert.ToInt32(Console.ReadLine());
        }
        int largest = int.MinValue;
        int second = int.MinValue;
        for (int i = 0; i < n; i++)
        {
            if (arr[i] > largest)
            {
                second = largest;
                largest = arr[i];
            }
            else if (arr[i] > second && arr[i] < largest)
            {
                second = arr[i];
            }
        }
        if (second == int.MinValue)
            Console.WriteLine("Second largest number does not exist");
        else
            Console.WriteLine("Second largest number: " + second);
    }
}
