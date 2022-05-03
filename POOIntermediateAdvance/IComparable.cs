using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOIntermediateAdvance
{
    public class IComparableImplementation
    {
        public static void IComparableMain()
        {
            List<OrderImplementation> orders = new List<OrderImplementation> //creola lista del tipo de objeto de la clase 
            {
                new OrderImplementation {Created = new DateTime(2020,12,1)},
                new OrderImplementation {Created = new DateTime(2020,9,2)},
                new OrderImplementation {Created = new DateTime(2020,10,3)},
                new OrderImplementation {Created = new DateTime(2020,11,4)}, //creo los items en la lista en desorden
            };
            orders.Sort(); //me ordena la lista 
            foreach (OrderImplementation item in orders) //muestro en consola cada elemento de la lista
            {
                Console.WriteLine(item.Created);
            }
        }
    }
    class OrderImplementation : IComparable //implemento la interfaz IComparable
    {
        public DateTime Created { get; set; } //creo el atributo del tipo DateTime
        public int CompareTo(object obj) //creo el metodo para comparar el objeto
        {
            if (obj == null) return 1; //si no hay ningun objeto retorno 1
            OrderImplementation o = obj as OrderImplementation; //creo el objeto del tipo de la clase le asigno el objeto que recibe as el tipo de la clase  
            if (o == null) Console.WriteLine("The object isn't the same tipe as object"); //si no lee nada es porque no es del mismo tipo del objeto 
            return Created.CompareTo(o.Created); //retorno el DateTime luego de aplicarle el mismo metodo con el objeto que compara la fecha 
        }
    }
  
}
