using System;
using System.Threading;

namespace CSharpStar
{
    internal static class MutexForLocking
    {
        //public static void Main(string[] args)
        //{
        //    var tasks = new List<Task>();
        //    var ba = new BankAccount();
        //    var ba2 = new BankAccount();

        //    Mutex mx1 = new Mutex();
        //    Mutex mx2 = new Mutex();

        //    for (int i = 0; i < 10; i++)
        //    {
        //        tasks.Add(Task.Factory.StartNew(() =>
        //        {
        //            for (int j = 0; j < 1000; j++)
        //            {
        //                var haveLock = mx1.WaitOne();
        //                try
        //                {
        //                    ba.Deposit(1);
        //                }
        //                finally
        //                {
        //                    if (haveLock) mx1.ReleaseMutex();
        //                }
        //            }
        //        }));
        //    }

        //    for (int i = 0; i < 10; i++)
        //    {
        //        tasks.Add(Task.Factory.StartNew(() =>
        //        {
        //            for (int j = 0; j < 1000; j++)
        //            {
        //                var haveLock = mx2.WaitOne();
        //                try
        //                {
        //                    ba2.Deposit(1);
        //                }
        //                finally
        //                {
        //                    if (haveLock) mx2.ReleaseMutex();
        //                }
        //            }
        //        }));

        //        tasks.Add(Task.Factory.StartNew(() =>
        //        {
        //            for (int j = 0; j < 1000; j++)
        //            {
        //                var haveLock = WaitHandle.WaitAll(new[] { mx1, mx2 });
        //                try
        //                {
        //                    ba.Transfer(ba2, 1);
        //                }
        //                finally
        //                {
        //                    if (haveLock)
        //                    {
        //                        mx1.ReleaseMutex();
        //                        mx2.ReleaseMutex();
        //                    }
        //                }
        //            }
        //        }));
        //    }


        //    Task.WaitAll(tasks.ToArray());

        //    Console.WriteLine($"Final balance ba is {ba.Balance}.");
        //    Console.WriteLine($"Final balance ba2 is {ba2.Balance}.");
        //}

    }

}