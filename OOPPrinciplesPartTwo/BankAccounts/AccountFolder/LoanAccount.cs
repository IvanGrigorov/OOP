using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class LoanAccount : Account
    {
        public override double InterestAmount(int monthAmount)
        {
            if (this.Customer is Individual)
            {
                monthAmount -= 3;
                return this.InterestRateMonthly * monthAmount;
            }
            else
            {
                monthAmount -= 2;
                return this.InterestRateMonthly * monthAmount;
            }
        }
        public LoanAccount(Customer customer, decimal balance, double monthlyRate)
            :base(customer,balance,monthlyRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRateMonthly = monthlyRate;
        }
    }
}
