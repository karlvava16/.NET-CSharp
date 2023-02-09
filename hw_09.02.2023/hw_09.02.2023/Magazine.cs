using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hw_06._02._2023
{
    public class Magazine
    {
        string name;
        string year;
        string description;
        string phone;
        string email;

        public uint Staff { get; set; }
        public string Name { get { return name; } set { name = value; } }
        public string Year { get { return year; } set { year = value; } }
        public string Phone { get { return phone; } set { phone = value; } }
        public string Email { get { return email; } set { email = value; } }
        public string Description { get { return description; } set { description = value; } }
        public Magazine() { }

        public Magazine(string name, string year, string description, string phone, string email, uint staff)
        { 
            Name = name;
            Year = year;
            Phone = phone;
            Email = email;
            Description = description;
            Staff = staff;
        }

        public static Magazine operator + (Magazine m, uint staff)
        {
            Magazine temp = m;
            temp.Staff = temp.Staff + staff;
            return temp;
        }

        public static Magazine operator -(Magazine m, uint staff)
        {
            Magazine temp = m;
            temp.Staff = temp.Staff - staff;
            return temp;
        }

        public static Magazine operator +(uint staff, Magazine m)
        {
            Magazine temp = m;
            temp.Staff =  staff + temp.Staff;
            return temp;
        }
        public static Magazine operator -( uint staff, Magazine m)
        {
            Magazine temp = m;
            temp.Staff = staff - temp.Staff;
            return temp;
        }

        public static bool operator ==(Magazine a, Magazine b)
        {
            return a.Staff == b.Staff;
        }
        public static bool operator !=(Magazine a, Magazine b)
        {
            return a.Staff != b.Staff;
        }
        public static bool operator >(Magazine a, Magazine b)
        {
            return a.Staff > b.Staff;
        }
        public static bool operator <(Magazine a, Magazine b)
        {
            return a.Staff < b.Staff;
        }

        public override string ToString()
        {
            return $"Name : {Name}\nYear : {Year}\nPhone : {Phone}\nEmail : {Email}\nDescription : {Description}\nStaff : {Staff}";
        }
    }
}
