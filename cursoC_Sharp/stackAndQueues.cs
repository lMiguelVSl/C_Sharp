using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoC_Sharp
{
    public class stackAndQueues
    {
        public static void Main(string[] args)
        {
            //pilas
            string word;
            int counter;
            Stack greetingStack;

            //usando push y pop
            Console.ForegroundColor = ConsoleColor.Green;
            greetingStack = new Stack();
            greetingStack.Push("Miguel");
            greetingStack.Push("Juan");
            greetingStack.Push("Felipe");

            counter = greetingStack.Count;
            Console.WriteLine($"La cantidad de elemntos en el stack es de {counter}");
            Console.ReadLine();

            for(int i = 0; i < counter; i++)
            {
                word = (string)greetingStack.Pop();
                Console.WriteLine($"Pop : {word}");
            }
            Console.WriteLine($"La cantidad de elementos que hay es de {greetingStack.Count}");
            Console.ReadKey();

            //usando peek
            Console.ForegroundColor = ConsoleColor.Yellow;
            greetingStack = new Stack();
            greetingStack.Push("Miguel");
            greetingStack.Push("Juan");
            greetingStack.Push("Felipe");

            counter = greetingStack.Count;
            Console.WriteLine($"La cantidad de elemntos en el stack es de {counter}");
            Console.ReadKey();

            for (int i = 0; i < counter; i++)
            {
                word = (string)greetingStack.Peek();
                Console.WriteLine($"La siguiente palabra en la fila es : {word}");

                word = (string)greetingStack.Pop();
                Console.WriteLine($"Pop : {word}");
            }
            Console.WriteLine($"La cantidad de elementos que hay es de {greetingStack.Count}");
            Console.ReadKey();


            //usando CONTAINS Y CLEAR
            Console.ForegroundColor = ConsoleColor.White;
            greetingStack.Push("Me llamo juan");
            greetingStack.Push("Yo me llamo miguel");
            greetingStack.Push("Y yo soy pablo");

            Console.WriteLine($"La cantidad de elementos en el stack es de {greetingStack.Count}");

            if(greetingStack.Contains("Yo me llamo miguel"))
            {
                greetingStack.Clear();
            }
            Console.WriteLine($"Esta es la cantidad de elementos que contiene el stack luego de clear {greetingStack.Count}");
            Console.ReadKey();


            //COLAS

            Console.ForegroundColor = ConsoleColor.Blue;
            Queue greetingQueue = new Queue();
            greetingQueue.Enqueue("Hola");
            greetingQueue.Enqueue("buenos");
            greetingQueue.Enqueue("dias");

            counter = greetingQueue.Count;
            Console.WriteLine($"Hay {greetingQueue.Count} elementos en la cola");

            for (int i = 0; i < counter; i++)
            {
                word = (string)greetingQueue.Peek();
                Console.WriteLine($"El siguiente elemento de la cola es {word}");

                word = (string)greetingQueue.Dequeue();
                Console.WriteLine($"DEQUEUE: {word}");
            }
            Console.ReadKey();
        }
    }
}
