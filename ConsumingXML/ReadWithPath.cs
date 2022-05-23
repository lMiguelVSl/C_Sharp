using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.XPath;

namespace ConsumingXML
{
    public class ReadWithPath
    {
        public static void ReadWithPathMain()
        {
            XmlDocument doc = new XmlDocument(); //created the xml document
            doc.LoadXml(File.ReadAllText("people.xml")); //charging the xmldocument that already exist
            XPathNavigator nav = doc.CreateNavigator(); //creating the path navigator into the xmlDocument
            string query = "//people/person[@firstName='Sergio']"; //query
            XPathNodeIterator iterator = nav.Select(query); //excecuting the query
            Console.WriteLine(iterator.Count); //show the size of the iterator
            while (iterator.MoveNext()) 
            {//into the values of the iterator
                string firstName = iterator.Current.GetAttribute("firstName", "");
                string lastName = iterator.Current.GetAttribute("lastName", "");
                Console.WriteLine($"Name: {firstName} {lastName}");
            }
            Console.ReadKey();
        }
    }
}
