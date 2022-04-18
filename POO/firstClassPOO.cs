using System;

namespace cursoC_Sharp
{ /*
    class firstClass_POO
    { 
        static void Main(string[] args)
        {
            PersonClass p = new PersonClass(); //apunta a un espacio de memoria
            PersonClass p1 = new PersonClass();

            p.Name = "Miguel";
            Console.WriteLine($"p name is {p.Name}");

            p1 = p; //p1 apunta al mismo espacio de memoria ya que se apunto al mismo valor de p
            Console.WriteLine($"if p1=p the p1 name is {p1.Name}");

            p1.Name = "Alejandro"; //en class al modificar el valor de una variable que apunta a otra, se cambia el valor de la propiedad para ambas
            Console.WriteLine($"P name is {p.Name} and p1 name is {p1.Name}");
            Console.ReadKey();

            Console.ForegroundColor = ConsoleColor.Green;
            PersonStruct personStruct = new PersonStruct();
            PersonStruct personStruc2 = new PersonStruct();

            Console.WriteLine("Now creating a struct object");
            personStruct.Name = "Juan pablo";
            Console.WriteLine($"the name is {personStruct.Name}");

            personStruc2 = personStruct; //le asigno las mismas propiedades a la 2 
            Console.WriteLine($"The personStruct2's name is {personStruc2.Name}");

            personStruc2.Name = "Miguelinho";
            Console.WriteLine($"The personStruct2's name is {personStruc2.Name} and the first one is {personStruct.Name}");
            Console.ReadKey();

        }
    }
    public class PersonClass
    {
        public string Name { get; set; }
        public int MyProperty { get; set; }
    }
    public struct PersonStruct
    {
        public string Name { get; set; }
    } */
}