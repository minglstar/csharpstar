using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStar.S5_ParallelLoops
{
    internal class _32_ParallelInvoke
    {
        // Parallel for loop vs Standard for loop
        // In the case of the standard C# for loop, the loop is going to run using a single thread whereas, in the case of the Parallel For loop, the loop is going to execute using multiple threads.
        // The second difference is that, in the case of the standard C# for loop, the loop is iterated in sequential order whereas, in the case of the Parallel For loop, the order of the iteration is not going to be in sequential order.
        public static IEnumerable<int> Range(int start, int end, int step)
        {
            for (int i = start; i < end; i += step)
            {
                yield return i;
            }
        }

        /*static void Main(string[] args)
        {
            var a = new Action(() => Console.WriteLine($"First {Task.CurrentId}"));
            var b = new Action(() => Console.WriteLine($"Second {Task.CurrentId}"));
            var c = new Action(() => Console.WriteLine($"Third {Task.CurrentId}"));

            Parallel.Invoke(a, b, c);
            // these are blocking operations; wait on all tasks

            Parallel.For(1, 11, x =>
            {
                Console.WriteLine($"{x * x}\t");
            });
            Console.WriteLine();

            // has a step strictly equal to 1
            // if you want something else...
            Parallel.ForEach(Range(1, 20, 3), Console.WriteLine);

            // MaxDegreeOfParallelism
            string[] letters = { "oh", "what", "a", "night" };
            var po = new ParallelOptions();
            po.MaxDegreeOfParallelism = 2;
            Parallel.ForEach(letters, po, letter =>
            {
                Console.WriteLine($"{letter} has length {letter.Length} (task {Task.CurrentId})");
            });

        }*/
    }
}
