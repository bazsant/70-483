using System;
using System.Collections.Concurrent;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Using <i>ConcurrentQueue</i>
    /// </summary>
    internal class Listing1_33
    {
        internal static void Exec()
        {
            ConcurrentQueue<int> queue = new ConcurrentQueue<int>();

            queue.Enqueue(41);
            queue.Enqueue(42);
            queue.Enqueue(43);

            int result;

            if (queue.TryDequeue(out result))
            {
                Console.WriteLine("Dequeued: {0}", result);
            }


        }
    }
}