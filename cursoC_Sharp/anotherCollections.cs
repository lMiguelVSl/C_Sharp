using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoC_Sharp
{
    public class anotherCollections
    {
        public static void Main(string[] args)
        {
            //HashSet no permite el ingreso de objetos repetidos
            Console.ForegroundColor = ConsoleColor.Red;
            HashSet<string> list = new HashSet<string>() { "a","b","c","a"};
            foreach (var item in list)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            //sortSet organiza una lista ascendentemente
            Console.ForegroundColor = ConsoleColor.Yellow;
            SortedSet<string> sorteSet = new SortedSet<string>() { "d", "b", "a", "c" };
            foreach (var item in sorteSet)
            {
                Console.WriteLine(item);
            }
            Console.ReadKey();

            //disctionary es una lista co llave y calor por item
            Console.ForegroundColor= ConsoleColor.Green;
            Dictionary<string, double> fruitCost = new Dictionary<string, double>(); //lista tipo dictionary se declara con los tipos de datos de los indicadores
            fruitCost.Add("Mango",4000);
            fruitCost.Add("Manzana",1500);
            fruitCost.Add("Banano",1000);
            fruitCost.Add("Fresa",400);
            foreach (var item in fruitCost) //var para que se acople al tipo de dato o con KeyValuePair<tipo,tipo> item in fruitCost
            {
                Console.WriteLine(item);
            }
            Console.WriteLine($"El precio de la manzana es de {fruitCost["Manzana"]}"); //para buscar un dato en especifico con el nombre
            Console.ReadKey();

            //sortedList es un dictionary pero ordenado
            Console.ForegroundColor = ConsoleColor.Blue;
            SortedList<string, double> fruitCostSorted = new SortedList<string, double>(); //lista tipo dictionary se declara con los tipos de datos de los indicadores
            fruitCostSorted.Add("Mango", 4000);
            fruitCostSorted.Add("Manzana", 1500);
            fruitCostSorted.Add("Banano", 1000);
            fruitCostSorted.Add("Fresa", 400);
            foreach (var item in fruitCostSorted) //var para que se acople al tipo de dato o con KeyValuePair<tipo,tipo> item in fruitCost
            {
                Console.WriteLine(item);
            }

        }
    }
}
