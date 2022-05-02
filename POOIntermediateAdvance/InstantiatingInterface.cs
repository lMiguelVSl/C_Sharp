using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOIntermediateAdvance
{
    interface IAnimal 
    {
        void Move();
    }
    class Dog : IAnimal //implementacion de una interfaz 
    {
        public void Move(){}
        public void Bark() { }
    }
  
    class InstantiatingInterface
    {
        static void InstantiatingMain()
        {
            IAnimal animal = new Dog(); //forma de instanciar una intefaz mediante otro tipo de objeto completo 
            //no se puede llamar a los metodos agreagados dentro de la clase que apunta en este caso Dog osea los que no heredo de la Interface
            //para utilizarlos hay que castear el objeto o convertirlo
            void MoveAnimal(IAnimal animal)
            {
                animal.Move();
            }
        }
    }
}
