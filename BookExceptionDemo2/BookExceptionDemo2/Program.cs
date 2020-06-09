//Name: Aaron Amos
//Application: BookExceptionDemo2
//Date: 4/25/2020
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using static System.Console;

namespace BookExceptionDemo2
{

    class BookException : Exception
    {
        public BookException(string message)
        : base(message)
        {
        }
    }
    //For Goodnight Moon, ratio is invalid. …Price is $12.99 for 25 pages
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int Pages { get; set; }

        public Book(string title, string author, double price, int pages)
        {
            this.Title = title;
            this.Price = price;
            this.Pages = pages;
            this.Author = author;
            double priceInCent = price * 100.00 / pages;
            
            if (priceInCent > 10.00)
            {
                throw new BookException("For " + title + ", ratio is invaid... Price is $" + this.Price + " for " + this.Pages + " pages ");
            }

        }
        public void Display()
        {
            string response = "Title : " + Title + " Author: "+ Author + " Price is : $" + Price.ToString("C") + " Number of pages are : " + Pages;
            WriteLine(response);
        }
        static void Main()
        {

            Book[] books = new Book[4];
            for (int i = 0; i < 4; i++)
            {
                try
                {
                    WriteLine();
                    Write("Enter Book Title: ");
                    string Title = ReadLine();

                    Write("Enter Author's Name: ");
                    string Author = (ReadLine());

                    Write("Enter Book Price: ");
                    double Price = Convert.ToDouble(ReadLine());

                    Write("Enter Number of pages: ");
                    int Pages = Convert.ToInt32(ReadLine());

                    books[0] = new Book(Title, Author, Price, Pages);
                    books[1] = new Book(Title, Author, Price, Pages);
                    books[2] = new Book(Title, Author, Price, Pages);
                    books[3] = new Book(Title, Author, Price, Pages);

                }
                catch (BookException ex)
                {
                    Console.WriteLine("*****The book selection ratio is Invalid*****", ex);
                }
            }
                    books[0].Display();
                    books[1].Display();
                    books[2].Display();
                    books[3].Display();
                    ReadKey();
        }
         
    }
        
}



