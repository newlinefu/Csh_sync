using System;
using System.Collections.Generic;
using System.Threading;

namespace AsyncSolution
{
    public abstract class Manager
    {
        protected int _counter;

        public Manager()
        {}

        public void DoWork(List<User> users)
        {
            foreach (var singleUser in users)
            {
                Console.WriteLine(singleUser);
                Thread.Sleep(100);
                ProcessLog();
            }
        }

        public abstract void ProcessLog();
    }
}