using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using DemoLibrary;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {

            AccessDemo demo = new AccessDemo();

            // PrivateDemo is not visible in this project!

            // Internal demo is not accessible here either as this is a different project/assembly
        }
    }
}
