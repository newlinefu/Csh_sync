using System;
using System.Diagnostics;
using System.Threading;
using System.Threading.Tasks;

namespace AsyncSolution
{
    class Program
    {
        
        // private Int32 m_flag = 0;
        // private Int32 m_value = 0;
        private static Boolean s_stopWorker = false;
        
        static void Main(string[] args)
        {
            // Ни один из примеров Рихтера по volatile не дал должного эффекта
            // Также не сработали и сторонние примеры с форумов.
            // Либо это связано с тем, что оптимизации у моего компилятора не предусмотрена, либо с тем, что
            // проблемы, илюстрируемые Рихтером были частично устранены. Программа компилируется с х64 jit-ом
            
            
            
            Console.WriteLine(Environment.Is64BitProcess);
            
            Console.WriteLine("Main: letting worker run for 5 seconds");
            Thread t = new Thread(Worker);
            t.Start();
            Thread.Sleep(5000);
            s_stopWorker = true;
            Console.WriteLine("Main: waiting for worker to stop");
            t.Join();
            
            // Program p = new Program();
            // new Thread(p.Thread2).Start();
            // new Thread(p.Thread1).Start();
        }
        
        private static void Worker(Object o) {
            Int32 x = 0;
            while (!s_stopWorker) x++;
            Console.WriteLine("Worker: stopped when x={0}", x);
        }
        
        // public void Thread1() {
        //     m_value = 5;
        //     m_flag = 1;
        // }
        // public void Thread2() {
        //     if (m_flag == 1)
        //         Console.WriteLine(m_value);
        // }
    }
}