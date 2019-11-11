using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var classA = new Class("A");
            School mySchool = new School(classA);
            classA.AddStudent(new Student(classA, "Mri Robert"));
            var class2 = new Class("A");
            mySchool.AddClass(classA);
            mySchool.AddClass(class2);
            var teacher1 = new Teacher("Ion Popa");
            classA.AddTeacher(teacher1);
            var dis1 = new Discipline("French", 25, 40);
            teacher1.TeachedDisciplines.Add(dis1);

            classA.Comments = "test";
        }
    }
}
