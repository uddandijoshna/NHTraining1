using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;



namespace PublicLibrary
{
    public class Physiscs
    {
        public static int FinalVelocity(int u, int a, int t)
        {
            int finalvelocity = u + a * t;
            Console.WriteLine(finalvelocity);
            return finalvelocity;

        }
    }
}