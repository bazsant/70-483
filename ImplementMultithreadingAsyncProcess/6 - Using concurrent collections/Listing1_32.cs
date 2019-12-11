using System;
using System.Collections.Concurrent;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Using a <i>ConcurrentStack</i>
    /// </summary>
    internal class Listing1_32
    {
        internal static void Exec()
        {
            ConcurrentStack<int> stack = new ConcurrentStack<int>();

            stack.Push(41);
            stack.Push(42);
            stack.Push(43);

            int result;

            if (stack.TryPop(out result))
            {
                Console.WriteLine("Popped: {0}", result);
            }

            stack.PushRange(new int[] { 1, 2, 3 });

            int[] values = new int[2];
            stack.TryPopRange(values);

            foreach (var item in values)
            {
                Console.WriteLine(item);
            }
        }
    }
}