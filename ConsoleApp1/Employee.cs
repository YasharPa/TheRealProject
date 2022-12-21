using System;
using System.Collections.Generic;
using System.Text;
using System.Collections;
using System.Linq;

namespace AtudaimProject
{
    class Employee
    {

        public string EmployeeName { get; set; } // employee's name.
        public int EmployeeId { get; set; }  // employee's Id.

        public Dictionary<string, int> EmployeeNameAndId = new Dictionary<string, int>(); // creating Employee dict.
        public Dictionary<string, string> EmployeeAndCostumers = new Dictionary<string, string>(); // dict of the Employee's and costumer's name.
        public Dictionary<int, string> EmployeeOpenTime = new Dictionary<int, string>(); // dict of Employee oped shift time.
        public Dictionary<string, string> EmployeeEndTime = new Dictionary<string, string>(); // dict of Employee end shift time.
        public Dictionary<int, double> EmployeeIdAndSalary = new Dictionary<int, double>(); // dict of Employee and his salary.


        public static DateTime realTime = DateTime.Now; // joining shift time.
        public void EmployeeProfile() // adding Employew's to the shift.
        {
            try
            {
                Console.WriteLine("Enter employee's name:"); // creating employe name.
                EmployeeName = Console.ReadLine();
                Console.WriteLine("Enter employee's Id:"); // Getting employe Id.
                EmployeeId = Convert.ToInt32(Console.ReadLine());
                EmployeeNameAndId.Add(EmployeeName, EmployeeId); // Adding the Name and Id that we received from the user.
                EmployeeOpenTime.Add(EmployeeId, realTime.ToString()); // Adding the Id and Time that we received from the user.
               
                foreach (var emp in EmployeeNameAndId) // Showing the data to the user.
                {
                    if (emp.Value == EmployeeNameAndId[EmployeeName]) // showing the spesific Employe adding. 
                    {

                        Console.WriteLine($"--------------------\nEmployee Name: {emp.Key}, Employee Id: {emp.Value} has been added in {realTime}.\n--------------------\n");
                    }
                }
            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please Enter A number!");
            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("Employee's Id Already Exist!");
            }
        }
        public void EmployeeEndShift() // Ending Employee's shift time.
        {
            try
            {
                Console.WriteLine("Enter employee's Id:"); // creating employe Id.
                EmployeeId = Convert.ToInt32(Console.ReadLine());
                DateTime EndTime = DateTime.Now; // exiting shift time.
                EmployeeEndTime.Add(EmployeeOpenTime[EmployeeId], EndTime.ToString());
                foreach (var emp1 in EmployeeNameAndId)
                {
                    if (emp1.Value == EmployeeNameAndId[EmployeeName])
                    {
                        Console.WriteLine($"--------------------\nEmployee Name: {emp1.Key}, Employee Id: {EmployeeId} has been ended his shift in {EndTime}.\n--------------------\n");
                    }

                }

            }
            catch (System.FormatException)
            {
                Console.WriteLine("Please enter a number!");
                
            }

        }


        public void EmployeeSalary()
        {

        }
        public void RemoveProfile() //removimg an Employee.
        {
            try
            {
                EmployeeOpenTime.Add(EmployeeId, realTime.ToString()); // adding employee Id and his

            }
            catch (System.ArgumentException)
            {
                Console.WriteLine("Employee's Id is not Exist!");
            }
        }

        public Employee() { }

        public Employee(int aEmployeeId, string aEmployeeName)
        {
            this.EmployeeName = aEmployeeName;
            this.EmployeeId = aEmployeeId;
            
        }
        
        
    }
}
