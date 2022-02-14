using System;
using System.IO;
using System.Text;

namespace Day_15_Project_3
{
    internal class Program
    {
        static void Main(string[] args)
        {

            StreamWriter sw = new StreamWriter(@"E:\NHTraining1\StreamWriterExample.txt");
            sw.WriteLine("Hi this is Joshna");
            sw.WriteLine("This is a File Operation using StreamWriter with WriteLine Method");
            sw.Close();
            Console.WriteLine("\n Writing File Is done, by using Stream Writer Class by writeLine Method.\n");


            
            StreamWriter writer = new StreamWriter(@"E:\NHTraining1\StreamWriterAppendExample.txt", true);

            writer.WriteLine("This is From New object of Stream Writer,");
            writer.WriteLine("using Append by assigning True, while creating object for StreamWriter");
            writer.Close();
            Console.WriteLine("\n Appending is done, by using Stream Writer Class, By Enabling Append Method(true).");

            Console.ReadKey();
        }
    }
}

        

