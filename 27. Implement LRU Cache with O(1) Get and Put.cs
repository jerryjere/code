using System;
using System.Collections.Generic;
class LRUCache
{
    int capacity;
    Dictionary<int, LinkedListNode<KeyValuePair<int, int>>> map;
    LinkedList<KeyValuePair<int, int>> list;
    public LRUCache(int size)
    {
        capacity = size;
        map = new Dictionary<int, LinkedListNode<KeyValuePair<int, int>>>();
        list = new LinkedList<KeyValuePair<int, int>>();
    }
    public int Get(int key)
    {
        if (!map.ContainsKey(key))
            return -1;
        var node = map[key];
        list.Remove(node);
        list.AddFirst(node);
        return node.Value.Value;
    }
    public void Put(int key, int value)
    {
        if (map.ContainsKey(key))
        {
            list.Remove(map[key]);
        }
        else if (map.Count == capacity)
        {
            int oldKey = list.Last.Value.Key;

            list.RemoveLast();
            map.Remove(oldKey);
        }
        var newNode = new LinkedListNode<KeyValuePair<int, int>>(
            new KeyValuePair<int, int>(key, value));
        list.AddFirst(newNode);
        map[key] = newNode;
    }
}
class Program
{
    static void Main()
    {
        LRUCache cache = new LRUCache(2);
        cache.Put(1, 10);
        cache.Put(2, 20);
        Console.WriteLine(cache.Get(1));
        cache.Put(3, 30);
        Console.WriteLine(cache.Get(2));
    }
}



--dynamic--


using System;
using System.Collections.Generic;
class LRUCache
{
    int capacity;
    Dictionary<int, LinkedListNode<int>> map =
        new Dictionary<int, LinkedListNode<int>>();
    LinkedList<int> list = new LinkedList<int>();
    public LRUCache(int size)
    {
        capacity = size;
    }
    public int Get(int key)
    {
        if (!map.ContainsKey(key))
            return -1;
        var node = map[key];
        list.Remove(node);
        list.AddFirst(node);
        return key;
    }
    public void Put(int key)
    {
        if (map.ContainsKey(key))
        {
            list.Remove(map[key]);
        }
        else if (list.Count == capacity)
        {
            int last = list.Last.Value;
            list.RemoveLast();
            map.Remove(last);
        }
        list.AddFirst(key);
        map[key] = list.First;
    }
}
class Program
{
    static void Main()
    {
        LRUCache cache = new LRUCache(2);
        cache.Put(1);
        cache.Put(2);
        Console.WriteLine(cache.Get(1));
        cache.Put(3);
        Console.WriteLine(cache.Get(2));
        Console.WriteLine(cache.Get(3));
    }
}
