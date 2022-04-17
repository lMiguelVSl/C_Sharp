using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace cursoC_Sharp
{
    public class calculadora
    { /*
        public static void Main(string[] args)
        {
            double operation;
            double firstData;
            double secondData;
            Boolean repeatAction = false;
            while (!repeatAction)
            {
                Console.WriteLine("Bienvenido a tu calculadora");
                Console.WriteLine("1. Suma");
                Console.WriteLine("2. Resta");
                Console.WriteLine("3. Salir");
                operation = GetDoubleDataFromUser("Proporciona la operacion que deseas ejecutar");

                switch (operation)
                {
                    case 1:
                        firstData = GetDoubleDataFromUser("Ingresa el primer valor a operar");
                        secondData = GetDoubleDataFromUser("Ingrese el segundo valor a operar");
                        Console.WriteLine($"El resultado de la operacion {firstData} + {secondData} es = {firstData + secondData}");
                        break;

                    case 2:
                        firstData = GetDoubleDataFromUser("Ingresa el primer valor a operar");
                        secondData = GetDoubleDataFromUser("Ingrese el segundo valor a operar");
                        Console.WriteLine($"El resultado de la operacion {firstData} - {secondData} es = {firstData - secondData}");
                        break;
                    case 3:
                        Environment.Exit(0);
                        break;


                    default:
                        Console.WriteLine("La opcion seleccionada no existe.");
                        break;
                }
                Console.Read();
                Console.Clear();
            }
           

        }
        private static double GetDoubleDataFromUser(string message)
        {
            string userData;
            double data =0;
            bool isDataValid = false;
            while (!isDataValid)
            {
                Console.WriteLine(message);
                userData = Console.ReadLine();
                if (!double.TryParse(userData, out data))
                {
                    Console.WriteLine("El dato ingresado no es valido");
                } else
                {
                    isDataValid = true;
                }
            }
            return data;
        } */
    } 
}
