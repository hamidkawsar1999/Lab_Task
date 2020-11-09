using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp4
{
    class Library
    {
        private string libName, libAddress;
       private int totalBook = 0;
        int k = 0;

        public Book[] listOfBook = new Book[50];
        public Library()
        {
            for (int i = 0; i < listOfBook.Length; i++)
            {
                listOfBook[i] = new Book();
            }

            listOfBook[0].bName = "padda NODIR MAJHI";
            listOfBook[0].bAuthor = " Manik Bandopadhay";
            listOfBook[0].bId = "2020";
            listOfBook[0].bType = "family drama";
            listOfBook[0].bCopy = 5;

            listOfBook[1].bName = "chadni rater prem";
            listOfBook[1].bAuthor = " parag gosh ";
            listOfBook[1].bId = "2055";
            listOfBook[1].bType = "horror crime";
            listOfBook[1].bCopy = 15;

            listOfBook[2].bName = "hajar bosor dhore";
            listOfBook[2].bAuthor = " Jahir Raihan ";
            listOfBook[2].bId = "2066";
            listOfBook[2].bType = "drama";
            listOfBook[2].bCopy = 6;


        }

        Library(int libName)
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

        public int TotalBook
        {
            set { totalBook = value; }
            get { return totalBook; }
        }


        public void ShowLibInfo()
        {
            Console.WriteLine("Libary Name: " + libNAME + "\nLibary Address: " + libAddress);


        }
        public void ShowAllBooks()
        {
            totalBook = 0;
            for (int i = 0; i < listOfBook.Length; i++)
            {

                if (listOfBook[i].bName != null || listOfBook[i].bId != null)
                {

                    listOfBook[i].ShowInfo();
                    totalBook = totalBook + listOfBook[i].bCopy;
                }

            }

            Console.WriteLine("Total Book: " + totalBook + "\n");
        }
        public void AddNewBook(Book book)
        {

            for (int i = 0; i < listOfBook.Length; i++)
            {
                if (listOfBook[i].bName == null)
                {
                    listOfBook[i].bName = book.bName;
                    break;
                }



            }

        }
        public void DeleteBook(Book book)
        {
            for (int i = 0; i < listOfBook.Length; i++)
            {
                if (String.Equals(listOfBook[i].bName,book.bName))
                {
                    listOfBook[i].bName = null;
                    listOfBook[i].bAuthor = null;
                    listOfBook[i].bId= null;
                    listOfBook[i].bCopy = 0;

                    break;
                }

            }
        }
            public void AddNewBookCopy(Book book, int copy)
            {
                for (int i = 0; i < listOfBook.Length; i++)
                {
                    if (String.Equals(listOfBook[i].bName, book.bName) )
                    {
                       listOfBook[i].bCopy += copy;
                        break;
                    }
                
                  else if (listOfBook[i].bName == null)
                    {
                        listOfBook[i].bName = book.bName;
                        listOfBook[i].bCopy = copy;
                    break;
                    }
               

                }

            }

        
    }
}