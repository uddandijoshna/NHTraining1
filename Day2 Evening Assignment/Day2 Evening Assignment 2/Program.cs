using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day2_Evening_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int n, sum = 0;
            Console.WriteLine("Enter Any  Positive Number : ");
            n = int.Parse(Console.ReadLine());
            int i = 1;
            while(i<=n)
            {
                sum = sum + i;
                i++;
            }
            Console.WriteLine(" The Sum of Natural Numbers = " + sum);
            Console.ReadLine();
            }
    }
}
