using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Prime_or_not
{
    internal class Program
    {
        static void Main(string[] args)
        {

            int n = 17, i;
            
            for (i = 2; i < n; i++)
            {
                if (n % i == 0)
                    break;
            }
            if (i == n)
            {
                Console.WriteLine("{0} is Prime Number", n);
            }
            else
            {
                Console.WriteLine("{0} is not a Prime Number", n);
            }
            Console.ReadLine();

           

        }
    }
}
