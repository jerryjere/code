using System;
class Program
{
    static void Main()
    {
        int num = 13;
        int count = 0;
        while (num > 0)
        {
            count += num % 2;
            num /= 2;
        }
        Console.WriteLine("Set Bits: " + count);
    }
}

---dynamic--

using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        while (num != 0)
        {
            count += num & 1;
            num >>= 1;
        }
        Console.WriteLine("Number of set bits: " + count);
    }
}
