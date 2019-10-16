using System;
using System.Threading.Tasks;

namespace ImplementMultithreadingAsyncProcess
{
    internal class Listing1_9
    {
        internal static void Exec()
        {
            Task<int> t = Task.Run(() =>
            {
                return 24;
            });

            Console.WriteLine("Return: {0}", t.Result);
        }
    }
}