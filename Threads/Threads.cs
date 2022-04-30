using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace cursoC_Sharp
{
    public class Threads
    {
        //la mejor forma de detener un threas es con una variable compartida a la que puedan acceder los dos hilos
        public static void Main(string[] args)
        {
            
        }
        public static void ThreadsIntro()
        {
            Boolean stopped = false; //variable compartida
            Thread t = new Thread(ThreadMethod);
            t.Start(5); //se pasa el valor 5 a nuestro metodo de trabajo
            t.Join(); //hace que la app de consola espere hasta que el thread termine de ejecutarse
            Console.Read();


            //ejemplo con la variable compartida
            Thread thread = new Thread(new ThreadStart(() => //expresion lambda para ser una version abreviada de un delegado
            {
                while (!stopped) //acceso del hilo objetido a la variable 
                {
                    Console.WriteLine("Corriendo...");
                    Thread.Sleep(1000);
                }
            }));
            thread.Start();
            Console.WriteLine("Presione una tecla para salir");
            Console.ReadKey(); //se captura una tecla para pasar al tru stopped para que salga del while
            stopped = true; //hilo de llamada
            t.Join(); //hace que la app de consola espere hasta que el hilo termine de ejecutarse 
        }
        public static void ThreadMethod(object o)
        {
            for (int i = 0; i < (int)o; i++) //se convierte el valor al tipo esperado para poder usarlo (int) conversion explicita
            {
                Console.WriteLine($"Hilo de proceso: {i}");
                Thread.Sleep(0);
            }
        }
        //para detener el hilo se usa abort(), puede interrupir en cualquier punto pero hace que la app quede en estado corrupto
    }
}
