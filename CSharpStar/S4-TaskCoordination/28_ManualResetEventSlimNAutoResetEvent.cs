//using System;
//using System.Threading;
//using System.Threading.Tasks;

//namespace CSharpStar
//{
//    // ???
//    class ResetEvents
//    {
//        public static void Manual()
//        {
//            var evt = new ManualResetEventSlim();
//            var cts = new CancellationTokenSource();
//            var token = cts.Token;

//            Task.Factory.StartNew(() =>
//            {
//                Console.WriteLine("Boiling water...");
//                for (int i = 0; i < 30; i++)
//                {
//                    token.ThrowIfCancellationRequested();
//                    Thread.Sleep(100);
//                }
//                Console.WriteLine("Water is ready.");
//                evt.Set();
//            }, token);

//            var makeTea = Task.Factory.StartNew(() =>
//            {
//                Console.WriteLine("Waiting for water...");
//                evt.Wait(5000, token);
//                Console.WriteLine("Here is your tea!");
//                Console.WriteLine($"Is the event set? {evt.IsSet}");

//                evt.Reset();
//                evt.Wait(1000, token); // already set!
//                Console.WriteLine("That was a nice cup of tea!");
//            }, token);

//            makeTea.Wait(token);
//        }

//        static void Main(string[] args)
//        {
//            Manual();
//            //Automatic();
//        }

//        private static void Automatic()
//        {
//            // try switching between manual and auto :)
//            var evt = new AutoResetEvent(false);

//            evt.Set(); // ok, it's set

//            evt.WaitOne(); // this is ok but, in auto, it causes a reset

//            if (evt.WaitOne(1000))
//            {
//                Console.WriteLine("Succeeded");
//            }
//            else
//            {
//                Console.WriteLine("Timed out");
//            }
//        }
//    }
//}

/*
using System;
using System.Threading;

public class Example
{
    // mre is used to block and release threads manually. It is
    // created in the unsignaled state.
    private static ManualResetEvent mre = new ManualResetEvent(false);

    static void Main()
    {
        Console.WriteLine("\nStart 3 named threads that block on a ManualResetEvent:\n");

        for (int i = 0; i <= 2; i++)
        {
            Thread t = new Thread(ThreadProc);
            t.Name = "Thread_" + i;
            t.Start();
        }

        Thread.Sleep(500);
        Console.WriteLine("\nWhen all three threads have started, press Enter to call Set()" +
                          "\nto release all the threads.\n");
        Console.ReadLine();

        mre.Set();

        Thread.Sleep(500);
        Console.WriteLine("\nWhen a ManualResetEvent is signaled, threads that call WaitOne()" +
                          "\ndo not block. Press Enter to show this.\n");
        Console.ReadLine();

        for (int i = 3; i <= 4; i++)
        {
            Thread t = new Thread(ThreadProc);
            t.Name = "Thread_" + i;
            t.Start();
        }

        Thread.Sleep(500);
        Console.WriteLine("\nPress Enter to call Reset(), so that threads once again block" +
                          "\nwhen they call WaitOne().\n");
        Console.ReadLine();

        mre.Reset();

        // Start a thread that waits on the ManualResetEvent.
        Thread t5 = new Thread(ThreadProc);
        t5.Name = "Thread_5";
        t5.Start();

        Thread.Sleep(500);
        Console.WriteLine("\nPress Enter to call Set() and conclude the demo.");
        Console.ReadLine();

        mre.Set();

        // If you run this example in Visual Studio, uncomment the following line:
        //Console.ReadLine();
    }

    private static void ThreadProc()
    {
        string name = Thread.CurrentThread.Name;

        Console.WriteLine(name + " starts and calls mre.WaitOne()");

        mre.WaitOne();

        Console.WriteLine(name + " ends.");
    }
}

/* This example produces output similar to the following:

Start 3 named threads that block on a ManualResetEvent:

Thread_0 starts and calls mre.WaitOne()
Thread_1 starts and calls mre.WaitOne()
Thread_2 starts and calls mre.WaitOne()

When all three threads have started, press Enter to call Set()
to release all the threads.


Thread_2 ends.
Thread_0 ends.
Thread_1 ends.

When a ManualResetEvent is signaled, threads that call WaitOne()
do not block. Press Enter to show this.


Thread_3 starts and calls mre.WaitOne()
Thread_3 ends.
Thread_4 starts and calls mre.WaitOne()
Thread_4 ends.

Press Enter to call Reset(), so that threads once again block
when they call WaitOne().


Thread_5 starts and calls mre.WaitOne()

Press Enter to call Set() and conclude the demo.

Thread_5 ends.
 */

/*
using System;
using System.Threading;

// Visual Studio: Replace the default class in a Console project with 
//                the following class.
class Example
{
    private static AutoResetEvent event_1 = new AutoResetEvent(true);
    private static AutoResetEvent event_2 = new AutoResetEvent(false);

    static void Main()
    {
        Console.WriteLine("Press Enter to create three threads and start them.\r\n" +
                          "The threads wait on AutoResetEvent #1, which was created\r\n" +
                          "in the signaled state, so the first thread is released.\r\n" +
                          "This puts AutoResetEvent #1 into the unsignaled state.");
        Console.ReadLine();

        for (int i = 1; i < 4; i++)
        {
            Thread t = new Thread(ThreadProc);
            t.Name = "Thread_" + i;
            t.Start();
        }
        Thread.Sleep(250);

        for (int i = 0; i < 2; i++)
        {
            Console.WriteLine("Press Enter to release another thread.");
            Console.ReadLine();
            event_1.Set();
            Thread.Sleep(250);
        }

        Console.WriteLine("\r\nAll threads are now waiting on AutoResetEvent #2.");
        for (int i = 0; i < 3; i++)
        {
            Console.WriteLine("Press Enter to release a thread.");
            Console.ReadLine();
            event_2.Set();
            Thread.Sleep(250);
        }

        // Visual Studio: Uncomment the following line.
        //Console.Readline();
    }

    static void ThreadProc()
    {
        string name = Thread.CurrentThread.Name;

        Console.WriteLine("{0} waits on AutoResetEvent #1.", name);
        event_1.WaitOne();
        Console.WriteLine("{0} is released from AutoResetEvent #1.", name);

        Console.WriteLine("{0} waits on AutoResetEvent #2.", name);
        event_2.WaitOne();
        Console.WriteLine("{0} is released from AutoResetEvent #2.", name);

        Console.WriteLine("{0} ends.", name);
    }
}

/* This example produces output similar to the following:

Press Enter to create three threads and start them.
The threads wait on AutoResetEvent #1, which was created
in the signaled state, so the first thread is released.
This puts AutoResetEvent #1 into the unsignaled state.

Thread_1 waits on AutoResetEvent #1.
Thread_1 is released from AutoResetEvent #1.
Thread_1 waits on AutoResetEvent #2.
Thread_3 waits on AutoResetEvent #1.
Thread_2 waits on AutoResetEvent #1.
Press Enter to release another thread.

Thread_3 is released from AutoResetEvent #1.
Thread_3 waits on AutoResetEvent #2.
Press Enter to release another thread.

Thread_2 is released from AutoResetEvent #1.
Thread_2 waits on AutoResetEvent #2.

All threads are now waiting on AutoResetEvent #2.
Press Enter to release a thread.

Thread_2 is released from AutoResetEvent #2.
Thread_2 ends.
Press Enter to release a thread.

Thread_1 is released from AutoResetEvent #2.
Thread_1 ends.
Press Enter to release a thread.

Thread_3 is released from AutoResetEvent #2.
Thread_3 ends.
 */