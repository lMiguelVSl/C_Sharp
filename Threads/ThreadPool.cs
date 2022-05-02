using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    public class ThreadPool
    {
        public static void ThreadPoolMain() 
        {
            ThreadPool.QueueUserWorkItem((s) =>
            {
                Console.WriteLine("Working a thread in a ThreadPool");
            }
            );
            Console.ReadLine();
        }
    }
}
