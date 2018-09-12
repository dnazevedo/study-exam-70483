using System;
using System.Threading;

namespace ExamRef70483.Chapter_1
{
    public static class Program
    {
        #region Creating a thread with the thread class
        //public static void ThreadMethod()
        //{
        //    for (int i = 0; i < 10; i++)
        //    {
        //        Console.WriteLine("ThreadProc: {0}", i);
        //        Thread.Sleep(0);
        //        Console.ReadKey();
        //    }
        //}

        //public static void Main()
        //{
        //    Thread t = new Thread(new ThreadStart(ThreadMethod));
        //    t.Start();
        //    for (int i = 0; i < 4; i++)
        //    {
        //        Console.WriteLine("Main thread: Do some work.");
        //        Thread.Sleep(0);
        //        Console.ReadKey();
        //    }

        //    t.Join();
        //}
        #endregion

        #region Using a background thread

        public static void ThreadMethod()
        {
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("ThreadProc: {0}", i);
                Thread.Sleep(1000);
                Console.ReadKey();
            }
        }

        public static void Main()
        {
            Thread t = new Thread(ThreadMethod);
            t.IsBackground = true;
            t.Start();
        }

        #endregion
    }
}
