using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoC_Sharp
{
    public class implicitExplicitConversions
    {
        public static void Main(string[] args)
        {
            //implicita o ampliacion decimal = integer, pierde precision pero no pierde datos
            //los compiladores manejan la conversion de manera implicita sin un conversor explicito
            byte byteValue = 16;
            short shortValue = -1024;
            int intValue = -1034000;
            long longValue = 1152921504606846976;

            decimal decimalValue; //variable en la cual se van a generar las conversiones implicitas

            decimalValue = byteValue; 
            Console.WriteLine($"After bring a value {byteValue.GetType().Name}, the decimal value is {decimalValue}.");

            decimalValue = shortValue;
            Console.WriteLine($"After bring a value {shortValue.GetType().Name}, the decimal value is {decimalValue}.");

            decimalValue = intValue;
            Console.WriteLine($"After bring a value {intValue.GetType().Name}, the decimal value is {decimalValue}.");

            decimalValue = longValue;
            Console.WriteLine($"After bring a value {longValue.GetType().Name}, the decimal value is {decimalValue}.");

            Console.ReadKey();


            //conversiones explicitas o de restriccion, creacion de un valor a partir del valor de un tipo existente que tiene un intervalo mayor qu el tipo destino
            //puede producir una perdida de datos, el compilador lo pide por una funcion convert Explicita

            long num1 = int.MaxValue + 20L;
            uint num2 = int.MaxValue - 1000;
            ulong num3 = int.MaxValue;

            int intNumber;


            try
            {
                intNumber = checked((int)num1);//checked es para la comprobacion de desbordamiento, conversion explicita es el (int)
                Console.WriteLine($"After bring a value {num1.GetType().Name}, the decimal value is: {intNumber}");
            }
            catch (OverflowException) //debe de existir la excepcion ya que le asignamos un valor que excede el limite de long  
            {
                if (num1 > int.MaxValue)
                    Console.WriteLine($"Failed convertion {num1} exceed {int.MaxValue}");
                else 
                    Console.WriteLine($"Failed convertion {num1} is less {int.MinValue}");
            }


            try
            {
                intNumber = checked((int)num2);
                Console.WriteLine($"After bring a value {num2.GetType().Name}, the decimal value is: {intNumber}");
            }
            catch (OverflowException)
            {            
                    Console.WriteLine($"Failed convertion {num2} exceed {int.MaxValue}");              
            }


            try
            {
                intNumber = checked((int)num3);
                Console.WriteLine($"After bring a value {num3.GetType().Name}, the decimal value is: {intNumber}");
            }
            catch (OverflowException)
            {   
                    Console.WriteLine($"Failed convertion {num3} exceed {int.MaxValue}");               
            }
        }
    }
}
