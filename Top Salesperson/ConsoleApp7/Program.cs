//Name : Aaron Amos
//Date : 4/8/2020
//Application Name: Home Sales
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace ConsoleApp7
{
    class HomeSalesCalculationLoop
    {
        static void Main()
        {
            //Definition of variables for Salesperson order entry
            double salePrice = 0.0;
            double total = 0;
            double totalD = 0.0;
            double totalE = 0.0;
            double totalF = 0.0;
            total = totalD + totalE + totalF;
            string salesInit;
            Write("Enter a salespersons initial: ");
            salesInit = Convert.ToString(ReadLine()).ToUpper();
            //Search calculation for validValues"
            do
            {
                if (salesInit != "Z")
                {
                    //If "D" selected will capture input
                    //store in "totalD" variable
                    if (salesInit == "D")
                    {
                        Write("Enter amount of sale: ");
                        salePrice = Convert.ToDouble(ReadLine());
                        Write("Enter next salesperson initial or Z to quit: ");
                        salesInit = Convert.ToString(ReadLine().ToUpper());
                        totalD += salePrice;
                    }

                    //If "E" selected will capture input 
                    //store in "totalD" variable
                    else if (salesInit == "E")
                    {
                        Write("Enter amount of sale: ");
                        salePrice = Convert.ToDouble(ReadLine());
                        Write("Enter next salesperson initial or Z to quit: ");
                        salesInit = Convert.ToString(ReadLine().ToUpper());
                        totalE += salePrice;
                    }

                    //If "F" selected will capture input 
                    //store in "totalD" variable
                    else if (salesInit == "F")
                    {
                        Write("Enter amount of sale: ");
                        salePrice = Convert.ToDouble(ReadLine());
                        Write("Enter next salesperson initial or Z to quit: ");
                        salesInit = Convert.ToString(ReadLine().ToUpper());
                        totalF += salePrice;

                    }
                    else if (salesInit != "D" || salesInit != "F" || salesInit != "E")
                    {
                        Write("Invalid Salesperson");
                        ReadKey();
                        break;
                    }
                }


            }
            while (salesInit != "Z");
            {
                //Calculates all inputs into a report
                total = totalD + totalE + totalF;
                Write("\n\nTotal sales amount of Danielle: " + totalD.ToString("C"));
                Write("\nTotal sales amount of Edward: " + totalE.ToString("C"));
                Write("\nTotal sales amount of Francis: " + totalF.ToString("C"));
                Write("\n-----------------------------------------");
                Write("\nGrant Total of all Sales: " + total.ToString("C"));


                //Provides salesperson with highest sales
                if (totalD > totalE && totalD > totalF)
                {
                    Write("\n\n*****Salesperson with the highest sales is Danielle.*****");
                }
                else if (totalE > totalD && totalE > totalF)
                {
                    Write("\n\n*****Salesperson with the highest sales is Edward.*****");
                }
                else
                {
                    Write("\n\n*****Salesperson with the highest sales is Francis.*****");
                }
                ReadKey();



            }
        }
    }
}
