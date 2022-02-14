using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_16_Project_1
{
    class HelloWorld
    {
        public void PrintMessage()
        {
            Console.WriteLine("Enter Hello World");
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            HelloWorld hw= new HelloWorld();
            hw.PrintMessage();

        }
    }
}
