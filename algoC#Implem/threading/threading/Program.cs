using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Diagnostics;

namespace threading
{
    class Program
    {
        class Test
        {
            static Thread mainThread, thread1, thread2;
            static void Main()
            {
                BackgroundTest shortTest = new BackgroundTest(20);
                Thread foregroundThread =
                    new Thread(new ThreadStart(shortTest.RunLoop));
                foregroundThread.Name = "ForegroundThread";

                BackgroundTest longTest = new BackgroundTest(10);
                Thread backgroundThread =
                    new Thread(new ThreadStart(longTest.RunLoop));
                backgroundThread.Name = "BackgroundThread";
                backgroundThread.IsBackground = true;



               // mainThread = Thread.CurrentThread;
                thread1 = new Thread(ThreadProc);
                thread1.Name = "Thread1";
                thread1.Start();

                thread2 = new Thread(ThreadProc);
                thread2.Name = "Thread2";
                thread2.Start();   




                //foregroundThread.Start();
                //backgroundThread.Start();





            }

            private static void ThreadProc()
            {
                Console.WriteLine("\nCurrent thread: {0}", Thread.CurrentThread.Name);
                if (Thread.CurrentThread.Name == "Thread1" &&
                    thread2.ThreadState !=System.Threading.ThreadState.Unstarted)
                    thread2.Join();

                Thread.Sleep(4000);
                Console.WriteLine("\nCurrent thread: {0}", Thread.CurrentThread.Name);
                Console.WriteLine("Thread1: {0}", thread1.ThreadState);
                Console.WriteLine("Thread2: {0}\n", thread2.ThreadState);
            }
        }

        class BackgroundTest
        {
            int maxIterations;

            public BackgroundTest(int maxIterations)
            {
                this.maxIterations = maxIterations;
            }

            public void RunLoop()
            {
                String threadName = Thread.CurrentThread.Name;

                for (int i = 0; i < maxIterations; i++)
                {
                    Console.WriteLine("{0} count: {1}",
                        threadName, i.ToString());
                    Thread.Sleep(250);
                }
                Console.WriteLine("{0} finished counting.", threadName);
            }
        }
    }
}
