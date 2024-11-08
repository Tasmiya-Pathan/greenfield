using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Delegation;
namespace Bank
{
    public class Account
    {
        // for event to define delegate is must.
        public event Operation underBalance;
        public event Operation overBalance;
        public double Balance { get; set; }
        public Account(double initialAmount)
        {
            Balance = initialAmount;
        }
        public void Withdraw(double amount)
        {
            double result = Balance - amount;
            if (result <= 10000)
            {
                // raise event:  underBalance
                underBalance(5);
            }
            Balance -= amount;
        }
        public void Deposit(double amount)
        {
            Balance += amount;
            if (Balance >= 250000)
            {
                // raise event : overBalance
                overBalance(10);
            }
        }
    }
}
