using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticePOOAdvanced
{
    class Repository<T> where T : IEntity //se crea la calse generica y el tipo generico debe heredar de la interfaz ( where T:IEntity)
    {
        protected IEnumerable<T> _elements;
        public Repository(IEnumerable<T> elements) //contructor de la clase recibe una coleccion de elementos genericos que ya se asignaron al campo elements
        {
            _elements = elements; //asignacion
        }
        public T FindById(int id) //metodo para buscar entidades por Id, metodo generico 
        {
            return _elements.SingleOrDefault(e => e.Id == id);
        }
    }
}
