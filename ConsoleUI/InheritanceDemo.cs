using DemoLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class InheritanceDemo : AccessDemo
    {

        private void Demo()
        {
            ProtectedDemo(); // Can be accessed here.

            // But private protected cannot be accessed.

            ProtectedInternalDemo(); // accessible here via inheritance

        }
    }
}
