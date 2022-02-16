using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoshLibrary;

namespace Day_16_Project_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Mathematics m = new Mathematics();
            m.ReadData();
            Console.WriteLine(m.GetFactorial());

           
            Console.WriteLine(Physics.FinalVelocity(7, 8, 9));

            Chemistry c = new Chemistry();
            Console.WriteLine(c.GetBenzene());
            Console.WriteLine(c.GetWater());
            Console.WriteLine(c.Methane());
            Console.ReadLine();
        }
    }
}
