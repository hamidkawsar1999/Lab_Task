using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionLabTask_7
{
    class SpecialSaving : ACOUNT
    {
         protected int turnerYear;
         protected int withdrawalYear;

        public int TurnerYear
        {
            set { turnerYear = value; }
            get { return turnerYear; }
        }

        public int WithdrawalYear
        {
            set { withdrawalYear = value; }
            get { return withdrawalYear; }
        }


        public override void Withdraw(double amount)
        {
            if (amount>openingBalance*.2)
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
