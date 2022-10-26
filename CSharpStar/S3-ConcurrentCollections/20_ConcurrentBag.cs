using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Threading;
using System.Threading.Tasks;

namespace CSharpStar
{
    internal static class ConcurrentBag
    {
        //static void Main()
        //{
        //    // stack Last in First out (LIFO)
        //    // queue First in First out (FIFO)
        //    // concurrent bag provides NO ordering guarantees

        //    // keeps a separate list of items for each thread
        //    // typically requires no synchronization, unless a thread tries to remove an item
        //    // while the thread-local bag is empty (item stealing)
        //    var bag = new ConcurrentBag<int>();
        //    var tasks = new List<Task>();
        //    for (int i = 0; i < 10; i++)
        //    {
        //        var i1 = i;
        //        tasks.Add(Task.Factory.StartNew(() =>
        //        {
        //            bag.Add(i1);
        //            Console.WriteLine($"Thread{Task.CurrentId} has added {i1}");
        //            int result;
        //            if (bag.TryPeek(out result))
        //            {
        //                Console.WriteLine($"Thread{Task.CurrentId} has peeked the value {result}");
        //            }
        //        }));
        //    }

        //    Task.WaitAll(tasks.ToArray());

        //    var isEmpty = bag.IsEmpty;
        //    Console.WriteLine($"Bag is empty: {isEmpty}");


        //    // take whatever's last
        //    int last;
        //    if (bag.TryTake(out last))
        //    {
        //        Console.WriteLine($"Last element is {last}");
        //    }

        //}
    }
}

