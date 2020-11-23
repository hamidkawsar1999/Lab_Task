using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionLabTask_7
{
    class SAVINGS:ACOUNT
    {
        private double TransectionNO;
       
        public double TrancNO
        {
            set { TransectionNO = value; }
            get { return TransectionNO; }
        }

        public int defaultTransectionNO=5;//monthly transection limit 

        public override void Withdraw(double amount)
        {
            if(defaultTransectionNO > TransectionNO && balance > 500)
            {
                balance = balance - amount;

                Console.WriteLine("\n amount Withdraw : "+amount+"\n net balance : "+balance);

            }
            else
            {
                Console.WriteLine("Insufficient Balance ");
            }
        }

    }
}
