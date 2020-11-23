using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionLabTask_7
{
    class SpecialSaving:Fixed
    {

        public override void Withdraw(double amount)
        {
            if (turnerYear < WithdrawalYear)
            {
                balance = balance - amount;

                Console.WriteLine("amount Withdraw : " + amount + "\n net balance : " + balance);

            }
            else
            {
                Console.WriteLine("It is not possible to do this transaction now");
            }
        }

    }
}
