using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Using <i>GetConsumingEnumerable</i> on a <i>BlockingCollection</i>
    /// </summary>
    internal class Listing1_29
    {
        internal static void Exec()
        {
            BlockingCollection<string> col = new BlockingCollection<string>();

            Task read = Task.Run(() => {
                foreach (var item in col.GetConsumingEnumerable())
                {
                    Console.WriteLine(item);
                }
            });

            Task write = Task.Run(() => {
                while (true)
                {
                    string s = Console.ReadLine();
                    if (string.IsNullOrEmpty(s)) break;
                    col.Add(s);
                }
            });

            write.Wait();
        }
    }
}