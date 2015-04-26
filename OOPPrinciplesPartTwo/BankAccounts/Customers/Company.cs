using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class Company : Customer
    {

        public string Name { get; set; }

        // Some additional information that is not specificly needed in this case
        public string Owner { get; set; }

        public Company(string name, string owner)
        {
            this.Name = name;
            this.Owner = owner;
        }
    }
}
