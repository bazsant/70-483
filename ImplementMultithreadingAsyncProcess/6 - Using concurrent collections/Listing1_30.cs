using System;
using System.Collections.Concurrent;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Using a <i>ConcurrentBag</i>
    /// </summary>
    internal class Listing1_30
    {
        internal static void Exec()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            bag.Add(42);
            bag.Add(21);

            int result;

            if (bag.TryTake(out result))
            {
                Console.WriteLine(result);
            }

            if (bag.TryPeek(out result))
            {
                Console.WriteLine("Proximo item: {0}", result);
            }
        }
    }
}