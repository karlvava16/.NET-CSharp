using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    internal class Program
    {
        static void Task1_2()
        {
            var firms = new List<Firm>()
            {
                new Firm
                {
                    Name = "Food Cort",
                    FoundedDate = new DateTime(2000, 1, 1),
                    BusinessProfile = "Food",
                    DirectorName = "Hua Ming",
                    EmployeesCount = 150,
                    Address = "Kyiv"
                },
                new Firm
                {
                    Name = "IT Solutions",
                    FoundedDate = new DateTime(2010, 5, 15),
                    BusinessProfile = "IT",
                    DirectorName = "Alice Green",
                    EmployeesCount = 200,
                    Address = "London"
                },
                new Firm
                {
                    Name = "Marketing Group",
                    FoundedDate = new DateTime(2005, 3, 20),
                    BusinessProfile = "Marketing",
                    DirectorName = "Bob Smith",
                    EmployeesCount = 50,
                    Address = "Los Angeles"
                },
                new Firm
                {
                    Name = "Green Energy",
                    FoundedDate = new DateTime(2018, 7, 1),
                    BusinessProfile = "Energy",
                    DirectorName = "Jane Doe",
                    EmployeesCount = 80,
                    Address = "San Francisco"
                }
            };

            // Получить информацию обо всех фирмах
            var allFirms = firms.ToList();
            Console.WriteLine("Все фирмы:\n");
            foreach (var firm in allFirms)
                Console.WriteLine(firm);

            // Получить фирмы, у которых в названии есть слово Food
            var foodFirms = firms.Where(f => f.Name.Contains("Food")).ToList();
            Console.WriteLine("\nФирмы с названием, содержащим слово Food:\n");
            foreach(var firm in foodFirms)
             Console.WriteLine(firm);

            // Получить фирмы, которые работают в области маркетинга
            var marketingFirms = firms.Where(f => f.BusinessProfile == "Marketing").ToList();
            Console.WriteLine("\nФирмы в области маркетинга:\n");
            foreach (var firm in marketingFirms)
                Console.WriteLine(firm);

            // Получить фирмы, которые работают в области маркетинга или IT
            var marketingOrITFirms = firms.Where(f => f.BusinessProfile == "Marketing" || f.BusinessProfile == "IT").ToList();
            Console.WriteLine("\nФирмы в области маркетинга или IT:\n");
            foreach (var firm in marketingOrITFirms)
                Console.WriteLine(firm);

            // Получить фирмы с количеством сотрудников, большем 100
            var largeFirms = firms.Where(f => f.EmployeesCount > 100).ToList();
            Console.WriteLine("\nФирмы с количеством сотрудников больше 100:\n");
            foreach (var firm in largeFirms)
                Console.WriteLine(firm);

            // Получить фирмы с количеством сотрудников в ди
        }

        static void Task3()
        {
            var companies = new List<Firm>
        {
             new Firm
                {
                    Name = "Food Cort",
                    FoundedDate = new DateTime(2000, 1, 1),
                    BusinessProfile = "Food",
                    DirectorName = "Hua Ming",
                    EmployeesCount = 150,
                    Address = "Kyiv"
                    
                },
                new Firm
                {
                    Name = "IT Solutions",
                    FoundedDate = new DateTime(2010, 5, 15),
                    BusinessProfile = "IT",
                    DirectorName = "Alice Green",
                    EmployeesCount = 200,
                    Address = "London"
                },
                new Firm
                {
                    Name = "Marketing Group",
                    FoundedDate = new DateTime(2005, 3, 20),
                    BusinessProfile = "Marketing",
                    DirectorName = "Bob Smith",
                    EmployeesCount = 50,
                    Address = "Los Angeles"
                },
                new Firm
                {
                    Name = "Green Energy",
                    FoundedDate = new DateTime(2018, 7, 1),
                    BusinessProfile = "Energy",
                    DirectorName = "Jane Doe",
                    EmployeesCount = 80,
                    Address = "San Francisco"
                }
        };

            companies[0].Employees.Add(new Employee { LastName = "Brown", FirstName = "David", Position = "Manager", Phone = "230-555-1234", Email = "dbrown@abcfood.com", Salary = 50000 });
            companies[0].Employees.Add(new Employee { LastName = "Johnson", FirstName = "Jessica", Position = "Salesperson", Phone = "230-555-5678", Email = "jjohnson@abcfood.com", Salary = 35000 });
            companies[1].Employees.Add(new Employee { LastName = "Smith", FirstName = "Michael", Position = "Marketing Director", Phone = "212-555-1234", Email = "msmith@xyzmarketing.com", Salary = 80000 });
            companies[1].Employees.Add(new Employee { LastName = "Wilson", FirstName = "Karen", Position = "Social Media Manager", Phone = "212-555-5678", Email = "kwilson@xyzmarketing.com", Salary = 55000 });
            companies[1].Employees.Add(new Employee { LastName = "Lopez", FirstName = "Maria", Position = "Salesperson", Phone = "212-555-9012", Email = "mlopez@xyzmarketing.com", Salary = 40000 });
            companies[2].Employees.Add(new Employee { LastName = "Lee", FirstName = "Jason", Position = "CTO", Phone = "415-555-1234", Email = "jlee@techsolutions.com", Salary = 100000 });
            
         }

        static void Main(string[] args)
        {
            Task1_2();
            Task3();
        }
    }
}
