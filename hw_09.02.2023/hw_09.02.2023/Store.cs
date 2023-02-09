using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework
{
    public class Store
    {
        string name;
        string address;
        string description;
        string phone;
        string email;
        public double Square { get; set; }
        public string Name { get { return name; } set { name = value; } }
        public string Address { get { return address; } set { address = value; } }
        public string Description { get { return description; } set { description = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Email { get { return email; } set { email = value; } }

        public Store() { }

        public Store (string name, string address, string description, string phone, string email, double square)
        {
            Name = name;
            Address = address;
            Description = description;
            Phone = phone;
            Email = email;
            Square = square;
        }


        public static Store operator+(Store s, double sq)
        {
            Store temp = s;
            temp.Square += sq;
            return temp;
        }

        public static Store operator -(Store s, double sq)
        {
            Store temp = s;
            temp.Square -= sq;
            return temp;
        }

        public static Store operator +( double sq, Store s)
        {
            Store temp = s;
            temp.Square = sq + temp.Square;
            return temp;
        }

        public static Store operator -(double sq, Store s)
        {
            Store temp = s;
            temp.Square = sq - temp.Square;
            return temp;
        }

        public static bool operator ==(Store s1, Store s2)
        {
            return s1.Square == s2.Square;
        }
        public static bool operator !=(Store s1, Store s2)
        {
            return s1.Square != s2.Square;
        }

        public static bool operator <(Store s1, Store s2)
        {
            return s1.Square < s2.Square;
        }
        public static bool operator >(Store s1, Store s2)
        {
            return s1.Square > s2.Square;
        }

        public override string ToString()
        {
            return $"Name : {Name}\nAddress : {Address}\nDescription : {Description}\nPhone : {Phone}\nEmail : {Email}\nSquare : {Square}";
        }
    }
}
