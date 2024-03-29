﻿using System;
using System.IO;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Continuing on a thread pool instead of the UI thread
    /// </summary>
    internal class Listing1_21
    {
        private static async Task TaskMethodAsync()
        {
            var httpClient = new HttpClient();

            string content = await httpClient
                .GetStringAsync("https://google.com")
                .ConfigureAwait(false);

            using (var sourceStream = new FileStream("temp.html",
                FileMode.Create, FileAccess.Write, FileShare.None, 4096, false))
            {
                byte[] encodedText = Encoding.Unicode.GetBytes(content);
                await sourceStream.WriteAsync(encodedText, 0, encodedText.Length)
                    .ConfigureAwait(false);
            }
        }
        internal static async Task Exec()
        {
            await TaskMethodAsync();
        }
    }
}