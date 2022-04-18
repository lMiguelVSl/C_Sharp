using System;

namespace cursoC_Sharp
{
    class firstClass_POO
    {
        static void Main(string[] args)
        {
            PersonClass p = new PersonClass();
            PersonClass p1 = new PersonClass();

            p.Name = "Miguel";
            Console.WriteLine(p1.Name);

            p1 = p;
            Console.WriteLine(p1.Name);

            p1.Name = "Alejandro";
            Console.WriteLine($"P name is {p.Name} and p1 name is {p1.Name}");
        }
    }
    public class PersonClass
    {
        public string Name { get; set; }
        public int MyProperty { get; set; }
    }
}