using System;
class Program
{
    static void Main()
    {
        string str = "aabcccccaaa";
        string result = "";
        int count = 1;
        for (int i = 1; i <= str.Length; i++)
        {
            if (i < str.Length && str[i] == str[i - 1])
            {
                count++;
            }
            else
            {
                result += str[i - 1] + count.ToString();
                count = 1;
            }
        }
        Console.WriteLine(result);
    }
}

---dynamic---


using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        string result = "";
        int count = 1;
        for (int i = 1; i <= str.Length; i++)
        {
            if (i < str.Length && str[i] == str[i - 1])
            {
                count++;
            }
            else
            {
                result += str[i - 1].ToString() + count;
                count = 1;
            }
        }
        Console.WriteLine("Compressed string: " + result);
    }
}
