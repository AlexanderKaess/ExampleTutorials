using System;
using System.Threading;

namespace Threading
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine("Main thread: Start a second thread.");

            Thread t = new Thread(new ThreadStart(ThreadProc));

            t.Start();
            Thread.Sleep(500);

            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Main thread: Do some work.");
                Thread.Sleep(500);
            }

            Console.WriteLine("Main thread: Call Join(), to wait until ThreadProc ends.");
            //Blocks the calling thread until the thread represented by this instance terminates,
            //while continuing to perform standard COM and SendMessage pumping.
            t.Join();
            Console.WriteLine("Main thread: ThreadProc.Join has returned.  Press Enter to end program.");
            Console.ReadLine();

            Console.ReadKey();
        }

        public static void ThreadProc()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0} ", i);
                Thread.Sleep(500);
            }

        }








    }
}
