using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask3
{
    class Account
    {
        private String accName;
        private String acid;
        private int balance=0;
        

       public void Deposit(int amount)
        {
            balance = balance + amount;
            Console.WriteLine("balance :"+balance);
            Console.WriteLine(" deposit amount "+amount);
        }
     public void Withdraw(int amount)
        {
                      balance = balance - amount;
            Console.WriteLine("balance :"+balance);
            Console.WriteLine(" withdraw amount "+amount);
        }

    }

    class Course
    {
        private String courseName;
        private String courseCode;
       private int courseCredit;
        public void set(String courseName, String courseCode, int courseCredit)
        {
            this.courseCredit = courseCredit;
            this.courseCode = courseCode;
            this.courseName = courseName;
        }
       public void ShowCourseInfo()
        {
            Console.WriteLine(courseCode+"  "+courseCredit+ "  "+courseName+"  ");
        }
        static void Main()
        {
            Account ob = new Account();
            ob.Deposit(2000);
            ob.Withdraw(1000);

            Course ob2 = new Course();
            ob2.set("OOP2","2103",3);
            ob2.ShowCourseInfo();

            Console.ReadLine();
        }
    }
}

