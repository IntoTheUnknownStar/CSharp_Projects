//Name: Aaron Amos
//Date: 4/12/20
//Application Description: Identifys 
using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Remoting.Messaging;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace FineForOverdueBooks
{
    class Program
    {
        static void Main()
        {
            //Input variables for statements
            int bookQuantity;
            int daysOverdue;
            //Input collection statements
            Write("Enter number of books that are overdue: ");
            bookQuantity = Convert.ToInt32(ReadLine());
            Write("Enter number of days that the {0} books were overdue: ", bookQuantity);
            daysOverdue = Convert.ToInt32(ReadLine());
            //Display written summary with Total fees
            FineTotal(bookQuantity,daysOverdue);
            ReadKey();
        }
        //Bookfine calculation method
        private static void FineTotal(int bookCount, int overdueCount)
        {
            //Book fine variables
            //Total variables with calaculations
            double minFee = (bookCount * 0.10);
            double maxFee = (bookCount * 0.20);
            const int minDays = 7;
            int remainder = (overdueCount - minDays);
            double total_1 = (minFee * minDays) + (maxFee * remainder);
            double total_2 = ((bookCount * minFee) * overdueCount);
            
            //Formulation for book fine
            //If more than seven days overdue use statement
            if (overdueCount > minDays)
                System.Console.WriteLine("The fine for {0} overdue book(s) for {1} day(s) is {2}", 
                    bookCount, overdueCount, total_1.ToString("C"));
            //If less or equal to seven days overdue use statement
            else
                if (overdueCount <= minDays)
                System.Console.WriteLine("The fine for {0} overdue book(s) for {1} day(s) is {2}", 
                    bookCount, overdueCount, total_2.ToString("C"));

        }
    }
}
