using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19Project3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            XmlDocument doc = new XmlDocument();
            doc.Load(@"E:\NHTraining1\Day-18\TagBased.xml");
            foreach (XmlNode node in doc.DocumentElement.ChildNodes)
            {
                foreach (XmlNode childNode in node.ChildNodes)
                {
                    if (childNode.Name == "ID")
                    {
                        Console.Write("{0}, ", childNode.InnerText);
                    }
                    if (childNode.Name == "Name")
                    {
                        Console.Write("{0}, ", childNode.InnerText);
                    }
                    if (childNode.Name == "Price")
                    {
                        Console.Write("{0}\n", childNode.InnerText);
                    }
                }
            }
            Console.ReadLine();
        }
    }
}
