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


            //star creating a new node

        }
        
    }
}
