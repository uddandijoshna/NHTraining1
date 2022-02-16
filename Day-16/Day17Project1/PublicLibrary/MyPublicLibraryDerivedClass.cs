using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using JoLibrary;

namespace PublicLibrary
{
    public class MyPublicLibraryDerivedClass : MyBaseClass
    {
        public void MyPublicLibraryDerivedClassMethod()
        {
            a = 5;
            //b = 10; // Here the Private Access Modifier is not accessed in the Derived Class in Other Assembly

            //d = 20; // Here the internal Access Modifier is not accessed in the  Derived Class in Other Assembly

            e = 30;
        }
    }
        public class MyPublicLibraryOtherClass
        {
            public void MyPublicLibraryDerivedClassMethod()
            {
           
            
                MyBaseClass mpd = new MyBaseClass();
                mpd.a = 5;
                // mpd.b = 10; Here the Private Access Modifier is not accessed in the other   Class in Other Assembly

                // mpd.c = 15; Here the Protected Access Modifier is not accessed in the other Class in Other Assembly

                // mpd.d = 20; Here the internal Access Modifier is not accessed in the other Class in Other Assembly

                // mpd.e = 30; Here the Protected Internal Access Modifier is not accessed in the other Class in Other Assembly

            }
        }
    
}
           