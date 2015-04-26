using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    public abstract class Account : IDepositable
    {
        public Customer Customer{ get; set; }

        public decimal Balance { get; set; }

        // The interest rate is a double because it is devided by 100
        public double InterestRateMonthly { get; set; }

        public void Deposit(decimal money)
        {
            Console.WriteLine("The sum of {0} leva is deposited", money.ToString());
            this.Balance += money;
        }

        public virtual double InterestAmount(int monthAmount)
        {
            return this.InterestRateMonthly * monthAmount;
        }

        public Account(Customer customer, decimal balance, double monthlyRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRateMonthly = monthlyRate;
        }
    }
}
