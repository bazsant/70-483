using System;
using System.Linq;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Ordered parallel query
    /// </summary>
    internal class Listing1_24
    {
        internal static void Exec()
        {
            var numbers = Enumerable.Range(0, 100000);

            var parallelResult = numbers.AsParallel().AsOrdered()
                .Where(x => x % 2 == 0)
                .ToArray();

            foreach (var i in parallelResult)
            {            
                Console.WriteLine(i);
            }

        }
    }
}