using System;
class Program
{
    static void Main()
    {
        int[] arr = { 2, 2, 1, 2, 3, 2, 2 };
        int candidate = 0;
        int count = 0;
        foreach (int n in arr)
        {
            if (count == 0)
                candidate = n;
            if (n == candidate)
                count++;
            else
                count--;
        }
        count = 0;
        foreach (int n in arr)
        {
            if (n == candidate)
                count++;
        }
        if (count > arr.Length / 2)
            Console.WriteLine("Majority Element: " + candidate);
        else
            Console.WriteLine("No Majority Element");
    }
}



---dynamic---


using System;
class Program
{
    static void Main()
    {
        int[] arr = { 2, 2, 1, 2, 3, 2, 2 };
        int candidate = 0;
        int count = 0;
        foreach (int num in arr)
        {
            if (count == 0)
                candidate = num;

            if (num == candidate)
                count++;
            else
                count--;
        }
        count = 0;
        foreach (int num in arr)
        {
            if (num == candidate)
                count++;
        }
        if (count > arr.Length / 2)
            Console.WriteLine("Majority element: " + candidate);
        else
            Console.WriteLine("No majority element");
    }
}
