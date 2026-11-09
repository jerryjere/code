using System;
class Program
{
    static void Main()
    {
        int[] a = { 1, 3, 5 };
        int[] b = { 2, 4, 6 };
        int[] result = new int[a.Length + b.Length];
        int i = 0, j = 0, k = 0;
        while (i < a.Length && j < b.Length)
        {
            if (a[i] < b[j])
                result[k++] = a[i++];
            else
                result[k++] = b[j++];
        }
        while (i < a.Length)
            result[k++] = a[i++];
        while (j < b.Length)
            result[k++] = b[j++];
        foreach (int n in result)
            Console.Write(n + " ");
    }
}



---dynamic---


using System;
class Program
{
    static void Main()
    {
        int[] a = { 1, 3, 5 };
        int[] b = { 2, 4, 6 };
        int[] c = new int[a.Length + b.Length];
        int i = 0, j = 0, k = 0;
        while (i < a.Length && j < b.Length)
        {
            if (a[i] < b[j])
                c[k++] = a[i++];
            else
                c[k++] = b[j++];
        }
        while (i < a.Length)
            c[k++] = a[i++];
        while (j < b.Length)
            c[k++] = b[j++];
        Console.WriteLine("Merged Array:");
        foreach (int num in c)
            Console.Write(num + " ");
    }
}
