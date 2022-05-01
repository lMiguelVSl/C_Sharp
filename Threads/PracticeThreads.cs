using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Threads
{
    class PracticeThreads
    {
        static bool stopped = false; //variable compartida

       
        public static void ThreadMain()
        {
            Thread threadMethod = new Thread(new ThreadStart(ThreadMethod)); //creo el thread para dentro del mismo instanciar el metodo a ejecutar 
            threadMethod.Start(); //inicio el thread
            Console.WriteLine("Push a key to stop the ejecution");           
            Console.ReadKey(); //leo si el usuario quiere terminar el thread
            stopped = true; //modifico la variable compartida
            threadMethod.Join(); //ingreso para que la consola sepa que debe de terminar la ejecuccion 
            
        }
        public static void ThreadMethod()
        {
            int index = 0;

            while ( !stopped  || index == int.MaxValue)
            {
                  index++;
                  Console.WriteLine("Ejecuted times: {0}", index);
                  Thread.Sleep(3000); //espero 3 segundos para la ejecuccion 
            }
   
        }
    }
}
