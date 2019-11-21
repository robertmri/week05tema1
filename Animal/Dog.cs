﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    public class Dog : Animal
    {
        public Dog(string name, int age, Gender sex) : base(name, age, sex) { }

        public override void MakeNoise()
        {
            Console.WriteLine("Ham ham");
        }
    }
}
