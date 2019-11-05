using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Using <i>ConfigureAwait</i>
    /// </summary>
    internal class Listing1_20
    {
        internal static async Task Exec()
        {
            HttpClient httpClient = new HttpClient();

            string content = await httpClient
                .GetStringAsync("http://google.com")
                .ConfigureAwait(false);

            Console.WriteLine(content);
        }
    }
}