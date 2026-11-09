using System;
class Singleton
{
    private static readonly Singleton instance = new Singleton();
    private Singleton()
    {
    }
    public static Singleton GetInstance()
    {
        return instance;
    }
    public void Display()
    {
        Console.WriteLine("Singleton Object Created");
    }
}
class Program
{
    static void Main()
    {
        Singleton obj = Singleton.GetInstance();
        obj.Display();
    }
}


---dynamic---


using System;
class Singleton
{
    private static readonly Lazy<Singleton> instance =
        new Lazy<Singleton>(() => new Singleton());
    private Singleton()
    {
        Console.WriteLine("Singleton Created");
    }
    public static Singleton Instance
    {
        get { return instance.Value; }
    }
}
class Program
{
    static void Main()
    {
        Singleton obj1 = Singleton.Instance;
        Singleton obj2 = Singleton.Instance;
        Console.WriteLine(obj1 == obj2);
    }
}
