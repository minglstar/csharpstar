using System;
namespace CSharpPractice
{
    public static class TaskCancelling
    {
        //public static void Main(string[] args)
        //{
        //    var cts = new CancellationTokenSource();
        //    var token = cts.Token;

        //    var t = new Task(() =>
        //    {
        //        int i = 0;
        //        while (true)
        //        {
        //            token.ThrowIfCancellationRequested();
        //            //if (token.IsCancellationRequested)
        //            //{
        //            //    throw new OperationCanceledException();
        //            //}
        //            //else
        //            Console.WriteLine($"{i++}\t");
        //        }

        //    }, token);
        //    t.Start();

        //    Console.ReadKey();
        //    cts.Cancel();

        //    Console.WriteLine("Main Program done.");
        //    Console.ReadKey();

        //}
    }
}

