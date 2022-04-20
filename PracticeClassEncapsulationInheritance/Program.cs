using System;

namespace PracticeClassEncapsulationInheritance
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new("Miguelinho","0123456789","Vargas, Miguel", "Torrentio");
            ShowPublicationInfo(book);
            Console.ReadKey();

            book.Publish(new DateTime(2022,4,19));
            ShowPublicationInfo(book);
            Console.ReadKey();

            Book book2 = new ("Miguelinho", "Vargas, Miguel", "Torrentio");
            ShowPublicationInfo(book2);
            Console.WriteLine($"{book.Title} y {book2.Title} son la misma publicacion: {((Publication)book).Equals(book2)}");
            Console.ReadKey();


        }
        public static void ShowPublicationInfo(Publication pub)
        {
            string pubDate = pub.GetPublicationDate();
            Console.WriteLine($"{pub.Title},{(pubDate == "NPA" ? "No se ha publicado aun" : "Publicado el " + pubDate)} by {pub.Publisher}");
        }
    }
}