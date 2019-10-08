using System;
using System.Threading;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Using the <i>ParametrizedThreadStart</i>
    /// </summary>
    internal class Listing1_3
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
            Thread t = new Thread(new ParameterizedThreadStart(ThreadMethod));
            t.Start(5);
            t.Join();
        }
        
    }
}