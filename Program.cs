using System;
using System.Collections.Generic;

namespace classes
{
    class Program
    {
        static void Main(string[] args)
        {
            //In the Main method, create a company, and three employees, and then assign the employees to the company
            Company Chazmatics = new Company("Chazmatics", DateTime.Now);


            Employee Andrew = new Employee("Rock", "Copy Monkey", DateTime.Now);
            Employee Jason = new Employee("Jason", "Complainer", DateTime.Now);
            Employee Matt = new Employee("Matt", "Workhorse", DateTime.Now);

            Chazmatics.AddEmployee(Andrew);
            Chazmatics.AddEmployee(Jason);
            Chazmatics.AddEmployee(Matt);

            Chazmatics.ListEmployees();


        }
    }
    public class Company
    {
        /*
            Some readonly properties
        */
        public string name;
        public DateTime createdOn;
        public string Name { get; }
        public DateTime CreatedOn { get; }

        // Create a property for holding a list of current employees
        List<Employee> CompanyEmployees = new List<Employee>();

        // Create a method that allows external code to add an employee
        public void AddEmployee(Employee person) 
        {
            CompanyEmployees.Add(person);
        }
        // Create a method that allows external code to remove an employee
        public void RemoveEmployee(Employee person)
        {
            CompanyEmployees.Remove(person);
        }
        /*
            Create a constructor method that accepts two arguments:
                1. The name of the company
                2. The date it was created

            The constructor will set the value of the public properties
        */
        public Company(string name, DateTime start) 
        {
            this.Name = name;
            this.CreatedOn = start;
        }

        //Update the Company class to write the name of each employee to the console. Consider a method named ListEmployees()
        public void ListEmployees()
        {
            foreach(var n in CompanyEmployees)
            {
                Console.WriteLine($"{n.Name} {n.JobTitle} started on: {n.StartDate}");
            }
        }

    }
    public class Employee
    {
        //Create a class that contains information about employees of a company
        // and define methods to get/set employee name, job title, and start date.

        // Fields
        private string name;
        private DateTime startDate;
        private string jobTitle;

        // Properites
        public string Name
        {
            get
            {
                return name;
            }
            set
            {
                if (value != "")
                {
                    name = value;
                }
            }
        }
        public DateTime StartDate
        {
            get
            {
                return startDate;
            }
            set
            {
                if(value != null)
                {
                    startDate = value;
                }
            }
        }

        public string JobTitle
        {
            get
            {
                return jobTitle;
            }
            set
            {
                if (value != "")
                {
                    jobTitle = value;
                }
            }
        }

        public Employee (string name, string jobTitle, DateTime startDate)
        {
            this.Name = name;
            this.JobTitle = jobTitle;
            this.StartDate = startDate;
        }



    }
}
