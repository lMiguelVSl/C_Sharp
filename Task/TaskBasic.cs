using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tasks
{
    public class TaskBasic
    {
        public static void TaskBasicMain()
        {
            Task t = Task.Run(() => //creacion de la tarea con lambda expresion
            {
                for (int i = 0; i < 10000; i++)
                {
                    Console.WriteLine('x');
                }
            });
            t.Wait();
        }
    }
}
