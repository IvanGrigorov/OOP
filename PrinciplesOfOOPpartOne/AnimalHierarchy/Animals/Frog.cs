using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Frog : Animal
    {
        #region Constructor 

        public Frog(string name, int age, string sex)
            : base (name, age)
        {
            this.Sex = sex;
        }

        #endregion
    }
}
