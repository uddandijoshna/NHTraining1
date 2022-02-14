using System;
using System.IO;
using System.Text;

namespace Day_15_Project_4
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StreamWriter writer = new StreamWriter(@"E:\NHTraining1\StreamWriterAppendExample.txt", true);

            writer.WriteLine("This is From New object of Stream Writer,");
            writer.WriteLine("using Append by assigning True, while creating object for StreamWriter");

            writer.Close();
            Console.WriteLine("\n Appending is done, by using Stream Writer Class, By Enabling Append Method(true).");

           
            StreamReader reader = new StreamReader(@"E:\NHTraining\StreamWriterAppendExample.txt");

            reader.ReadToEnd();

            reader.Close();
            Console.WriteLine("\n Reading is done, by using Stream Writer Class, by ReadToEnd Method.");

            Console.ReadKey();
        }
    }
}

