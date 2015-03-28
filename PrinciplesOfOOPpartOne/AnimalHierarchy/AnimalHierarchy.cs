/* Create a hierarchy Dog, Frog, Cat, Kitten, Tomcat and define useful constructors and methods. Dogs, frogs and cats are Animals. 
   All animals can produce sound (specified by the ISound interface). Kittens and tomcats are cats. 
   All animals are described by age, name and sex. Kittens can be only female and tomcats can be only male. 
   Each animal produces a specific sound.
   Create arrays of different kinds of animals and calculate the average age of each kind of animal 
   using a static method (you may use LINQ).*/


using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class AnimalHierarchy
    {
        static void Main(string[] args)
        {
            Frog[] frogs = new Frog[5];
            frogs[0] = new Frog("Kermit", 7, "male");
            frogs[1] = new Frog("Kikeriza", 7, "female");
            frogs[2] = new Frog("Muholovka", 5, "female");
            frogs[3] = new Frog("Purgavka", 3, "female");
            frogs[4] = new Frog("Zelenko", 4, "female");

            Dogs[] dogs = new Dogs[5];
            dogs[0] = new Dogs("Sharo", 9, "male");
            dogs[1] = new Dogs("Sharik", 11, "male");
            dogs[2] = new Dogs("Murdjo", 7, "male");
            dogs[3] = new Dogs("Minka", 10, "female");
            dogs[4] = new Dogs("Lili", 8, "female");

            Cats[] cats = new Cats[5];
            cats[0] = new Kitten("Maca", 11);
            cats[1] = new Kitten("Puffi", 12);
            cats[2] = new TomCat("Chocho", 15);
            cats[3] = new TomCat("James", 10);
            cats[4] = new TomCat("Blacky", 17);

            var frogsAverageAge = frogs
                .Average(frog => frog.Age);

            var dogsAverageAge = dogs
                .Average(dog => dog.Age);

            var catsAverageAge = cats
                .Average(cat => cat.Age);

            Console.WriteLine("The average age of the frogs is {0}", frogsAverageAge.ToString());
            Console.WriteLine();

            Console.WriteLine("The average age of the dogs is {0}", dogsAverageAge.ToString());
            Console.WriteLine();

            Console.WriteLine("The average age of the cats is {0}", catsAverageAge.ToString());
            Console.WriteLine();
        }
    }
}
