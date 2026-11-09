using System;
class Program
{
    static void Permute(string str, string result)
    {
        if (str.Length == 0)
        {
            Console.WriteLine(result);
            return;
        }
        for (int i = 0; i < str.Length; i++)
        {
            string remaining = str.Remove(i, 1);

            Permute(remaining, result + str[i]);
        }
    }
    static void Main()
    {
        string str = "ABC";
        Permute(str, "");
    }
}

----dynamic---



using System;
class Program
{
    static void Permute(string str, int start)
    {
        if (start == str.Length - 1)
        {
            Console.WriteLine(str);
            return;
        }
        for (int i = start; i < str.Length; i++)
        {
            char[] arr = str.ToCharArray();
            char temp = arr[start];
            arr[start] = arr[i];
            arr[i] = temp;
            Permute(new string(arr), start + 1);
        }
    }
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        Permute(str, 0);
    }
}
