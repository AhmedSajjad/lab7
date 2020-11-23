using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SavingsAccount:Account
     
    {
        public override void Deposit(int amount)
        {
            this.Balance += amount;
        }


        public override Boolean Withdraw(int amount)
        {
            if (this.Balance < amount)
            {
                return false;
            }
            else
            {
                this.Balance -= amount;
                return true;
            }
        }
    }
}
