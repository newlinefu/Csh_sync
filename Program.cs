using System;
using System.Threading.Tasks;

namespace AsyncSolution
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                Divide(1, 0).Wait();
            }
            catch (AggregateException e)
            {
                Console.WriteLine(e.Message);
            }
        }


        public static async Task<int> Divide(int a, int b)
        {
            return a / b;
        } 
    }
}