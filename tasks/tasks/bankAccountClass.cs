using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    public class BankAccount {
        private decimal balance;
        public decimal Balance {
            get { return balance; }
             set { balance = value; }
        }
        public BankAccount(decimal Balance)
        {
            if (Balance < 0)
            {
                Console.WriteLine("Initial balance can not be negative.Defined as 0.");
                balance = 0;
            }
            else
            {
                balance = Balance;
            }
        }
        public void Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Deposit amount must be greater than zero.");
            }
            else
            {
                balance = balance + amount;
                Console.WriteLine($"Deposited {amount} USD. New balance: {balance} USD.");
            }
        }
        public virtual void Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                Console.WriteLine("Withdraw amount must be greater than zero.");
            }
            else if (amount > balance)
            {
                Console.WriteLine("Insufficient funds.");
            }
            else
            {
                balance = balance - amount;
                Console.WriteLine($"Withdrew {amount} USD. New balance: {balance} USD.");
            }
        }
    }
}
