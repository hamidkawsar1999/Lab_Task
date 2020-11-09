using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class FINAL
    {
        static void Main()
        {
            Student s = new Student();
            s.Id = "19-40077-1";
            s.Name = "Kawsar Hamid";
            s.Depertment = "CSE";
            s.Cgpa = 3.81f;
            s.showInfo();



            Library ob = new Library();
            Console.ReadLine();
        }
    }
}
