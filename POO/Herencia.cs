using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoC_Sharp_POO
{
    public class Herencia
    {
        //cada clase debe de contar con sus propios constructores y finalizadores
        static void Main(string[] args)
        {
            A.B b = new A.B(); //creo un objeto de la clase base y la heredada
            Console.WriteLine(b.getValue()); //llamo el metodo getValue para el objeto o instancia creado de A.B
            // b.value no se permite obtener ya que es un valor privado, solo para el mismo bloque de clase
            D test = new D();
            //D.valur; no permite el acceso ya que es protegido y solo es para las clases derivadas
        }
    }
    public class A
    {
        private int value = 10; //variable private
        public class B : A //creo la classe B heredada de A
        {
            public int getValue() //creo elmetodo para obtener el valor
            {
                return this.value; //retorno el valor privado de la misma clase(por esto lo puedo manejar)
            }
           
        }
        //metodo Virtual
        public virtual void VirtualMethod()
        {
            //codigo
        }
        public void NotVirtualMethod()
        {
            //codigo
        }
    }

    public class C : A
    {
        //invalidar un metodo virtual
        public override void VirtualMethod()
        {
            //codigo que sustituye al codigo base   
        }
        //invalidar un metodo no virtual
        //public override void NotVirtualMethod() no permite sustituir ya que el metodo es no virtual
       // {
            //codigo que sustituye el metodo base
       // }
        //metodo para variable private
        public int getValue()
        {
            // return this.value; no permite acceder a value ya que es privado de la clase A
            return 0;
        }
    }
    public class D
    {
        protected int valur = 10; //protected solo permite el acceso desde las clases derivadas
    }
    public class E : D
    {
        public int getValue()
        {
            return valur; //permite obtener el valor ya que es protegido y es para las clases derivadas
        }
    }

}
