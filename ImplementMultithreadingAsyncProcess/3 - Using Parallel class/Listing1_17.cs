using System;
using System.Threading.Tasks;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Using <i>Parallel.Break</i>
    /// </summary>
    internal class Listing1_17
    {
        internal static void Exec()
        {
            ParallelLoopResult result = Parallel.For(0, 1000, (int i, ParallelLoopState loopState) =>
            {
                Console.WriteLine(i);
                if (i == 500)
                {
                    Console.WriteLine("breaking loop");
                    loopState.Break();
                }

                return;
            });
        }
    }
}