using System;



namespace RecordTypeExample
{
    public class Program
    {
        static void Main(string[] args)
        {
            Pet myDog = new("Apolo", 1);
            Pet yourDog = new("Apolo", 1);
            Console.WriteLine($"My dog is your dog?  {myDog == yourDog}");
            Console.ReadKey();
        }
    }
    //record si toma en cuenta los valores , cuando se imprime el objeto, muestra no el tipo del objeto como las clases si no que muestra los valores de sus atributos
    public record Pet //se utiliza el tipo record en vez de clase, en este caso si iguala los dos objetos con los mismos valores en sus atributos
    { //record por referencia (public record Pet), si se quiere hacer por valor es (Public record struct Pet)
        //
        public string Name { get; set; }
        public int Age { get; set; }

        public Pet(string name, int age)
        {
            Name = name;
            Age = age;
        }
    }
}
