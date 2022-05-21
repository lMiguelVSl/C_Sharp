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
                writer.WriteStartDocument();
                writer.WriteStartElement("People");
                writer.WriteStartElement("Person");
                writer.WriteAttributeString("firstName","Miguel");
                writer.WriteAttributeString("lastName", "Vargas");
                writer.WriteStartElement("ContactDetails");
                writer.WriteElementString("EmailAddress", "vargas@hotmail.com");
                writer.WriteEndElement();
                writer.WriteEndElement();
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
