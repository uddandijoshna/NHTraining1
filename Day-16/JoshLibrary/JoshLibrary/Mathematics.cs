using System;

namespace JoshLibrary
{
    public class Mathematics
    {
        int input;
        public void ReadData()
        {
            Console.WriteLine("Enter any value:");
            input = Convert.ToInt32(Console.ReadLine());

        }
        public int GetFactorial()
        {
            int fact = 1;
            for (int i = 1; i <= input; i++)
                fact *= i;
            return fact;
        }
    }
}
