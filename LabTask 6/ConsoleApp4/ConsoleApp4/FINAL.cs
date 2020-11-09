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
            Console.WriteLine("\n");



            Library ob = new Library();
            ob.libNAME = "new LIBRARY";
            ob.libADDRESS = "Uttara Dhaka";
            ob.ShowLibInfo();
           
            Console.WriteLine("\n");

            ob.ShowAllBooks();
            Console.WriteLine("\n");

            Book book = new Book();
            book.bName = "oop2";
            ob.AddNewBook(book);
            
            ob.ShowAllBooks();
            Console.WriteLine("\n");

            ob.DeleteBook(book);
            ob.ShowAllBooks();
            Console.WriteLine("\n");


            ob.AddNewBookCopy(book,3);
            ob.ShowAllBooks();
            Console.WriteLine("\n");

            Console.ReadLine();

        }
    }
}
