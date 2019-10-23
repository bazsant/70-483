using System;
using System.Threading;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Using the <i>ThreadStaticAttribute</i>
    /// </summary>
    internal class Listing1_5
    {
        [ThreadStatic]
        public static int _field;
        internal static void Exec()
        {
            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread A: {0}", _field);
                }
            }).Start();

            new Thread(() =>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine("Thread B: {0}", _field);
                }
            }).Start();
        }
    }
}