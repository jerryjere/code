using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
class Program
{
    static BlockingCollection<int> queue =
        new BlockingCollection<int>();
    static void Producer()
    {
        for (int i = 1; i <= 5; i++)
        {
            queue.Add(i);
            Console.WriteLine("Produced: " + i);
        }
        queue.CompleteAdding();
    }
    static void Consumer()
    {
        foreach (int item in queue.GetConsumingEnumerable())
        {
            Console.WriteLine("Consumed: " + item);
        }
    }
    static void Main()
    {
        Task producer = Task.Run(() => Producer());
        Task consumer = Task.Run(() => Consumer());
        Task.WaitAll(producer, consumer);
    }
}



--dynamic--


using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;
class Program
{
    static BlockingCollection<int> queue =
        new BlockingCollection<int>();
    static void Producer()
    {
        for (int i = 1; i <= 5; i++)
        {
            queue.Add(i);
            Console.WriteLine("Produced: " + i);
        }
        queue.CompleteAdding();
    }
    static void Consumer()
    {
        foreach (int item in queue.GetConsumingEnumerable())
        {
            Console.WriteLine("Consumed: " + item);
        }
    }
    static void Main()
    {
        Task producer = Task.Run(() => Producer());
        Task consumer = Task.Run(() => Consumer());
        Task.WaitAll(producer, consumer);
    }
}
