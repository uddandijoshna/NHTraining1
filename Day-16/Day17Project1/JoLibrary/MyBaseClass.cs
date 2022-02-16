using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JoLibrary
{
    public class MyBaseClass
    {

        public int a;
        private int b;
        protected int c;
        internal int d;
        protected internal int e;
        public void MyBaseClassMethod()
        {
            a = 5;
            b = 10;
            c = 15;
            d = 20;
            e = 30;
        }
    }



    public class MyDerivedClass : MyBaseClass
    {
        public void MyDerivedClassMethod()
        {
            a = 5;
            //b = 10; // Here the Private Access Modifier is not accessed in the Derived Class

            c = 15;
            d = 20;
            e = 30;
        }
    }

    public class MyOtherClass
    {
        public void MyOtherClassMethod()
        {
            MyBaseClass mb = new MyBaseClass();
            mb.a = 5;

            mb.d = 20;
            mb.e = 30;

        }
    }
}


