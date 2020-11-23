using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionLabTask_7
{
   abstract class ACOUNT
    {
        private string AccountNmae;
        private string AccountId;

        public double balance, openingOverDraftBalance;

        public  double openingBalance;

        public abstract void Withdraw(double amount); 

       public String AcName
        {
            set { AccountNmae = value; }
            get { return AccountNmae; }
        }


        public String AccId
        {
            set { AccountId = value; }
            get { return AccountId; }
        }

        public void depositeBalance(double Amount)
        {
            balance = balance + Amount;
        }

        public void ShowAccountInfo()
        {
            Console.WriteLine("Account Name: "+ AccountNmae + "\n Account ID: "+ AccountId+"\n Total balance : "+balance);
        }


    }
}
