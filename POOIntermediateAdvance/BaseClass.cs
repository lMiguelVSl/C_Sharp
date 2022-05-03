using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOIntermediateAdvance
{
    //mejor terminologia para la herencia (Clase base y clase derivada) para no complicarse en la herencia multiple 
    public class BaseClass
    {
        interface IEntity //se crea la interfaz
        {
            int Id { get; } //atributo generico que deben implementar todos los que implementen la interfaz
        }
        class Repository<T> where T : IEntity //se crea la calse generica y el tipo generico debe heredar de la interfaz ( where T:IEntity)
        {
            protected IEnumerable<T> _elements;
            public Repository(IEnumerable<T> elements) //contructor recibe una coleccion de elementos genericos que ya se asignaron al campo elements
            {
                _elements = elements; //asignacion
            }
            public T FindById(int id) //metodo para buscar entidades por Id, metodo generico 
            {
                return _elements.SingleOrDefault(e => e.Id == id);
            }
        }

        class Order : IEntity //heredar de una clase 
        {
            public int Id { get; }
        }
        class OrderRepository : Repository<Order> //al heredar de repository la clase orderrepository ahora tiene un metodo para encontrar un pedido por Id 
        {
            public OrderRepository(IEnumerable<Order> orders)
            : base(orders) { } //se lama el constructor de la clase base 
            public IEnumerable<Order> FilterOrdersOnAmount(decimal amount) //se crea el metodo especifico para filtrar por monto 
            {
                List<Order> result = null;
                return result;
            }
        }
    }
}
