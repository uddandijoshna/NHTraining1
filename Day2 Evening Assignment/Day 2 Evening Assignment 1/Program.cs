using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_2_Evening_Assignment
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i, fact=1, number;
            Console.Write("Enter any Number:");
            number = int.Parse(Console.ReadLine());
            for (i = 1; i <= number; i++)
            {
                fact = fact * i;
            }
            Console.WriteLine("Factorial of" + number + "is:" + fact);

        }
    }
}
