using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoC_Sharp_POO
{ 
    class encapsulacion
    {
        static void Main(string[] args)
        {
            SampleClass p1 = new SampleClass("Miguel"); //cuando se tiene el contructor se envia como parametro el valor deseado
            // p1.  no deja ver el campo ya que es de tipo private
            
            Console.WriteLine(p1.SampleProperty);


            SampleClass person2 = new SampleClass("Juan pablo", "Valencia"); //se tiene el contructor asi que se le envian los dos parametros que pide 
            Console.WriteLine(person2.GetFullName());
        }
    }
    public class SampleClass
    {
        public SampleClass (string _sampleClass) //contructor para objetos con solo un nombre
        {
            _sampleClass = _sampleClass;
        }
        public SampleClass(string FirsName, string _secondName) //constructor para objetos con dos nombres
        {
            FirstName = FirsName;
            SecondName = _secondName;
        }
        private string _sampleClass;
        private string _secondName;
        public string FirstName { get; set; }
        public string SampleProperty //c# permite crear campos privado para almacenar el valor 
        {
            get { return _sampleClass; }
            set { _sampleClass = value; }
        }
        public string SecondName 
        {
            get { return _secondName; }
            set { _secondName = value; }

        }
        public string GetFullName() //metodo 
        {
            return $"{FirstName} {SecondName}";
        }

        //una clase puede tener una sobre carga de metodos
    }
}
