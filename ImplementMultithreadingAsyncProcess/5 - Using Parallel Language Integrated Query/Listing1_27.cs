using System;
using System.Linq;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Catching <i>AggregateException</i>
    /// </summary>
    internal class Listing1_27
    {
        internal static void Exec()
        {
            var numbers = Enumerable.Range(0, 200);

            try
            {
                var parallelResult = numbers.AsParallel()
                    .Where(x => IsEven(x));

                parallelResult.ForAll(x => Console.WriteLine(x));
            }
            catch (AggregateException aggrEx)
            {
                aggrEx.InnerExceptions.AsParallel().ForAll(x => Console.WriteLine(x.Message));
            }
            catch (Exception)
            {
                throw;
            }
        }

        private static bool IsEven(int x)
        {
            if (x % 10 == 0)
            {
                throw new ArgumentException(string.Format("Error: {0}", x));
            }

            return x % 2 == 0;
        }
    }
}