using ClientApp.ServiceReference1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClientApp
{
    internal class Program
    {
        static void Main(string[] args)
        {
            WebService1SoapClient obj = new WebService1SoapClient();
            Console.WriteLine( obj.Add(6,7));
            Console.WriteLine( obj.Mul(8,9));
            Console.WriteLine( obj.Div(10,11));
            Console.WriteLine(obj.Factorial(5));
            Console.ReadLine();

        }
    }
}
