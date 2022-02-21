using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VariableScope
{
    class Program
    {
        // class level variable
        string str = "Class Level";

        public void display()
        {
            Console.WriteLine(str);
        }
          
    static void Main(string[] args)
    {
        Program ps = new Program();
        ps.display();

        Console.ReadLine();
    }
}
}

       

