using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Employee
    {
        static int EmployeesCount { get; set; } = 0;
        private string SSN { get; }
        private System.DateTime Birthday { get; set; }
        private string FirstName { get; set; }
        private string LastName { get; set; }

        //public override string ToString()
        //{
        //    return $"{FirstName} {LastName}. SSN: {SSN}";
        //}

        public override string ToString() => $"[Base: {base.ToString()}; First name: {FirstName}; Last name: {LastName}; SSN: {SSN}]";

        public virtual void ShowInfo()
        {
            Console.WriteLine($"SSN: {SSN}");
            Console.WriteLine($"Birthday: {Birthday}");
            Console.WriteLine($"FirstName: {FirstName}");
            Console.WriteLine($"LastName: {LastName}");
            Console.WriteLine($"EmployeeCount: {EmployeesCount}");
        }

        public Employee() : this("1909-01-01", "Employee", "Employee")
        {
            //Console.WriteLine("Employee standard ctor.");
        }
        public Employee(string birthday = "", string firstName = "Employee", string lastName = "Employee")
        {
            //Console.WriteLine("Employee special ctor.");
            SSN = new Random((int)(DateTime.Now.Ticks)).Next().ToString();
            EmployeesCount++;

            DateTime date = new DateTime();
            DateTime.TryParse(birthday, out date);
            Birthday = date;

            FirstName = firstName;
            LastName = lastName;
        }

    }
}