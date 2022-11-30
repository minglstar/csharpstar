using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStar.S5_ParallelLoops
{
    internal class _34_ThreadLocalStorage
    {

       /* static void Main(string[] args)
        {
            int sum = 0;

            Parallel.For(1, 1001,
                () => 0, // initialize local state, show code completion for next arg
                (x, state, tls) => // Func<T1,T2,T3,TResult> Delegate 封装一个方法，该方法具有三个参数，且返回由 TResult 参数指定的类型的值。
                {
                tls += x;
                Console.WriteLine($"Task {Task.CurrentId} has sum {tls}");
                return tls;
            }, partialSum =>
            {
                Console.WriteLine($"Partial value of task {Task.CurrentId} is {partialSum}");
                Interlocked.Add(ref sum, partialSum);
            });

            Console.WriteLine($"Sum of 1..100 = {sum}");
        }*/
    }
}
