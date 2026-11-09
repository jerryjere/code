using System;
class Node
{
    public int data;
    public Node next;
    public Node(int value)
    {
        data = value;
    }
}
class Program
{
    static void Main()
    {
        Node a = new Node(10);
        Node b = new Node(20);
        Node c = new Node(30);
        a.next = b;
        b.next = c;
        c.next = b; 
        Node slow = a;
        Node fast = a;
        bool cycle = false;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
            {
                cycle = true;
                break;
            }
        }
        Console.WriteLine(cycle ? "Cycle Found" : "No Cycle");
    }
}



--dynamic---


using System;
class Node
{
    public int data;
    public Node next;

    public Node(int value)
    {
        data = value;
    }
}
class Program
{
    static bool HasCycle(Node head)
    {
        Node slow = head;
        Node fast = head;
        while (fast != null && fast.next != null)
        {
            slow = slow.next;
            fast = fast.next.next;
            if (slow == fast)
                return true;
        }
        return false;
    }
    static void Main()
    {
        Node head = new Node(10);
        head.next = new Node(20);
        head.next.next = new Node(30);
        head.next.next.next = head.next;
        if (HasCycle(head))
            Console.WriteLine("Cycle Detected");
        else
            Console.WriteLine("No Cycle");
    }
}
