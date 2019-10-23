using System;
using System.Threading;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Stopping a thread
    /// </summary>
    internal class Listing1_4
    {
        private static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
        internal static void Exec()
        {
            bool stopped = false;

            Thread t = new Thread(new ThreadStart(() =>
            {
                while (!stopped)
                {
                    Console.WriteLine("Runniiiiing...");
                    Thread.Sleep(0);
                }
            }));

            t.Start();

            Console.WriteLine("Press key to exit");
            Console.ReadKey();

            stopped = true;

            Console.WriteLine("Stopped!!!!!");

            t.Join();
        }
    }
}