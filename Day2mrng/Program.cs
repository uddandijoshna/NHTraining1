using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2mrng
{
    internal class Program
    {
        static void Main(string[] args)
        {
            for(int num1=1;num1<=10;num1++)
            {
                for(int num2=1;num2<=10;num2++)
                {
                    Console.WriteLine(num1 * num2 + "\t");
                }
            }
        }
    }
}
