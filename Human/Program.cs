using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Human
{
    class Program
    {
        static void Main(string[] args)
        {
            var s1 = new Student("Mri", "Manole", 10);
            var s2 = new Student("Xulet", "Add", 9);
            var s3 = new Student("Ion", "Popa", 8);
            var s4 = new Student("Yulet", "dsasa", 7);
            var s5 = new Student("Zulet", "ZZZ", 6);
            var s6 = new Student("Hulet", "HHH", 5);
            var s7 = new Student("Vulet", "VVV", 7);
            var s8 = new Student("Aulet", "AAA", 9);
            var s9 = new Student("Sulet", "SSS", 8);
            var s10 = new Student("Culet", "CCC", 10);

            var sortedStudentList = Student.studentList.OrderBy(p => p.Grade).ToList();

            List<Worker> workers = new List<Worker>();
            workers.Add(new Worker("Giam", "Iun", 450, 8));
            workers.Add(new Worker("Giani", "GGG", 350, 8));
            workers.Add(new Worker("NameX", "XX", 420, 5));
            workers.Add(new Worker("NameY", "YYY", 460, 6));
            workers.Add(new Worker("NameM", "MMM", 380, 7));
            workers.Add(new Worker("NameU", "UUU", 395, 7));
            workers.Add(new Worker("NameO", "OOO", 250, 5));
            workers.Add(new Worker("NameB", "BBB", 150, 3));
            workers.Add(new Worker("NameP", "PPP", 180, 5));
            workers.Add(new Worker("Robert", "RRR", 290, 8));

            var sortedWorkersList = workers.OrderByDescending(p => p.MoneyPerHour());

            List<Human> mergedList = new List<Human>();
            mergedList.AddRange(sortedWorkersList);
            mergedList.AddRange(sortedStudentList);

            var sortedHumans = mergedList.OrderBy(p => p.FirstName).ThenBy(p => p.LastName);
            foreach (var item in sortedHumans)
            {
                Console.WriteLine($"{item.FirstName} { item.LastName}");
            }
        }
    }
}
