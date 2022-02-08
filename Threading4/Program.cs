using System;
using System.Threading;
using System.Diagnostics;

namespace Threading4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Thread th = new Thread(ExecuteInForeground);
            th.IsBackground = false;
            th.Start();
            Thread.Sleep(1000);
            Console.WriteLine("Main thread ({0}) exiting...", Thread.CurrentThread.ManagedThreadId);
            Console.WriteLine("Main thread ({0}) exiting...", Thread.CurrentThread.ThreadState);

        }

        private static void ExecuteInForeground()
        {
            DateTime start = DateTime.Now;
            Stopwatch sw = Stopwatch.StartNew();
            Console.WriteLine("Thread {0}: State {1}, Priority {2}", Thread.CurrentThread.ManagedThreadId, Thread.CurrentThread.ThreadState, Thread.CurrentThread.Priority);

            do
            {
                Console.WriteLine("Thread {0}: Elapsed {1:N2} seconds", Thread.CurrentThread.ManagedThreadId, sw.ElapsedMilliseconds / 1000.0);
                Thread.Sleep(500);
            } while (sw.ElapsedMilliseconds <= 5000);
            sw.Stop();
        }
    }
}
