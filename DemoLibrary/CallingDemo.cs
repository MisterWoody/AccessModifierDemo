using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class CallingDemo
    {
        private void MakeDemoCalls()
        {
            AccessDemo demo = new AccessDemo();

            // Private demo method is not directly accessible here either outside of its declaring class!
            // Internal and protected internal are accessible here though (as well as public)

            demo.InternalDemo();

            InheritFromAccessDemo demo2 = new InheritFromAccessDemo();
            demo2.ProtectedInternalDemo();

            
            
        }
    }
}
