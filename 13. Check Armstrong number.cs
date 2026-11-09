using System;
class Program
{
    static void Main()
    {
        int num = 153;
        int temp = num;
        int sum = 0;
        int digits = num.ToString().Length;
        while (temp > 0)
        {
            int rem = temp % 10;
            sum += (int)Math.Pow(rem, digits);
            temp /= 10;
        }
        if (sum == num)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not Armstrong");
    }
}


---dynamic---


using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a number: ");
        int num = Convert.ToInt32(Console.ReadLine());
        int temp = num;
        int digits = num.ToString().Length;
        int sum = 0;
        while (temp > 0)
        {
            int digit = temp % 10;
            sum += (int)Math.Pow(digit, digits);
            temp /= 10;
        }
        if (sum == num)
            Console.WriteLine("Armstrong Number");
        else
            Console.WriteLine("Not an Armstrong Number");
    }
}
