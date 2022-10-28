using Microsoft.Diagnostics.Runtime.Utilities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStar.S6_Parallel_LINQ
{
    public class CancellationAndExceptions
    {
        /*static void Main(string[] args)
        {

            var cts = new CancellationTokenSource();
            var items = Enumerable.Range(1, 20);

            var results = items.AsParallel()
              .WithCancellation(cts.Token).Select(i =>
              {
                  double result = Math.Log10(i);

                  //if (result > 1) throw new InvalidOperationException();
                  Thread.Sleep((int)(result * 1000));
                  Console.WriteLine($"i = {i}, tid = {Task.CurrentId}");
                  return result;
              });

            // no exception yet, but...
            try
            {
                Console.WriteLine($"results: {results}");
                foreach (var c in results)
                {
                    if (c > 1)
                        cts.Cancel();
                    Console.WriteLine($"result = {c}");
                }
            }
            catch (OperationCanceledException e)
            {
                Console.WriteLine($"Canceled");
            }
            catch (AggregateException ae)
            {
                ae.Handle(e =>
                {
                    Console.WriteLine($"{e.GetType().Name}: {e.Message}");
                    return true;
                });
            }
        }*/
    }
}
