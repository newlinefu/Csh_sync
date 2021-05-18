using System;
using System.Threading;

namespace AsyncSolution
{
    public class MutexManager : Manager
    {
        private Mutex _mutex;

        public MutexManager()
        {
            _mutex = new Mutex();
        }
        
        public override void ProcessLog()
        {
            _mutex.WaitOne();
            _counter++;
            Console.WriteLine(_counter);
            _mutex.ReleaseMutex();
        }
    }
}