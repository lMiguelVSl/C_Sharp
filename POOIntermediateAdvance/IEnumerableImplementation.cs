using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOIntermediateAdvance
{
    public class IEnumerableImplementation
    {
        public static void IEnumerableMain()
        {
            List<int> numbers = new List<int> { 1,2,3,4,5,6,7,8,9,10}; //creo la lista de valores enteros y le agrego valores
            using (List<int>.Enumerator enumerator = numbers.GetEnumerator()) //usando una lista de tipo enteros con el metodo Enumerator perteneciente a Ienumerable
            {                                                                 //le voy a asignar el metodo GetEnumerator aplicado a la lista ya creada
                while (enumerator.MoveNext()) //mientras exista siguiente valor en la lista 
                {
                    Console.WriteLine(enumerator.Current); //vamos a escribir el valor en el que nos encontramos 
                }
            }
        }
    }
}
