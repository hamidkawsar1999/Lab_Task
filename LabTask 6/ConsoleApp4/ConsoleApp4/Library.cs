using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Library
    {
        private string libName, libAddress;
        Book[] listOfBook;
        int totalBook;
        public Library() 
        { 
        }
        public string libNAME
        {
            set { libName = value; }
            get { return libName; }
        }
        public string libADDRESS
        {
            set { libAddress = value; }
            get { return libAddress; }
        }

        Library(int libName) 
        {
        
        }
        void ShowLibInfo() {
        }
        void ShowAllBooks() { 
        }
        void AddNewBook(Book book) {
            
        }
        void DeleteBook(Book book) { 
        }
        void AddNewBookCopy(Book book, int copy) { 
        }


      
    }
}
