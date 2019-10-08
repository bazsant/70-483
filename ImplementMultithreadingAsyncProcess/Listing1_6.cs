using System;
using System.Threading;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Using <i>ThreadLocal</i>
    /// </summary>
    internal class Listing1_6
    {
        public static ThreadLocal<int> _field = new ThreadLocal<int>(() =>
        {
            return Thread.CurrentThread.ManagedThreadId;
        });

        internal static void Exec()
        {
            new Thread(() =>
            {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread A: {0}", i);
                }
            }).Start();

            new Thread(() =>
            {
                for (int i = 0; i < _field.Value; i++)
                {
                    Console.WriteLine("Thread B: {0}", i);
                }
            }).Start();
        }
    }
}