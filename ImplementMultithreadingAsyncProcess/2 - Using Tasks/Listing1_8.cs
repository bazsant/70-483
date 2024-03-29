﻿using System;
using System.Threading.Tasks;

namespace ImplementMultithreadingAsyncProcess
{
    /// <summary>
    /// Starting a new task
    /// </summary>
    internal class Listing1_8
    {
        internal static void Exec()
        {
            Task t = Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    Console.Write("*");
                }
            });

            t.Wait();
        }
    }
}