using System;
using System.Collections.Generic;
using System.Text;
using System.Threading;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Creating a thread with the <i>Thread</i> Class
    /// </summary>
    internal class Listing1_1
    {
        private static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(0);
            }
        }
        internal static void Exec()
        {
            Thread t = new Thread(new ThreadStart(ThreadMethod));
            t.Start();

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main Thread");
                Thread.Sleep(0);
            }

            t.Join();
        }

    }
}
