using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace GreenvilleRevenue
{
    class Program
    {
        static void Main(string[] args)
        {
            //Declare and initialize variables
            int numberLast = 0;
            int numberCurrent = 0;
            double currentRevenue = 0.0;
            double lastRevenue = 0.0;
            const double entranceFee = 25.00;

            // prompt user for variable inputs
            Write("Enter the number of contestants last year: ");
            numberLast = Convert.ToInt32(ReadLine());

            Write("Enter the number of contestants this year: ");
            numberCurrent = Convert.ToInt32(ReadLine());

            //calculate the current Revenue and last year revenue
            currentRevenue = (numberCurrent * entranceFee);
            lastRevenue = (numberLast * entranceFee);

            //Statement for current/last year count
            WriteLine("Last year's competition had {0} contestants, and this year's has {1} contestants", numberLast, numberCurrent);

            // Current year revenue statement 
            WriteLine("Revenue expected this year is ${0}",currentRevenue);

            if (currentRevenue > lastRevenue)
            {
                WriteLine("It is true that this year's competition is bigger than last year's");
            }
            else
            {
                WriteLine("It is true that this year's competition is smaller than last year's");
            }
            ReadKey();




        }
    }
}
