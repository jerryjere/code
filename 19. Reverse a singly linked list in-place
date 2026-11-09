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
    static Node Reverse(Node head)
    {
        Node previous = null;
        Node current = head;
        while (current != null)
        {
            Node next = current.next;
            current.next = previous;
            previous = current;
            current = next;
        }
        return previous;
    }
    static void Main()
    {
        Node head = new Node(10);
        head.next = new Node(20);
        head.next.next = new Node(30);
        head = Reverse(head);
        while (head != null)
        {
            Console.Write(head.data + " ");
            head = head.next;
        }
    }
}



--dynamic--



using System;
class Node
{
    public int data;
    public Node next;
    public Node(int value)
    {
        data = value;
        next = null;
    }
}
class Program
{
    static Node Reverse(Node head)
    {
        Node prev = null;
        Node current = head;
        while (current != null)
        {
            Node next = current.next;
            current.next = prev;
            prev = current;
            current = next;
        }
        return prev;
    }
    static void Main()
    {
        Node head = new Node(10);
        head.next = new Node(20);
        head.next.next = new Node(30);
        head = Reverse(head);
        while (head != null)
        {
            Console.Write(head.data + " ");
            head = head.next;
        }
    }
}
