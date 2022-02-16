using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoshLibrary
{
    public class Physics
    {
        public static int FinalVelocity(int u,int a,int t)
        {
            int finalvelocity = u + a * t;
            Console.WriteLine(finalvelocity);
            return finalvelocity;
        }
    }
}
