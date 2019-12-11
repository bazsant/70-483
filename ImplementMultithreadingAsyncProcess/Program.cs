using System;
using System.Diagnostics;

namespace ImplementMultithreadingAsyncProcess
{
    class Program
    {
        static void Main(string[] args)
        {
            var stopwatch = new Stopwatch();
            stopwatch.Start();

            //Understanding threads
            //Listing1_1.Exec();
            //Listing1_2.Exec();
            //Listing1_3.Exec();
            //Listing1_4.Exec();
            //Listing1_5.Exec();
            //Listing1_6.Exec();
            //Listing1_7.Exec();

            //Using Tasks
            //Listing1_8.Exec();
            //Listing1_9.Exec();
            //Listing1_10.Exec();
            //Listing1_11.Exec();
            //Listing1_12.Exec();
            //Listing1_13.Exec();
            //Listing1_14.Exec();
            //Listing1_15.Exec();

            //Using the Parallel class
            //Listing1_16.Exec();
            //Listing1_17.Exec();

            //Using async and await
            //Listing1_18.Exec();
            //Listing1_19.Exec();
            //Listing1_20.Exec();
            //Listing1_21.Exec();

            //Using Parallel Language Integrated Query (PLINQ)
            //Listing1_22.Exec();
            //Listing1_23.Exec();
            //Listing1_24.Exec();
            //Listing1_25.Exec();
            //Listing1_26.Exec();
            //Listing1_27.Exec();


            stopwatch.Stop();
            Console.WriteLine("Tempo decorrido: {0}",stopwatch.Elapsed.ToString());
            Console.ReadKey();
        }

    }
}
