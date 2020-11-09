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

       public Book()
        {

        }
        public int bCopy
        {
            set { bookCopy = value; }
            get { return bookCopy; }

        }
        public String bName
        {
            set { bookName = value; }
            get { return bookName; }
        }
        public String bAuthor
        {
            set { bookAuthor = value; }
            get { return bookAuthor; }
        }
        public string bId
        {
            set { bookId = value; }
            get { return bookId; }
        }
        public string bType
        {
            set { bookType = value; }
            get { return bookType; }
        }

        Book(String bookname,string bookAuthor)
        {
            Console.WriteLine();

        }
        public void ShowInfo()
        {
            Console.WriteLine("Book Name : "+bookName+"\n Book Author: "+bookAuthor+"\n Book ID: "+bookId+"\n Book Type: "+bookType+"\n Book Copy: "+bookCopy);
        }
        public void AddBookCopy(int x)
        {
            bookCopy = bookCopy + x;  
        }
       
        

    }
}
