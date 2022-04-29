using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoC_Sharp
{
    public class DelegateAndLambda
    {
        public void Main(string[] args) //con las expresiones lambda vienen desde c# version 3, las expresiones lambda son solo una forma de expecificar un delegado
        { //la sintaxis es mas sencilla a difernecia se pueden asignar directamente
            List<int> list = new List<int>();

            for (int i = 1; i <= 100; i++)
            {
                list.Add(i);
            }

            List<int> result = list.FindAll(i => i % 2 == 0); //expresion lambda, sintaxis comoda para los delegados  

            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            Console.Read();


            //public static void Main(string[] args) delegado
            //{
            //    List<int> list = new List<int>();

            //    for (int i = 1; i <= 100; i++)
            //    {
            //        list.Add(i);
            //    }

            //    List<int> result = list.FindAll(
            //      delegate (int no) cuerpo del delegado 
            //      {
            //          return (no % 2 == 0);
            //      }
            //    );

            //    foreach (var item in result)
            //    {
            //        Console.WriteLine(item);
            //    }

            //    Console.Read();
            //}
        }

    }
}
