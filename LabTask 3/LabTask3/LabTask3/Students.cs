using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LabTask3
{
   public class Students
    {
        
            private String name;
            private String id;
            private String department;
            private double cgpa;
            public void set(String Name, String Id, String Department, double Cgpa)
            {
                this.name = Name;
                this.id = Id;
                this.department = Department;
                this.cgpa = Cgpa;
            }
            public void ShowInfo()
            {
                Console.WriteLine("Name :" + name);
                Console.WriteLine("Id :" + id);
                Console.WriteLine("Department :" + department);
                Console.WriteLine("Cgpa :" + cgpa);
            }
        static void Main()
        {
            Students ob = new Students();
            ob.set("Hamid Kawsar","19-40077-1","CSE",3.81);
            ob.ShowInfo();
            Console.ReadLine();
        }

     }
    
    
}
