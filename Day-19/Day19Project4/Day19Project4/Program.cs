using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;

namespace Day19Project4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("\nEnter Any ID Number from 1- 10, To find the Product : ");
            int input = int.Parse(Console.ReadLine());

            XmlDocument doc = new XmlDocument();
            doc.Load(@"E:\NHTraining1\Day-18\Attribute Text Document.XML");
            var Tv = doc.GetElementsByTagName("Tv")[input - 1].Attributes["Name"].Value;
            Console.WriteLine(Tv);
            Console.ReadLine();
        }
    }
}
