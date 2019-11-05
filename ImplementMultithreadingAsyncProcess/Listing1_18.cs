using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// <i>async</i> and <i>await</i>
    /// </summary>
    internal class Listing1_18
    {
        private static async Task<string> DownloadContent()
        {
            using (HttpClient client = new HttpClient())
            {
                string result = await client.GetStringAsync("http://google.com");
                return result;
            }
        }
        internal static void Exec()
        {
            string result = DownloadContent().Result;            
            Console.WriteLine(result);
        }
    }
}