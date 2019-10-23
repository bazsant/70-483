using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Using <i>Parallel.For</i> and <i>Parallel.Foreach</i>
    /// </summary>
    internal class Listing1_16
    {
        internal static void Exec()
        {
            Parallel.For(0, 10, i =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("1-{0}",i);
            });

            var numbers = Enumerable.Range(0, 100);
            Parallel.ForEach(numbers, i =>
            {
                Thread.Sleep(1000);
                Console.WriteLine("2-{0}", i);
            });
        }
    }
}