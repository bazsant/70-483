using System;
using System.Linq;
using System.Collections.Concurrent;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Using <i>ConcurrentDictionary</i>
    /// </summary>
    internal class Listing1_34
    {
        internal static void Exec()
        {
            ConcurrentDictionary<string, int> dict = new ConcurrentDictionary<string, int>();

            if (dict.TryAdd("k1", 42))
            {
                Console.WriteLine("Added");
            }

            if (dict.TryUpdate("k1", 21, 42))
            {
                Console.WriteLine("42 virou 21");
            }

            dict["k1"] = 42;

            int r1 = dict.AddOrUpdate("k1", 3, (x, y) => y * 2);
            int r2 = dict.GetOrAdd("k2", 3);

            Console.WriteLine("r1: {0}; r2: {1}", r1, r2);

            dict.ToArray().AsParallel().ForAll(x => Console.WriteLine("Key: {0}; Val: {1}", x.Key, x.Value));
        }
    }
}