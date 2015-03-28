using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class Dogs : Animal
    {
        #region Constructor 

        public Dogs(string name, int age, string sex)
            : base (name, age)
        {
            this.Sex = sex;
        }

        #endregion
    }
}
