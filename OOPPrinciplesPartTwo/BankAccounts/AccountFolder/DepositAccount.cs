using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class DepositAccount : Account
    {
        public void Withdrow(decimal money)
        {
            Console.WriteLine("The sum of {0} is withdrown", money);
            this.Balance -= money;
        }

        public override double InterestAmount(int monthAmount)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }
            else return this.InterestRateMonthly * monthAmount;
        }

        public DepositAccount(Customer customer, decimal balance, double monthlyRate)
            :base(customer,balance,monthlyRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRateMonthly = monthlyRate;
        }
    }
}
