using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Student
    {
        private string name, id, depertment;
        private float cgpa;
        public Student()
        {
            Console.WriteLine();
        }
        public string Name
        {
             set { name = value; }
            get { return name; }
         }
        public string Id
        {
            set { id = value; }
            get { return id; }
        }
        public string Depertment
        {
            set { depertment = value; }
            get { return depertment; }
        }
        public float Cgpa
        {
            set { cgpa = value; }
            get { return cgpa; }
        }
        Student(float cgpa)
        {
            this.cgpa = cgpa;
        }

        public void showInfo()
        {
            Console.WriteLine("NAME: "+name+"\nid : "+id+"\ndepertment: "+depertment+"\nCGPA: "+cgpa);

        }

    }
}
