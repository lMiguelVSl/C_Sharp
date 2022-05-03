using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace POOIntermediateAdvance
{
    public class IDisposablePractice
    {   
		public static void IDisposableMain()
        {
            TextReader textReader = null; //tipo texreader para leer un archivo

            try
            {
                textReader = new StreamReader(@"Files/text.txt"); //adquirimos el recurso usando el streamreader para leer el archivo con la ubicacion del mismo
                string text = textReader.ReadToEnd(); //leemos el contenido y se asigna a un string
                Console.WriteLine(text); //mostramos el texto leido en consola
            }
            catch (Exception ex)
            {
                Console.ForegroundColor = ConsoleColor.Red; //consola en rojo
                Console.WriteLine(ex.Message); //si existe algun error lo mostramos en la consola 
            }
            finally //en este bloque liberamos los recursos adquiridoa validando que no sea null y usando el metodo dispose que liberara los recursos
            { //otra forma de liberar recursos es usando using ya que viene en el mismo bloque y se omite el bloque finally --------- importante 
                if (textReader != null)
                {
                    textReader.Dispose(); //aplicamos el metodo
                }
                Console.ReadKey();
            }
        }
    }
     
}
