
if (args.Length < 2)
{
    Console.WriteLine("Please run the program with the next order: ConsoleIOExample entrada.txt salida.txt");
    return;
}

try
{
    //we try open the output file to write
    using(var writer = new StreamWriter(args[1])) //args 1 es para el archivo de salida por eso se usa Writer
    {
        //arg 0 es a la entrada por eso se lee con Reader 
        using(var reader = new StreamReader(args[0])) //palabra clave using es para el manejo de objetos en memoria, al declararse se eliminan al terminar la seccion 
        {
            //Redirection the standart output to file
            Console.SetOut(writer); //se establece que la salida sea writer y no  la estandar (pantalla)
            //Redirection the standart input to file
            Console.SetIn(reader); //ayuda a que la entrada estandar sea un archivo reader
            string line;
            while ((line = reader.ReadLine()) != null) //se lee de consola todo elarchivo por lineas
            {
                string newLine = line.Replace("", "\t"); //se reemplazan todos los espacios por tabuladores 
                Console.WriteLine(newLine); //como la consola ya esta redireccionada al archivo de salida, lo escribe en el 
            }
        } //se elimina reader
    } //se elimina writer al tener la palabra clave using
}
catch (Exception e)
{
    TextWriter errorWriter = Console.Error;
    errorWriter.WriteLine(e.Message);
    return;
}

var standardOutPut = new StreamWriter(Console.OpenStandardOutput()); //creamos la salida normal del output (estandar) , stringWriter
standardOutPut.AutoFlush = true;
Console.SetOut(standardOutPut);
Console.WriteLine($"Se ha sustituido por tabuladores exitosamente en {args[0]}.");
return;
