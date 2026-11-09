using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        string str = "{[()]}";
        Stack<char> stack = new Stack<char>();
        bool valid = true;
        foreach (char c in str)
        {
            if (c == '(' || c == '{' || c == '[')
                stack.Push(c);
            else if (c == ')' || c == '}' || c == ']')
            {
                if (stack.Count == 0)
                {
                    valid = false;
                    break;
                }
                char top = stack.Pop();
                if ((c == ')' && top != '(') ||
                    (c == '}' && top != '{') ||
                    (c == ']' && top != '['))
                {
                    valid = false;
                    break;
                }
            }
        }
        if (stack.Count != 0)
            valid = false;
        Console.WriteLine(valid ? "Balanced" : "Not Balanced");
    }
}



---dynamic---


using System;
using System.Collections.Generic;
class Program
{
    static void Main()
    {
        Console.Write("Enter brackets: ");
        string str = Console.ReadLine();
        Stack<char> stack = new Stack<char>();
        bool balanced = true;
        foreach (char ch in str)
        {
            if (ch == '(' || ch == '{' || ch == '[')
            {
                stack.Push(ch);
            }
            else if (ch == ')' || ch == '}' || ch == ']')
            {
                if (stack.Count == 0)
                {
                    balanced = false;
                    break;
                }
                char top = stack.Pop();
                if ((ch == ')' && top != '(') ||
                    (ch == '}' && top != '{') ||
                    (ch == ']' && top != '['))
                {
                    balanced = false;
                    break;
                }
            }
        }
        if (stack.Count != 0)
            balanced = false;
        if (balanced)
            Console.WriteLine("Balanced");
        else
            Console.WriteLine("Not Balanced");
    }
}
