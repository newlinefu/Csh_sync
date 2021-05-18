using System;
using System.Collections.Concurrent;
using System.Threading;

namespace AsyncSolution
{
    class Program
    {
        private static ConcurrentStack<int> cs;

        static Program()
        {
            cs = new ConcurrentStack<int>();
        }
        
        static void Main(string[] args)
        {
            var t1 = new Thread(Print);
            var t2 = new Thread(Fill);

            t1.Start();
            t2.Start();

            t1.Join();
            t2.Join();
        }

        private static void Fill()
        {
            for (int i = 1; i < 10; i++)
            {
                cs.Push(i);
            }
        }

        private static void Print()
        {
            for (int i = 0; i < cs.Count; i++)
            {
                cs.TryPop(out int res);
                Console.WriteLine(res);
            }
        }
    }
}