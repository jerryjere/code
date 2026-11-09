using System;
class Program
{
    static void Main()
    {
        string str = "I love C Sharp";
        string[] words = str.Split(' ');
        for (int i = words.Length - 1; i >= 0; i--)
        {
            Console.Write(words[i] + " ");
        }
    }
}

---dynamic--


using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter a sentence: ");
        string str = Console.ReadLine();
        string[] words = str.Split(' ');
        Console.WriteLine("Reversed sentence:");
        for (int i = words.Length - 1; i >= 0; i--)
        {
            Console.Write(words[i] + " ");
        }
    }
}
