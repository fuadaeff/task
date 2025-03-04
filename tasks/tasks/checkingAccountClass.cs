using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tasks
{
    public class CheckingAccount : BankAccount
    {
        private decimal minimmumBalance = 50m;
        public decimal MinimumBalance {
            get { return minimmumBalance; }
            set { minimmumBalance = value; }
        }
        public CheckingAccount(decimal Balance) : base(Balance) { }
        public override void Withdraw(decimal amount)
        {
            if (Balance - amount >= minimmumBalance)
            {
                base.Withdraw(amount);
            }
            else
            {
                Console.WriteLine($"Cannot withdraw. There must be at least {minimmumBalance} USD left in the balance.");
            }
        }
    }
}
