using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractionLabTask_7
{
    class MAIN
    {
        static void Main()
        {
            

            SAVINGS S = new SAVINGS();
            S.AcName = "Hamid Kawsar";
            S.AccId = "12cdfKH";
            S.balance = 1000;
            S.TrancNO = 4;
            S.ShowAccountInfo();
            S.Withdraw(800);
            Console.WriteLine();
         
            
             SpecialSaving fix =new SpecialSaving(); 
            fix.AcName = "Hamid Kawsar";
            fix.AccId = "12cdfKH";
            
            fix.balance = 5000;
            fix.openingBalance = 6000;
            fix.ShowAccountInfo();
            fix.Withdraw(3000);
            Console.WriteLine();


           Fixed  SS = new Fixed();
            SS.AcName = "Hamid Kawsar";
            SS.AccId = "12cdfKH";
            SS.TurnerYear = 2030;
            SS.WithdrawalYear= Int32.Parse(DateTime.Now.Year.ToString());
            SS.balance = 4000;
            SS.ShowAccountInfo();
            SS.Withdraw(3000);
            Console.WriteLine();

            OverDraft OD = new OverDraft();
            OD.AcName = "Hamid Kawsar";
            OD.AccId = "12cdfKH";
            OD.balance = 6000;
            OD.openingOverDraftBalance = 1000;
            OD.ShowAccountInfo();
            OD.Withdraw(7000);









            Console.ReadLine();

        }
    }
}
