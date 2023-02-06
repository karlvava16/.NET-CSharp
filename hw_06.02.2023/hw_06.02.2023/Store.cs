using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork
{
    public class Store
    {
        string name;
        string address;
        string description;
        string phone;
        string email;

        public string Name { get { return name; } set { name = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Email { get { return email; } set { email = value; } }

        public Store() { }

        public Store (string name, string address, string description, string phone, string email)
        {
            Name = name;
            Address = address;
            Description = description;
            Phone = phone;
            Email = email;
        }

        public override string ToString()
        {
            return $"Name : {Name}\nAddress : {Address}\nDescription : {Description}\nPhone : {Phone}\nEmail : {Email}\n";
        }
    }
}
