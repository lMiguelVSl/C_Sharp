using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoC_Sharp
{
    public class listPractice
    {
        public static void Main(string[] args)
        {
            //crear instancias de una lista
            Console.ForegroundColor = ConsoleColor.White;
            List<int> list1 = new List<int>();
            list1.Add(1);
            list1.Add(2);
            list1.Add(3);
            list1.Add(4);
            list1.Add(5);
            list1.Add(6);
            list1.Add(7);
            ShowListContain(list1);
            Console.ForegroundColor = ConsoleColor.Yellow;
            if (list1.Contains(7))
            {
                list1.Remove(6);
                Console.WriteLine("Se removio el numero 6");

            }
            Console.ReadKey();
            ShowListContain(list1);

            Console.ForegroundColor = ConsoleColor.Blue;
            if (!list1.Contains(6))
            {
                list1.Insert(5,6);
                Console.WriteLine("Se agrego el numero 6");

            }
            Console.ReadKey();
            ShowListContain(list1);

            //lista inicializada con datos
            Console.ForegroundColor = ConsoleColor.Magenta;
            List<int> list2 = new List<int>() { 100, 200, 300, 400, 500 };
            ShowListContain(list2);
            Console.ReadKey();

            //para insertar una lista en la posicion proporcionada de otra lista
            Console.ForegroundColor = ConsoleColor.Red;
            list2.InsertRange(0, list1);
            ShowListContain(list2);
            Console.ReadKey();

        }

        public static void ShowListContain(List<int> list)
        {
            Console.WriteLine("Los valores en la lista son: ");
            foreach (int item in list)
            {
                Console.WriteLine(item);
            }

        }



    }
}
