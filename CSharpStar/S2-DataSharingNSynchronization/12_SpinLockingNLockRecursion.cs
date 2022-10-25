using System;
namespace CSharpStar
{
    //internal static class SpinLocking
    //{
        // SpinLock: lock in the for loop
        //public static void Main(string[] args)
        //{
        //    var tasks = new List<Task>();
        //    var ba = new BankAccount();

        //    SpinLock sl = new SpinLock();

        //    for (int i = 0; i < 10; i++)
        //    {
        //        tasks.Add(Task.Factory.StartNew(() =>
        //        {
        //            for (int i = 0; i < 100; i++)
        //            {
        //                var lockTaken = false;
        //                try
        //                {
        //                    sl.Enter(ref lockTaken);
        //                    ba.Deposit(100);
        //                }
        //                finally
        //                {
        //                    if (lockTaken) sl.Exit();
        //                }
        //            }
        //        }));
        //    }

        //    for (int i = 0; i < 10; i++)
        //    {
        //        tasks.Add(Task.Factory.StartNew(() =>
        //        {
        //            for (int i = 0; i < 100; i++)
        //            {
        //                var lockTaken = false;
        //                try
        //                {
        //                    sl.Enter(ref lockTaken);
        //                    ba.WithDraw(100);
        //                }
        //                finally
        //                {
        //                    if (lockTaken) sl.Exit();
        //                }
        //            }
        //        }));
        //    }

        //    Task.WaitAll(tasks.ToArray());

        //    Console.WriteLine($"Final balance is {ba.Balance}.");

        //}

        // LockRecursionException
        //static SpinLock sl = new SpinLock(true);

        //public static void LockRecursion(int x)
        //{
        //    bool lockToken = false;
        //    try
        //    {
        //        sl.Enter(ref lockToken);
        //    }
        //    catch (LockRecursionException e)
        //    {
        //        Console.WriteLine(e);
        //    }
        //    finally
        //    {
        //        if (lockToken)
        //        {
        //            Console.WriteLine($"Took a lock, x = {x}");
        //            LockRecursion(x - 1);
        //            sl.Exit();
        //        }
        //        else
        //        {
        //            Console.WriteLine($"Failed to take a lock, x = {x}");

        //        }
        //    }

        //}

        //public static void Main(string[] args)
        //{
        //    LockRecursion(5);
        //}
    //}
}

