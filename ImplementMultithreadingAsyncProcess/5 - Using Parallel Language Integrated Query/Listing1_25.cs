using System;
using System.Linq;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Making a parallel query sequential
    /// </summary>
    internal class Listing1_25
    {
        internal static void Exec()
        {
            var numbers = Enumerable.Range(0, 100);

            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(x => x % 2 == 0).AsSequential();

            foreach (var i in parallelResult.Take(5))
            {
                Console.WriteLine(i);
            }
        }
    }
}