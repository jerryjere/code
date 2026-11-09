using System;
class Program
{
    static void Main()
    {
        string s1 = "waterbottle";
        string s2 = "erbottlewat";
        if (s1.Length == s2.Length &&
            (s1 + s1).Contains(s2))
        {
            Console.WriteLine("Rotation");
        }
        else
        {
            Console.WriteLine("Not Rotation");
        }
    }
}

---dynamic---


using System;
class Program
{
    static void Main()
    {
        Console.Write("Enter first string: ");
        string a = Console.ReadLine();
        Console.Write("Enter second string: ");
        string b = Console.ReadLine();
        if (a.Length == b.Length && (a + a).Contains(b))
            Console.WriteLine("Rotation");
        else
            Console.WriteLine("Not Rotation");
    }
}
