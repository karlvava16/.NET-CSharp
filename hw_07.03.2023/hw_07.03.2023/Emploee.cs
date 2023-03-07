using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Employee
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Position { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public double Salary { get; set; }

        public override string ToString()
        {
            return $"Name: {FirstName}\nSurname: {LastName}\nPosition{Position}\nPhone: {Phone}\nEmail: {Email}\nSalary: {Salary}\n";
        }
    }
}
