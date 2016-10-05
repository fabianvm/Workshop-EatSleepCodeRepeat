using System;

namespace eu.sig.training.ch04.v1
{
    public class SavingsAccount : Account
    {
        public CheckingAccount RegisteredCounterAccount { get; set; }

        public Transfer makeTransfer(string counterAccount, Money amount)
        {

            return base.MakeTransfer(counterAccount, amount);
            
        }
    }
}
