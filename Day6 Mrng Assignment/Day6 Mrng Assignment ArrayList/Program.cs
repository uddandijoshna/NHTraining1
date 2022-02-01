using System;
using System.Collections;
namespace Day6_Mrng_Assignment_ArrayList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sum = 0;
            ArrayList data = new ArrayList();

            data.Add(10);
            data.Add(9);
            data.Add(8);
            data.Add(7);
            data.Add(6);
            foreach(var d in data)
            {
                sum = sum + (int)d;
            }
            Console.WriteLine(sum);
            Console.ReadLine();
            }


        }
    }

