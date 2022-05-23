using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsumingXML
{
    public class CreatingXML
    {
        static void CreatingXMLMain()
        {
            StringWriter stream = new StringWriter(); 
            using (XmlWriter writer = XmlWriter.Create(stream, new XmlWriterSettings() { Indent=true}))
            {
                writer.WriteStartDocument(); //document head 
                writer.WriteStartElement("People"); //primer nodo
                writer.WriteStartElement("Person"); //nodo dentro del primer nodo
                writer.WriteAttributeString("firstName","Miguel"); //nombre y valor del atributo
                writer.WriteAttributeString("lastName", "Vargas"); //nombre y valor del atributo
                writer.WriteStartElement("ContactDetails"); //elemento dentro del nodo
                writer.WriteElementString("EmailAddress", "vargas@hotmail.com"); //string dentro del elemento
                writer.WriteEndElement();
                writer.WriteEndElement(); //cierro los nodos
                writer.Flush();
            }
            Console.WriteLine(stream.ToString()); 
            Console.ReadKey();
        }
        public static void CallingCreating()
        {
            CreatingXMLMain();
        }
    }

	
    
}
