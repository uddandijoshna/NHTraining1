using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableScope1
{
    class Program
    {
        public void display()
        {
            int j;
            for ( j = 1; j <= 3; j++)
            {

            }
            Console.WriteLine(j);
        }

        static void Main(string[] args)
        {
            Program ps = new Program();
            ps.display();

            Console.ReadLine();
        }
    }
}





