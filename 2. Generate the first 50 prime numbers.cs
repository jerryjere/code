using System;
class Program
{
    static void Main()
    {
        int count = 0;
        int num = 2;
        while (count < 50)
        {
            bool prime = true;
            for (int i = 2; i <= Math.Sqrt(num); i++)
            {
                if (num % i == 0)
                {
                    prime = false;
                    break;
                }
            }
            if (prime)
            {
                Console.Write(num + " ");
                count++;
            }
            num++;
        }
    }
}



----dynamic-----

using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter how many prime numbers: ");
        int n = Convert.ToInt32(Console.ReadLine());
        int count = 0;
        int num = 2;
        Console.WriteLine("Prime Numbers:");
        while (count < n)
        {
            bool isPrime = true;

            for (int i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    isPrime = false;
                    break;
                }
            }

            if (isPrime)
            {
                Console.Write(num + " ");
                count++;
            }
            num++;
        }
    }
}
