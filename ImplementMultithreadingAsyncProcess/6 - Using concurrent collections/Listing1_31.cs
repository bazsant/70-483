using System;
using System.Collections.Concurrent;
using System.Threading;
using System.Threading.Tasks;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Enumerating a <i>ConcurrentBag</i>
    /// </summary>
    internal class Listing1_31
    {
        internal static void Exec()
        {
            ConcurrentBag<int> bag = new ConcurrentBag<int>();

            Task.Run(() => {
                bag.Add(42);
                Thread.Sleep(1000);
                bag.Add(21);
            });

            Task.Run(() => {
                foreach (var item in bag)
                {
                    Console.WriteLine(item);
                }
            }).Wait();
        }
    }
}