using System;
using System.Threading;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Queuing some work to the thread pool
    /// </summary>
    internal class Listing1_7
    {
        internal static void Exec()
        {
            ThreadPool.QueueUserWorkItem(s =>
            {
                Console.WriteLine("Working thread from threadpool");
            });
        }
    }
}