using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Account
    {
        string accName,acid;
        int balance;
        public Account()
        {

        }
       public Account(string accName,string acid, int balance)
        {
            this.accName = accName;
            this.acid = acid;
            this.balance = balance;
        }
        public string AName
        {
            set { accName = value; }
            get { return accName; }
        }
        public string Aid
        {
            set { acid = value; }
            get { return acid; }
        }
        public int Balance
        {
            set { balance = value; }
            get { return balance; }
        }



        public void deposit(int amount)
        {
            balance = balance + amount;
        }
        public void withdeaw(int amount)
        {
            balance = balance - amount;

        }

        public void Transfer(int amount,Account receiver)//Transfer amount from one account to another account
        {
          
        }
    }
}
