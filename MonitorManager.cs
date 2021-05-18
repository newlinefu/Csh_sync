using System;
using System.Threading;

namespace AsyncSolution
{
    public class MonitorManager : Manager
    {
        private object _locker;

        public MonitorManager()
        {
            _locker = new object();
        }
        
        public override void ProcessLog()
        {
            lock (_locker)
            {
                _counter++;
                Console.WriteLine(_counter);
            }
        }
    }
}