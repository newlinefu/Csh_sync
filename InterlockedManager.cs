using System.Threading;

namespace AsyncSolution
{
    public class InterlockedManager : Manager
    {
        public override void ProcessLog()
        {
            Interlocked.Increment(ref _counter);
        }
    }
}