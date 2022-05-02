using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOIntermediateAdvance
{
    public class DesingImplementationInterfaces
    {
        public static void InterfaceImplementacion()
        {
           ExampleImplementation exampleImplementation = new ExampleImplementation();
            Console.WriteLine(exampleImplementation.GetResult());
            Console.ReadKey();
        }

    }
    interface IExample //diseno de la interfaz
    {
        string GetResult(); //metodo
        int Value { get; set; } //prop
        event EventHandler ResultRetrieved; //evento
        int this[string index] { get; set; } //indexador
    }
    class ExampleImplementation : IExample //implementacion de la interfaz en la clase ExampleImplementation
    {
        public int this[string index] { 
            get
            {
                return 42;
            }
            set
            {

            }
        }

        public int Value { get; set; }

        public event EventHandler ResultRetrieved;
        public event EventHandler CalculationPerformed; //nuevo evento agregado a la implementacion 

        public string GetResult()
        {
            return "result";
        }
    }
}
