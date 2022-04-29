using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoC_Sharp
{
    public class ThreadStatic
    {
        [ThreadStatic]
        public static int _field; //creo el thread static 
        public static void Main()
        {
            new Thread (()=> //utilizo el delegado con una expresion lambda 
            {
                for (int i = 0; i < 10; i++) 
                {
                    _field++;
                    Console.WriteLine($"Hilo A: {_field}"); //muestro el valor que se ha almacenado hasta el thread durante las 10 ejecuciones
                }
            }).Start(); //comienzo el thread
            new Thread (()=>
            {
                for (int i = 0; i < 10; i++)
                {
                    _field++;
                    Console.WriteLine($"Hilo B: {_field}"); //muestro el valor durante las ejecucciones en un thread diferente 
                }
            }).Start ();
            Console.ReadKey(); //en este caso cada hilo ejecutado paralelamente llega hasta 10 al estar con un atributo threadStatic en el principio, si se elimina el atribto ambos llegan al mismo valor 
            // y llegan hasta 20 ya que no son staticos por cada ejecuccion 
        }
    }
}
