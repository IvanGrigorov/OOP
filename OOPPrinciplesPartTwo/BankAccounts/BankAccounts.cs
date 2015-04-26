/* A bank holds different types of accounts for its customers: deposit accounts, loan accounts and mortgage accounts. 
   Customers could be individuals or companies.
   All accounts have customer, balance and interest rate (monthly based).
   Deposit accounts are allowed to deposit and with draw money.
   Loan and mortgage accounts can only deposit money.
   All accounts can calculate their interest amount for a given period (in months). In the common case its is calculated 
   as follows: number_of_months * interest_rate.
   Loan accounts have no interest for the first 3 months if are held by individuals and for the first 2 months if are held by a company.
   Deposit accounts have no interest if their balance is positive and less than 1000.
   Mortgage accounts have ½ interest for the first 12 months for companies and no interest for the first 6 months for individuals.
   Your task is to write a program to model the bank system by classes and interfaces.
   You should identify the classes, interfaces, base classes and abstract actions and implement the calculation of the 
   interest functionality through overridden methods.*/



using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BankAccounts
{
    class BankAccounts
    {
        static void Main(string[] args)
        {
            // Info for the Test
            // Declaring Companies and Individuals
            Company TBI = new Company("TBI", "Ivan");
            Company puma = new Company("Puma", "Konstantin Filipov");
            Company addidas = new Company("Addidas", "Martin Sonnerfeld");
            Individual me = new Individual("Fancy", "Pants");
            Individual somePerson = new Individual("Goldie", "Flint");
            Individual otherPerson = new Individual("Richie","Golden");
            Individual thirdPerson = new Individual("Healthy", "Worths");

            // Making Accounts of the bank to calculate their Rate
            // Some of them have the same interest rate to see if the overriden methods return 
            // different rates for the different types of accounts 
            Account[] bankAccounts = new Account[7];
            bankAccounts[0] = new DepositAccount(TBI, 12000, 0.017);
            bankAccounts[1] = new LoanAccount(puma, 10000, 0.017);
            bankAccounts[2] = new MortageAccount(addidas, 11000, 0.017);
            bankAccounts[3] = new DepositAccount(me, 900, 0.037);
            bankAccounts[4] = new DepositAccount(somePerson, 1200, 0.047);
            bankAccounts[5] = new LoanAccount(otherPerson, 1000, 0.047);
            bankAccounts[6] = new MortageAccount(thirdPerson, 1100, 0.047);

            foreach (Account account in bankAccounts)
            {
                if (account.Customer is Individual)
                {
                    Console.WriteLine("The customer is an individual. ");
                    Console.WriteLine("His account is: Name: {0}, Balance: {1} leva"
                        , account.Customer.Name, account.Balance.ToString());
                    Console.WriteLine("His interest Rate for two years: {0}", account.InterestAmount(24).ToString());
                    Console.WriteLine();
                }
                else
                {
                    Console.WriteLine("The customer is a company. ");
                    Console.WriteLine("Its account is: Name: {0}, Balance: {1} leva"
                        , account.Customer.Name, account.Balance.ToString());
                    Console.WriteLine("Its interest Rate for two years: {0}", account.InterestAmount(24).ToString());
                    Console.WriteLine();
                }
            }
        }
    }
}
