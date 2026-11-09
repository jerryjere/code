using System;
class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        int target = 30;
        int low = 0, high = arr.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;
            if (arr[mid] == target)
            {
                Console.WriteLine("Iterative: " + mid);
                break;
            }
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        Console.WriteLine("Recursive: " +
            BinarySearch(arr, 0, arr.Length - 1, target));
    }
    static int BinarySearch(int[] arr, int low, int high, int target)
    {
        if (low > high)
            return -1;
        int mid = (low + high) / 2;
        if (arr[mid] == target)
            return mid;
        if (arr[mid] < target)
            return BinarySearch(arr, mid + 1, high, target);
        return BinarySearch(arr, low, mid - 1, target);
    }
}


--dynamic--

A. Iterative Binary Search

using System;
class Program
{
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        Console.Write("Enter number to search: ");
        int target = Convert.ToInt32(Console.ReadLine());
        int low = 0, high = arr.Length - 1;
        while (low <= high)
        {
            int mid = (low + high) / 2;

            if (arr[mid] == target)
            {
                Console.WriteLine("Found at index: " + mid);
                return;
            }
            else if (arr[mid] < target)
                low = mid + 1;
            else
                high = mid - 1;
        }
        Console.WriteLine("Not Found");
    }
}

B. Recursive Binary Search

using System;
class Program
{
    static int Search(int[] arr, int low, int high, int target)
    {
        if (low > high)
            return -1;
        int mid = (low + high) / 2;
        if (arr[mid] == target)
            return mid;
        if (arr[mid] < target)
            return Search(arr, mid + 1, high, target);
        return Search(arr, low, mid - 1, target);
    }
    static void Main()
    {
        int[] arr = { 10, 20, 30, 40, 50 };
        Console.Write("Enter number: ");
        int target = Convert.ToInt32(Console.ReadLine());
        int result = Search(arr, 0, arr.Length - 1, target);
        if (result == -1)
            Console.WriteLine("Not Found");
        else
            Console.WriteLine("Found at index: " + result);
    }
}
