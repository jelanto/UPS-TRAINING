using System;
using System.Threading;

class AddThread
{
    public static void Add(int a, int b)
    {
        Console.WriteLine("Add started");
        Console.WriteLine("Addition: " + (a + b));

        Thread.Sleep(3000);

        Console.WriteLine("Addition Completed");
    }
}

class SubThread
{
    public void Sub(int a, int b)
    {
        Console.WriteLine("Sub started");
        Console.WriteLine("Subtraction: " + (a - b));

        Thread.Sleep(2000);

        Console.WriteLine("Subtraction Completed");
    }
}

class Threadprogram1
{
    static void Main()
    {
        SubThread s = new SubThread();

        Thread t1 = new Thread(() => AddThread.Add(10, 5));
        Thread t2 = new Thread(() => s.Sub(10, 5));

        t1.Start();
        t2.Start();

        Console.WriteLine("Main thread is running");

        t1.Join();
        t2.Join();

        Console.WriteLine("All Operations Completed");
    }
}
