using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    // It is abstract because we won't make an implementation of an animal 
    // It is just a base class for other animals
    public class Animal : Isound
    {
        #region Properties
        public int Age { get; set; }

        public string Name { get; set; }

        public string Sex { get; set; }

        #endregion

        #region Constructors

        public Animal(string name, int age) 
        {
            this.Age = age;
            this.Name = name;
        }

        #endregion

        #region Methods


        public void Talk(string speech)
        {
            Console.WriteLine(speech);
        }

        #endregion
    }
}
