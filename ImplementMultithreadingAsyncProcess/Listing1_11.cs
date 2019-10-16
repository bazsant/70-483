using System;
using System.Threading.Tasks;

namespace ImplementMultithreadingAsyncProcess
{
    internal class Listing1_11
    {
        internal static void Exec()
        {
            Task<int> t = Task.Run(() =>
            {
                return 24;
            });
            
            t.ContinueWith((i) =>
            {
                Console.WriteLine("Canceled");
            }, TaskContinuationOptions.OnlyOnCanceled);

            t.ContinueWith((i) =>
            {
                Console.WriteLine("Faulted");
            }, TaskContinuationOptions.OnlyOnFaulted);

            var completedTask = t.ContinueWith((i) =>
            {
                Console.WriteLine("Completed");
            }, TaskContinuationOptions.OnlyOnRanToCompletion);

            completedTask.Wait();
        }
    }
}