using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class MortageAccount : Account
    {
        public override double InterestAmount(int monthAmount)
        {
            double interest = 0;
            if (this.Customer is Company)
            {
                interest = 12 * (this.InterestRateMonthly / 2);
                monthAmount -= 12;
                interest += this.InterestRateMonthly * monthAmount;
                return interest;
            }
            else
            {
                monthAmount -= 6;
                interest += this.InterestRateMonthly * monthAmount;
                return interest;
            }
        }
        public MortageAccount(Customer customer, decimal balance, double monthlyRate)
            :base(customer,balance,monthlyRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRateMonthly = monthlyRate;
        }
    }
}
