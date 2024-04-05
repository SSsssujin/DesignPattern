using System;
using System.Threading;

public class SimpleThreadExample
{
    private const int _repetition = 1000;

    private static int i = 0;
    
    public static void Main()
    {
        Thread myWorkThread = new Thread(DoWork);
        DoWork();
        
        for (int i = 0; i < _repetition; i++)
        {
            Thread t = new Thread(DoWork);
            t.Name = "Thread " + i.ToString();
            t.Start();
        }

        Thread waitInputThread = new Thread(() =>
        {
            Console.WriteLine("Thread is starting. Press ENTER to continue...");
            Console.ReadLine();
        });
        waitInputThread.IsBackground = true;
        waitInputThread.Start();
    }

    public static void DoWork()
    {
        for (i = 0; i < _repetition; i++)
        {
            Console.WriteLine("*");
        }
    }
}