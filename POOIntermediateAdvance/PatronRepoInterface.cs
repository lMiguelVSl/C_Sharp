using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOIntermediateAdvance
{
    interface IRepository<T> //creo el repositorio con sus respectivos metodos
    {
        T FindById(int id); 
        IEnumerable<T> GetAll();
    }
    class Product //clase
    {

    }
    class Order //clase
    {

    }
    //las dos clases modelan un repositorio para cada una de las entidades, las fuentes pueden ser una base de datos un archivo ETC...
    class Products : IRepository<Product> //clase implementando el repositorio en interfaz con sus metodos
    {
        public Product FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Product> GetAll()
        {
            throw new NotImplementedException();
        }
    }
    class Orders : IRepository<Orders> //clase implementando el repositorio en interfaz con sus metodos
    {
        public Orders FindById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Orders> GetAll()
        {
            throw new NotImplementedException();
        }
    }
    public class PatronRepoInterface
    {

    }
    
}
