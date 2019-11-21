using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Animal> myAnimals = new List<Animal>();

            myAnimals.Add(new Kitten("Pisii", 1));
            myAnimals.Add(new Tomcat("Motanu", 3));
            myAnimals.Add(new Cat("Pssss", 7, Gender.Female));
            myAnimals.Add(new Dog("Caineee", 5, Gender.Male));
            myAnimals.Add(new Frog("XASA", 2, Gender.Male));
            myAnimals.Add(new Frog("asasa", 5, Gender.Male));
            myAnimals.Add(new Cat("asaa", 1, Gender.Female));
            myAnimals.Add(new Dog("Cainee2", 9, Gender.Male));
            myAnimals.Add(new Kitten("Spiri", 1));
            myAnimals.Add(new Tomcat("Bobita", 7));
            myAnimals.Add(new Frog("Nanana", 2, Gender.Male));

            var catsAverageAge = ComputeAverageFor(myAnimals, typeof(Cat));
            var dogsAverageAge = ComputeAverageFor(myAnimals, typeof(Dog));
            var frogsAverageAge = ComputeAverageFor(myAnimals, typeof(Frog));
            var kittensAverageAge = ComputeAverageFor(myAnimals, typeof(Kitten));
            var TomcatsAverageAge = ComputeAverageFor(myAnimals, typeof(Tomcat));

        }

        private static double ComputeAverageFor(List<Animal> myAnimals, Type type)
        {
            var animalGroup = myAnimals.Where(p => p.GetType() == type).ToArray();

            return animalGroup.Average(p => p.Age);

        }
    }
}
