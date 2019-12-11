using System;
using System.Linq;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Using <i>ForAll</i>
    /// </summary>
    internal class Listing1_26
    {
        internal static void Exec()
        {
            var numbers = Enumerable.Range(0, 200);

            var parallelResult = numbers.AsParallel()
                .Where(x => x % 2 == 0);

            parallelResult.ForAll(x => Console.WriteLine(x));
        }
    }
}