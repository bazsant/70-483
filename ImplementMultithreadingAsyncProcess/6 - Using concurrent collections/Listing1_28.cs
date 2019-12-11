using System;
using System.Collections.Concurrent;
using System.Threading.Tasks;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Using <i>BlockingCollection<T></i>
    /// </summary>
    internal class Listing1_28
    {
        internal static void Exec()
        {
            var col = new BlockingCollection<string>();

            var read = Task.Run(() => {
                while (true)
                {
                    Console.WriteLine(col.Take());
                }
            });

            var write = Task.Run(() => {
                while (true)
                {
                    var s = Console.ReadLine();
                    if (string.IsNullOrEmpty(s))
                    {
                        break;
                    }
                    col.Add(s);
                }
            });

            write.Wait();
        }
    }
}