using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoshhLibrary;
using PublicLibrary;



namespace ClientApp
{
    public class program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();

            m.ReadData();

            Console.WriteLine(m.GetFactorial());



            Console.WriteLine(Physics.FinalVelocity(7, 8, 9));



        }
    }
}
