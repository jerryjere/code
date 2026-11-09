using System;
class Program
{
    static void Main()
    {
        long a = 0, b = 1;
        for (long i = 1; i <= 50; i++)
        {
            Console.Write(a + " ");
            long c = a + b;
            a = b;
            b = c;
        }
    }
}


--- dynamic---


using System;

class Program
{
    static void Main()
    {
        long a = 0, b = 1, c;

        Console.Write("Enter the number of terms: ");
        int n = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Fibonacci Series:");

        for (long i = 1; i <= n; i++)
        {
            Console.Write(a + " ");

            c = a + b;
            a = b;
            b = c;
        }
    }
}
