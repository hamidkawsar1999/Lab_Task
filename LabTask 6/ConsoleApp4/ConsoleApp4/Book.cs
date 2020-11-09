using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp4
{
    class Book
    {
       private String bookName;
        private String bookAuthor;
        private String bookId;
        private String bookType;
        private int bookCopy; // how many copy 

        Book()
        {

        }
        public int bCopy
        {
            set { bookCopy = value; }
            get { return bookCopy; }

        }
        public int bName
        {
            set { bookCopy = value; }
            get { return bookCopy; }
        }
        public int bAuthor
        {
            set { bookCopy = value; }
            get { return bookCopy; }
        }
        public int bId
        {
            set { bookCopy = value; }
            get { return bookCopy; }
        }
        public int bType
        {
            set { bookCopy = value; }
            get { return bookCopy; }
        }

        Book(String bookname,string bookAuthor)
        {
            Console.WriteLine();

        }
        void ShowInfo()
        {
            Console.WriteLine("Book Name : "+bookName+"\n Book Author: "+bookAuthor+"\n Book ID: "+bookId+"\n Book Type: "+bookType+"\n Book Copy: "+bookCopy);
        }
        void AddBookCopy(int x)
        {
            bookCopy = bookCopy + x;  
        }
       
        

    }
}
