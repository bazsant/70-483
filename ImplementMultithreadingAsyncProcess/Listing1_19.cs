using System;
using System.Threading;
using System.Threading.Tasks;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Svalability versus responsiveness
    /// </summary>
    internal class Listing1_19
    {
        private static Task SleepAsyncA(int millisecondesTimeout)
        {
            return Task.Run(() => Thread.Sleep(millisecondesTimeout));
        }

        private static Task SleepAsyncB(int millisecondsTimeout)
        {
            TaskCompletionSource<bool> tcs = null;

            var t = new Timer(delegate { tcs.TrySetResult(true); }, null, -1, -1);
            tcs = new TaskCompletionSource<bool>(t);
            t.Change(millisecondsTimeout, -1);

            return tcs.Task;
        }

        internal static void Exec()
        {
            SleepAsyncA(1000);
            SleepAsyncB(1000);            
            Console.WriteLine("End");
        }
    }
}