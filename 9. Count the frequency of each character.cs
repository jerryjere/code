using System;
class Program
{
    static void Main()
    {
        string str = "hello";
        for (int i = 0; i < str.Length; i++)
        {
            int count = 0;
            bool alreadyCounted = false;
            for (int j = 0; j < i; j++)
            {
                if (str[i] == str[j])
                    alreadyCounted = true;
            }
            if (alreadyCounted)
                continue;
            for (int j = 0; j < str.Length; j++)
            {
                if (str[i] == str[j])
                    count++;
            }
            Console.WriteLine(str[i] + " = " + count);
        }
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
        bool[] visited = new bool[str.Length];
        for (int i = 0; i < str.Length; i++)
        {
            if (visited[i])
                continue;
            int count = 1;
            for (int j = i + 1; j < str.Length; j++)
            {
                if (str[i] == str[j])
                {
                    count++;
                    visited[j] = true;
                }
            }
            Console.WriteLine(str[i] + " = " + count);
        }
    }
}
