using System;

namespace Day_16_Project_2
{
    class Factorial
    {
        int input;
        
        public int ReadInput()
        {
            Console.Write("\n Enter any Number To Calculate It's Factorial : ");
            input = int.Parse(Console.ReadLine());
            return input;
        }
       
        public int PrintFactorial()
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
            {
                fact *= i;
            }
            return fact;
        }
    }
    
       internal class Program
    {
        static void Main(string[] args)
        {
            Factorial factorial = new Factorial();
            int input = factorial.ReadInput();
            Console.WriteLine("\nThe Factorial of {0} is :{1}\n", input, factorial.PrintFactorial());
        }
    }
}
