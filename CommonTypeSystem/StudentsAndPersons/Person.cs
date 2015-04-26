namespace StudentsAndPersons
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;
    class Person
    {

        #region Fields 

        // With ? in the end of the type of the variable
        // we declare that value type variable can hold null value
        private string name;
        private int? age;

        #endregion

        #region Constructors 

        public Person(string name, int? age)
        {
            this.Name = name;
            this.Age = age;
        }

        #endregion

        #region Properties 

        public string Name { 
            get { return this.name; }
            set { this.name = value; } 
        }
        public int? Age
        {
            get { return this.age; }
            set { this.age = value; }
        }


        #endregion

        #region Methods

        public override string ToString()
        {
            return string.Format("Name: {0} and age: {1}", this.name, (this.age == null) ? "is not specified " : this.age.ToString());
        }

        #endregion
    }
}
