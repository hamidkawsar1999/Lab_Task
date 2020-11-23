using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{

public class parenta
    {
      public virtual  void cls()
        {
            Console.WriteLine(" hello from parent class");
        }
        
    }

    public class son : parenta
    {
        
     public override  void cls()
        {
            Console.WriteLine(" hello from child class");
        }

    }
    class FINAL
    {

        public static int Add(int n,int p)
        {

            return n+p;

        }
        static void Main()
        {


            son ob2 = new son();
            ob2.cls();


            parenta ob1 = new parenta();
            ob1.cls();
            //son ob = new son();

             
           
            


            

            Console.ReadLine();

        }
    }
}
