using System;
namespace eu.sig.training.ch04.v1
{
    public class CheckingAccount : Account
    {
        private int transferLimit = 100;

        public new Transfer MakeTransfer(String counterAccount, Money amount)
        {
            // 1. Check withdrawal limit:
            if (amount.GreaterThan(this.transferLimit))
            {
                throw new BusinessException("Limit exceeded!");
            }

            return base.MakeTransfer(counterAccount, amount);
        }
    }
}