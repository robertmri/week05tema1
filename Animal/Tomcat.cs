﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Tomcat : Cat
    {
        public Tomcat(string name, int age) : base(name, age, Gender.Male) { }
        public void MakeNoise()
        {
            Console.WriteLine("Miau");
        }

    }
}
