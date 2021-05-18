using System;
using System.Linq;
using System.Threading.Tasks;

namespace AsyncSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            int totalCount = 150;
            var users = User.CreateUsers(totalCount);

            var firstPart = users.Take(totalCount / 3).ToList();
            var secondPart = users.Skip(totalCount / 3).Take(totalCount / 3).ToList();
            var thirdPart = users.Skip(2 * totalCount / 3).Take(totalCount / 3).ToList();

            var manager = new MonitorManager();
            Parallel.Invoke(
                () => manager.DoWork(firstPart),
                () => manager.DoWork(secondPart),
                () => manager.DoWork(thirdPart)
            );
        }
    }
}