using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_10_Evening_Project1
{

    abstract class Salary
    {

        public int GetPF(int basic)

        { return 12 * basic / 100; }

        public int GetHRA(int basic)
        { return 40 * basic / 100; }


        public abstract int GetCA();


        public abstract int GetSA();
    }
    class Microsoft : Salary
    {
        public override int GetCA()
        {
            return 6000;
        }
        public override int GetSA()
        {
            return 7000;
        }
    }
    class Google : Salary
    {
        public override int GetCA()
        {
            return 10000;
        }
        public override int GetSA()
        {
            return 10000;
        }
    }
    class IBM : Salary
    {
        public override int GetCA()
        {
            return 4000;
        }
        public override int GetSA()
        {
            return 6000;
        }
    }
    class Facebook : Salary
    {
        public override int GetCA()
        {
            return 20000;
        }
        public override int GetSA()
        {
            return 20000;
        }
    internal class Program
        {
            static void Main(string[] args)
            {
                // Microsoft Code
                // Google Code
                // IBM Code
                // Facebook Code
                Console.WriteLine("Abstract Class Template Execution Success");
                Console.ReadLine();
            }
        }
    }
}