using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace BookExceptionDemo1
{
    class BookException : Exception
    {
        public BookException(string message)
        : base(message)
        {
        }
    }
    class Book
    {
        public string Title { get; set; }
        public string Author { get; set; }
        public double Price { get; set; }
        public int NumberOFPages { get; set; }

        public Book(string title, double price, int pages)
        {
            this.Title = title;
            this.Price = price;
            this.NumberOFPages = pages;
            double priceInCent = (price * 100)/ pages;
            if (priceInCent > 10.00)
            {
                Console.WriteLine(this.Title + " Price is : $" + this.Price + " # of pages are : " + this.NumberOFPages);
                throw new BookException("For " + title + ", ratio is invaid... Price is $" + this.Price + " for " + this.NumberOFPages + " pages ");
            }
            else
            {
                Console.WriteLine( this.Title + " Price is : $" + this.Price + " # of pages are : " + this.NumberOFPages);
            }
        }
        public void Display()
        {
            string response = "Title : " + Title + " Author: " + Author + " Price is : $" + Price.ToString("C") + " Number of pages are : ";
            WriteLine(response);
        }

        public static void Main()
        {
                try
                {
                    Book book1 = new Book("Goodnight Moon", 12.99, 25);


                }
                catch (BookException e)
                {
                    Console.WriteLine("Book selection has an invalid ratio", e);
                    ReadKey();
                }
            try
            {
                Book book2 = new Book("Great Expectations", 12.99, 100);

            }
            catch (BookException e)
            {
                Console.WriteLine("Book selection has an invalid ratio", e);
                ReadKey();
            }
        }
    }
}
