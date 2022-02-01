using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day6_Mrng_Assignment__List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> intList = new List<int>() { 1, 2, 3, 4 };
            int sum = intList.Aggregate((x, y) => x + y);
        }
    }
}