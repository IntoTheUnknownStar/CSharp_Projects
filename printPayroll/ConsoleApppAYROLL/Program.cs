//Name: AAMOS
//Application: Employee Payroll
//Date: 5/3/2020
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace printPayroll
{
    class Employee
    {
        public int EmployeeID { get; set; }
        public string EmployeeName { get; set; }
        public double Salary { get; set; }
        public double BiWeekly { get; set; }

        //Constructor for Employee info
        public Employee(string name, int eID, double pay)
        {
            this.EmployeeID = eID;
            this.Salary = pay;
            this.EmployeeName = name;
            this.BiWeekly = Calc(pay);

        }
        //BiWeekly calculation method
        public double Calc(double purchase)
        {
            return purchase / 26;
        }

        //Summary is saved to a .txt file located
        //C: \Users\Public\Documents\EmployeePayroll
        public void Display()
        {

                WriteLine("Employee Info: Your employee information is -- Name: {0} ID: {1}." +
                "\nSalary: {2} and Bi-Weekly Salary: {3}.", this.EmployeeName, this.EmployeeID, this.Salary.ToString("C"), this.BiWeekly.ToString("C"));
 

        }
        //Program for input of Employee Data
        //Loops three times and sends to file
        static void Main(string[] args)
        {
            int x = 0;
            Employee[] info = new Employee[3];
            for(x=0;x<3;x++)
            {
                Write("Please enter employee name : ");
                string EmployeeName = ReadLine();

                Write("Please enter employee ID : ");
                int EmployeeID = Convert.ToInt32(ReadLine());

                Write("Please enter employee's salary : ");
                double Salary = Convert.ToDouble(ReadLine());
                WriteLine();

                info[x] = new Employee(EmployeeName, EmployeeID, Salary);
            }

            using (System.IO.StreamWriter file =
          new System.IO.StreamWriter(@"C:\Users\Public\Documents\EmployeePayroll" + DateTime.Now.ToString("MM_dd_yyyy") + ".txt"))
            {

            
                file.WriteLine("Employee Info: Your employee information is -- Name: {0} ID: {1}." +
                "\nSalary: {2} and Bi-Weekly Salary: {3}.", info[0].EmployeeName, info[0].EmployeeID, info[0].Salary.ToString("C"), info[0].BiWeekly.ToString("C"));
                file.WriteLine("Employee Info: Your employee information is -- Name: {0} ID: {1}." +
                "\nSalary: {2} and Bi-Weekly Salary: {3}.", info[1].EmployeeName, info[1].EmployeeID, info[1].Salary.ToString("C"), info[1].BiWeekly.ToString("C"));
                file.WriteLine("Employee Info: Your employee information is -- Name: {0} ID: {1}." +
                "\nSalary: {2} and Bi-Weekly Salary: {3}.", info[2].EmployeeName, info[2].EmployeeID, info[2].Salary.ToString("C"), info[2].BiWeekly.ToString("C"));
            }
            for(x=0;x<3;x++)
            {
                info[x].Display();
            }
            WriteLine();
            Write("EmployeePayroll" + DateTime.Now.ToString("MM_dd_yyyy") + ".txt has been saved to a your hard drive.");
            ReadKey();

 
        }

    }
}
