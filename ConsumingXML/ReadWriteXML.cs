using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace ConsumingXML
{
    public class ReadWriteXML
    {
        public static void ReadWriteMain()
        {
            XmlDocument xmlDoc = new XmlDocument();
            xmlDoc.LoadXml(File.ReadAllText("people.xml"));
            XmlNodeList nodes = xmlDoc.GetElementsByTagName("person");
            //output the people's name in the xml
            foreach (XmlNode node in nodes)
            {
                string firsName = node.Attributes["firstName"].Value;
                string lastName = node.Attributes["lastName"].Value;
                Console.WriteLine($"First Name: {firsName}, last Name: {lastName}");
            }
            Console.ReadKey();

            //star creating a new node
            XmlNode newNode = xmlDoc.CreateNode(XmlNodeType.Element, "person","");
            XmlAttribute firstNameAttribute = xmlDoc.CreateAttribute("firstName");
            firstNameAttribute.Value = "Miguel";
            XmlAttribute lastNameAttribute = xmlDoc.CreateAttribute("lastName");
            lastNameAttribute.Value = "Vargas";
            newNode.Attributes.Append(firstNameAttribute);
            newNode.Attributes.Append(lastNameAttribute);
            xmlDoc.DocumentElement.AppendChild(newNode);
            Console.WriteLine("Modified XML...");
            xmlDoc.Save(Console.Out);
            Console.ReadKey();
        }
        
    }
}
