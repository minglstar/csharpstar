using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpStar.S6_Parallel_LINQ
{
    // answered my question of the above lecture 
    public class MergeOptions
    {
        /*public static void Main(string[] args)
        {
            var numbers = Enumerable.Range(1, 20).ToArray();

            // FullyBuffered = all results produced before they are consumed
            // NotBuffered = each result can be consumed right after it's produced
            // Default = AutoBuffered = buffer the number of results selected by the runtime

            var results = numbers.AsParallel()
              .WithMergeOptions(ParallelMergeOptions.NotBuffered)
              .Select(x =>
              {
                  var result = Math.Log10(x);
                  Console.WriteLine($"Produced {result}");
                  return result;
              });

            foreach (var result in results)
            {
                Console.WriteLine($"Consumed {result}");
            }
        }*/
    }
}
