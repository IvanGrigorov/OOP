using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AnimalHierarchy
{
    class TomCat : Cats 
    {
         #region Constructor 

        public TomCat(string name, int age)
            : base (name, age)
        {
            this.Sex = "male";
        }

        #endregion
    }
}
