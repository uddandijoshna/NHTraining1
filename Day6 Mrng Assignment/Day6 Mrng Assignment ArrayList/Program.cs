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
            data.Add(20);
            data.Add(30);
            data.Add(40);
            data.Add(50);

            {
                sum = sum + Convert.ToInt32(data.Count);
            }
            Console.WriteLine($"Sum of data is {sum}");
            Console.ReadLine();
            }


        }
    }

