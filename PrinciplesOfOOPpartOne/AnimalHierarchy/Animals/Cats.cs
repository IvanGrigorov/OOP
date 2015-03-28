using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Cats : Animal
    {
        #region Constructor 

        public Cats(string name, int age)
            : base (name, age)
        {
        }

        #endregion

    }
}
