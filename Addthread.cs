using System;
using System.Threading;

class Addthread
{
    public static void Add(int a,int b)
    {
        Console.WriteLine("Add started");
        Console.WriteLine("Addition: " + (a + b));
        Thread.Sleep(3000);
        Console.WriteLine("Addition Completed");
        Console.WriteLine("Current Thread name: " + Thread.CurrentThread.Name);
    }
}
class Subthread
{
    public void Sub(int a, int b)
    {
        Console.WriteLine("sub started");
        Thread.Sleep(2000);
        Console.WriteLine("Subtraction Completed");
        Console.WriteLine("Current Thread name: " + Thread.CurrentThread.Name);
    }
}
class Threadprogram2
{
    static void Main()
    {
        Subthread s = new Subthread();
        Thread t1 = new Thread(() => Addthread.Add(11, 5));
        t1.Name = "Addition Thread";
        Thread t2 = new Thread(() => s.Sub(10, 5));
        t2.Name = "Subtraction Thread";
        t1.Start();
        t2.Start();
        Console.WriteLine("Operation is Completed");
        
    }
}
