using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionLabTask_7
{
    class OverDraft:ACOUNT
    {
        int i = 0;
        public override void Withdraw(double amount)
        {
            if ((amount-balance) <= openingOverDraftBalance && i== 0)
            {
                balance = balance - amount;

                Console.WriteLine("amount Withdraw : " + amount + "\n net balance : " + balance);
                i++;
            }
            else
            {
                Console.WriteLine(" OverDraft transaction It is not possible at this moment");
            }
        }
    }
}
