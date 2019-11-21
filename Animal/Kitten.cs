﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Kitten : Cat
    {
        public Kitten(string name, int age) : base(name, age, Gender.Female) { }
        public void MakeNoise()
        {
            Console.WriteLine("Miuuu");
        }

    }
}
