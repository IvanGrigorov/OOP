using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Individual : Customer
    {
        public string Name { get; set; }

        // Some additional information that is not specificly needed in this case
        public string LastName { get; set; }

        public Individual(string name, string lastName)
        {
            this.Name = name;
            this.LastName = lastName;
        }
    }
}
