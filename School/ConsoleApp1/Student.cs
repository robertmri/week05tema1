using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Student : People
    {
        public Student(Class cl, string name) : base(name)
        {
            this.ClassNumber = cl.ClassNumber;
        }
        internal int ClassNumber { get; }
    }
}
