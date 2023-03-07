using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Firm
    {
        public string Name { get; set; }
        public DateTime FoundedDate { get; set; }
        public string BusinessProfile { get; set; }
        public string DirectorName { get; set; }
        public int EmployeesCount { get; set; }
        public string Address { get; set; }

        public List<Employee> Employees { get; set; }

        public override string ToString()
        {
            return $"Name: {Name}\nFoundedDate: {FoundedDate.ToString("dd.MM.yyyy")}\nBusinessProfile: {BusinessProfile}\n" +
               $"DirectorName: {DirectorName}\nEmployeesCount: {EmployeesCount}\nAddress: {Address}\n";
        }
    }

}
