﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoLibrary
{
    class InheritFromAccessDemo : AccessDemo
    {
        public void Test()
        {
            ProtectedDemo(); // Protected method is accessible here
            InternalDemo(); // And also the internal protected metod

            // But PrivateDemo is not accessible

            PrivateProtectedDemo(); // Is accessible
        }
    }
}
