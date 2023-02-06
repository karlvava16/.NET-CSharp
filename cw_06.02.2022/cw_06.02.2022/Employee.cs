using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyProject
{
    public class Employee
    {
        string name;
        string surname;
        DateTime birthday;
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

        public Employee(string name, string surname, string birthday, string contactNumber, string email, string position, string responsibilities)       
        {

            Name = name;
            Surname = surname;
            Birthday = DateTime.ParseExact(birthday, "dd.MM.yyyy", System.Globalization.CultureInfo.InvariantCulture);
            ContactNumber = contactNumber;
            Email = email;
            Position = position;
            Responsibilities = responsibilities;
        }

        public override string ToString()
        {
            return $"Name : {name}\nSurname : {surname}\nBirthday : {birthday.ToString("dd.MM.yyyy")}\nContact Number : {ContactNumber}\nPosition : {Position}\nResponsibilities :\n{Responsibilities}\n";
        }
    }
}
