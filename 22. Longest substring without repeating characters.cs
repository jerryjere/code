using System;
class Program
{
    static void Main()
    {
        string str = "abcabcbb";
        int maxLength = 0;
        for (int i = 0; i < str.Length; i++)
        {
            string temp = "";
            for (int j = i; j < str.Length; j++)
            {
                if (temp.Contains(str[j]))
                    break;
                temp += str[j];
                maxLength = Math.Max(maxLength, temp.Length);
            }
        }
        Console.WriteLine("Longest Length: " + maxLength);
    }
}

--dynamic--


using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        int max = 0;
        for (int i = 0; i < str.Length; i++)
        {
            string temp = "";
            for (int j = i; j < str.Length; j++)
            {
                if (temp.Contains(str[j].ToString()))
                    break;
                temp += str[j];
                max = Math.Max(max, temp.Length);
            }
        }
        Console.WriteLine("Longest length: " + max);
    }
}
