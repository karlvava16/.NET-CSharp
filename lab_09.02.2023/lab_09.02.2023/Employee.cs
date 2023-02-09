using System;
using System.CodeDom;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab
{
    public class Employee
    {
        string name;
        string surname;
        DateTime birthday;
        double payment;
        string contactNumber;
        string email;
        string position;
        string responsibilities;

        public string Name { get { return name; } set { name = value; } }
        public string Surname { get { return surname; } set { surname = value; } }
        public DateTime Birthday { get { return birthday; } set { birthday = value; } }
        public string ContactNumber { get { return contactNumber; } set { contactNumber = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Position { get { return position; } set { position = value; } }
        public string Responsibilities { get { return responsibilities; } set { responsibilities = value; } }
        public double Payment { get { return payment; } set { payment = value; } }

        Employee()
        {
            Name = string.Empty;
            Surname = string.Empty;
            Birthday = DateTime.Now;
            ContactNumber = string.Empty;
            Email = string.Empty;
            Position = string.Empty;
            Responsibilities = string.Empty;
        }

        public Employee(string name, string surname, string birthday, string contactNumber, string email, string position, string responsibilities, uint payment)
        {

            Name = name;
            Surname = surname;
            Birthday = DateTime.ParseExact(birthday, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            ContactNumber = contactNumber;
            Email = email;
            Position = position;
            Responsibilities = responsibilities;
            Payment = payment;
        }

        public static Employee operator +(Employee emp, double payment)
        {
            var temp = emp;
            temp.Payment += payment;
            return temp;
        }

        public static Employee operator -(Employee emp, double payment)
        {
            var temp = emp;
            temp.Payment -= payment;
            return temp;
        }

        public static Employee operator +(double payment, Employee emp)
        {
            var temp = emp;
            temp.Payment += payment;
            return temp;
        }

        public static Employee operator -(double payment, Employee emp)
        {
            var temp = emp;
            temp.Payment -= payment;
            return temp;
        }

        public static bool operator ==(Employee emp1, Employee emp2)
        {
            return emp1.Payment == emp2.Payment;
        }
        public static bool operator !=(Employee emp1, Employee emp2)
        {
            return emp1.Payment != emp2.Payment;
        }

        public static bool operator <(Employee emp1, Employee emp2)
        {
            return emp1.Payment < emp2.Payment;
        }
        public static bool operator >(Employee emp1, Employee emp2)
        {
            return emp1.Payment > emp2.Payment;
        }
        public static bool operator <=(Employee emp1, Employee emp2)
        {
            return emp1.Payment <= emp2.Payment;
        }
        public static bool operator >=(Employee emp1, Employee emp2)
        {
            return emp1.Payment >= emp2.Payment;
        }

        public override string ToString()
        {
            return $"Name : {name}\nSurname : {surname}\nBirthday : {birthday.ToString("dd.MM.yyyy")}\nContact Number : {ContactNumber}\nPosition : {Position}\nResponsibilities : {Responsibilities}\nPayment : {Payment}";
        }
    }
}
