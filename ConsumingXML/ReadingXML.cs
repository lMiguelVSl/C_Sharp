using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsumingXML
{
    public class ReadingXML
    {
        public static void ReadingXMLMain()
        {
            using (XmlReader xmlReader = XmlReader.Create("people.xml", new XmlReaderSettings() { IgnoreWhitespace = true }))
            {
                xmlReader.MoveToContent(); //vamos hacia el contenido
                xmlReader.ReadStartElement("people"); //leemos dentro del elemento people
                string firstName = xmlReader.GetAttribute("firstName"); //atributo
                string lastName = xmlReader.GetAttribute("lastName"); //atributo
                Console.WriteLine($"Person FirstName: {firstName} \n" +
                                $"Person lastName: {lastName}"); //se imprimen

                xmlReader.ReadStartElement("person"); //go into person element
                Console.WriteLine("Contact Details");
                xmlReader.ReadStartElement("contactdetails"); //read the element into the person 

                string emailAddress = xmlReader.ReadString();
                Console.WriteLine($"Email: {emailAddress}");

            }
            Console.ReadKey();
        }
    }
}
