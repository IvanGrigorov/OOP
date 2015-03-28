using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StudentsAndWorkers
{
    class Human
    {
        #region Properties
        public string FirstName { get; set; }

        public string LastName { get; set; }

        #endregion

        #region Constructor
        public Human(string fName, string lName)
        {
            this.FirstName = fName;
            this.LastName = lName;

        }
        #endregion
    }
}
