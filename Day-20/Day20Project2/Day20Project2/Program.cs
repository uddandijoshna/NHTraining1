using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day20Project2
{
    public delegate void MyCaller(int a, int b);
    internal class Program
    {
        public static void Add(int a, int b)
        {
            Console.WriteLine(a + b);
        }
        public static void Mul(int a, int b)
        {
            Console.WriteLine(a * b);
        }
        public static void Div(int a, int b)
        {
            Console.WriteLine(a / b);
        }

        static void Main(string[] args)
        {

            MyCaller mc = new MyCaller(Add);
            mc += Mul;
            mc += Div;

            mc(7, 8);

            mc(14, 15);

            mc(23, 24);

            Console.ReadLine();
        }

    }
}

          

