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

        }

        protected void ProtectedDemo()
        {

        }

        protected internal void ProtectedInternalDemo()
        {

        }

        internal void InternalDemo()
        {
            // Broader scope than private - it can be accessed from the project or assembly it is declared in.
        }

        public void PublicDemo()
        {
            // This method can be called from outside this class (and project) and this methog in turjn can access PrivateDemo.
        }
    }
}
