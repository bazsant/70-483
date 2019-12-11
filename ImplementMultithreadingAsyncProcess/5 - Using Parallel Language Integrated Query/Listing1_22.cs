using System;
using System.Linq;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Using <i>AsParallel</i>
    /// </summary>
    internal class Listing1_22
    {
        internal static void Exec()
        {
            var numbers = Enumerable.Range(0, 1000000);
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