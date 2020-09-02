using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    public class AccessDemo
    {

        private void Demo()
        {
            PrivateDemo(); // PrivateDemo is accessible to Demo
        }

        private void PrivateDemo()
        {
            
        }

        private protected void PrivateProtectedDemo()
        {
            // Only available in access demo

        }

        protected void ProtectedDemo()
        {
            // Protected can be accessed within the declaring class or any class that is derived from it - 
            // i.e. this is tied to inheritance.
        }

        protected internal void ProtectedInternalDemo()
        {
            // Can be accessed anywhere in same project and also any class that inherits from the declading class
        }

        internal void InternalDemo()
        {
            // Broader scope than private - it can be accessed from the project or assembly it is declared in.
        }

        public void PublicDemo()
        {
            // Can be called from pretty much anywhere.

            // This method can be called from outside this class (and project) and this method in turn can access PrivateDemo.
        }
    }
}
