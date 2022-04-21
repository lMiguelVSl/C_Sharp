using QuizPOO;
using System;

namespace InheritanceExercise
{
    public class Program
    {
        public static void Main()
        {
            Employee employee = new Employee(123456, "Sergio Pérez", 40);
            Console.WriteLine("Llegue");
            Console.WriteLine(employee.GetData()); 
            Console.ReadKey();
        }
    }


}