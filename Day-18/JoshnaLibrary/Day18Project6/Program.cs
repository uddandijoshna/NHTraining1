﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoshnaLibrary;


namespace Day18Project6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter Any Number : ");
            int n = int.Parse(Console.ReadLine());
            Console.WriteLine("\n\n Factorial Result is : {0}", Algebra.Factorial(n));
            Console.ReadLine();
        }
    }
}
