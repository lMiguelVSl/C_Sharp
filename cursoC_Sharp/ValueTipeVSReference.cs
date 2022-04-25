using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoC_Sharp
{
    //public class ValueTipeVSReference
    //{
    //    public static void Main(string[] args)
    //    {
    //        //tipo de valor 
    //        int index = 7;
    //        Console.WriteLine($"The index value before the plus is: {index}"); 
    //        Console.WriteLine($"The total plus is: {Sum(index)}");
    //        Console.WriteLine($"The index value after the plus is: {index}"); //al ser index un tipo de valor, no se ve afectado el valor de la variable despues de sumarle
    //        Console.ReadKey();

    //        Console.WriteLine("Now the reference tipe");
    //        Person person = new("Miguel", 21);

    //        Console.WriteLine($"Person name: {person.Name}");
    //        changeName(person);
    //        Console.WriteLine($"Person name after the method change name: {person.Name}");
    //        Console.ReadKey();

    //    }

    //    public static int Sum(int index)
    //    {
    //        return index + 4;
    //    }

    //    //tipos de referencia, todas las clases de objetos de .NET (cadenas,strings) se alojan en el monton, menos eficiente el uso de datos por la forma como se almacena
    //    public class Person
    //    {
    //        public string Name { get; set; }
    //        public int Age { get; set; }

    //        public Person(string name, int age)
    //        {
    //            Name = name;
    //            Age = age;
    //        }
    //    }
    //    public static void changeName(Person person)
    //    {
    //        person.Name = person.Name + " Changed";
    //    }
    //}
}
