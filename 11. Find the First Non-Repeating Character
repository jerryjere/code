using System;
class Program
{
    static void Main()
    {
        string str = "swiss";
        for (int i = 0; i < str.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < str.Length; j++)
            {
                if (str[i] == str[j])
                    count++;
            }
            if (count == 1)
            {
                Console.WriteLine("First Non-Repeating: " + str[i]);
                return;
            }
        }
        Console.WriteLine("No Unique Character");
    }
}


---dynamic----


using System;

class Program
{
    static void Main()
    {
        Console.Write("Enter a string: ");
        string str = Console.ReadLine();
        for (int i = 0; i < str.Length; i++)
        {
            int count = 0;
            for (int j = 0; j < str.Length; j++)
            {
                if (str[i] == str[j])
                    count++;
            }
            if (count == 1)
            {
                Console.WriteLine("First non-repeating character: " + str[i]);
                return;
            }
        }
        Console.WriteLine("No non-repeating character");
    }
}
