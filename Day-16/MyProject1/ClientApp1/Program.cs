using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoshhLibrary;
using PublicLibrary;

namespace ClientApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Mathematics m = new Mathematics();

            

            Console.WriteLine(Mathematics.Factorial(5));



            Console.WriteLine(Physiscs.FinalVelocity(7, 8, 9));
        }
    }
}
