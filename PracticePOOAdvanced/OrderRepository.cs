using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePOOAdvanced
{
    class OrderRepository : Repository<Order> //al heredar de repository la clase orderrepository ahora tiene un metodo para encontrar un pedido por Id 
    {
        public OrderRepository(IEnumerable<Order> orders) : base(orders) { } //se lama el constructor de la clase base 
        public IEnumerable<Order> FilterOrdersOnAmount(decimal amount) //se crea el metodo especifico para filtrar por monto 
        {
            List<Order> result = base._elements.Where(e => e.Amount == amount).ToList();
            return result;
        }
    }
}
