using System;
using System.Linq;

namespace ImplementMultithreadingAsyncProcess
{
    internal class Listing1_23
    {
        /// <summary>
        /// Unordered parallel query
        /// </summary>
        internal static void Exec()
        {
            var numbers = Enumerable.Range(0, 100);

            var parallelResult = numbers.AsParallel()
                .Where(i => i % 2 == 0)
                .ToArray();

            foreach (var i in parallelResult)
            {
                Console.WriteLine(i);
            }
        }
    }
}