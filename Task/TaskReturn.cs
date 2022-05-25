using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class TaskReturn
    {
        public static void TaskReturnMain()
        {
            Task<int> t = Task.Run(() =>
            {
                return 22;
            });
            Console.WriteLine(t.Result);
            Console.ReadKey();
        }
      
    }
}
