using System;
using System.Threading.Tasks;

namespace ImplementMultithreadingAsyncProcess
{
    internal class Listing1_10
    {
        internal static void Exec()
        {
            Task<int> t = Task.Run(() =>
            {
                return 24;
            }).ContinueWith((i) =>
            {
                return i.Result * 2;
            });

            Console.WriteLine("Result: {0}", t.Result);
        }
    }
}