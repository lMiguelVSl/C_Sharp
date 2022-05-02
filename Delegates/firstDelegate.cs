using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Delegates
{
    class Delegates
    {
        public delegate int Calculate(int x, int y); //creo el delegado
        public static int Add(int x, int y){return x+y ;} //creo los metodos a utilizar con el delegado
        public static int Multiply(int x, int y) { return x * y; }//creo los metodos a utilizar con el delegado
        public static void UseDelegate()
        {
            Calculate calc = Add;//creo el delegado y le asigno como valor el metodo 
            Console.WriteLine("The result of {0} + {1} is: " + calc(3, 4),3,4); //al delegado le asigno los valores necesarios ya que le asignamos un metodo con dos atributo
            calc = Multiply; //le asigno el segundo metodo al delegado 
            Console.WriteLine("The result of {0} * {1} is: " + calc(3, 4),3,4);
        }
    }

  
}
