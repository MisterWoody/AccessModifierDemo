﻿using System;
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

            demo.PublicDemo(); // Public as expected can be accessed here when it's in a different assembly.

            BadClass bad = new BadClass();
            bad.creditCardNumber = "123456";   // This should never be done - information leakage with no protection to the property!

            Console.WriteLine(bad.SSN); // Good practice as this will show the filtered property - if _ssn was public we could inadvertently expose information that should be private.
        }

        private static void SayHello()
        {
            Console.WriteLine("Hello user");
        }
    }
}
