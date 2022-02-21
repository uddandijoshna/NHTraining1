using System;
using System.IO;
using System.Text;

namespace Project2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filePath = @"E:\NHTraining1\\FileOperations.txt";
            string TaskSchedularPath = @"E:\NHTraining1\TaskSchedularPath.txt";

            if (File.Exists(TaskSchedularPath))
                File.Delete(TaskSchedularPath);
            File.Copy(filePath, TaskSchedularPath);
            Console.WriteLine("File Copying is Done");
            Console.ReadKey();

        }
    }
}
